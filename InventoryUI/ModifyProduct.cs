using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementLibrary;

namespace InventoryUI
{
    public partial class ModifyProduct : Form
    {
        //TODO - data validation like add part
        //TODO - cannot save if not associated parts selected
        Inventory inventory;

        //intermediarty list
        BindingSource productParts = new BindingSource();
        Product product;
        
        public ModifyProduct(Inventory inventoryClass, Product modProduct)
        {
            InitializeComponent();
            inventory = inventoryClass;
            product = modProduct;

            modifyProductIDTextBox.Text = product.productID.ToString();
            modifyProductNameTextBox.Text = product.name;
            modifyProductInvTextBox.Text = product.inStock.ToString();
            modifyProductPriceCostTextBox.Text = product.price.ToString("C", new System.Globalization.CultureInfo("en-US"));
            modifyProductMinTextBox.Text = product.min.ToString();
            modifyProductMaxTextBox.Text = product.max.ToString();

            modifyProductPartsDataGrid.DataSource = inventory.GetPartsList();
            
            productParts.DataSource = product.GetAssociatedParts();
            modifyAssocPartsDataGrid.DataSource = productParts;
        }

        private void modifySaveProductButton_Click(object sender, EventArgs e)
        {
            var productToEdit = inventory.GetProductList().FirstOrDefault(editProduct => editProduct.productID == Convert.ToInt32(modifyProductIDTextBox.Text));
            int productIndex = inventory.GetProductList().IndexOf(productToEdit);

            Product newProduct = new Product
            {
                productID = Convert.ToInt32(modifyProductIDTextBox.Text),
                name = modifyProductNameTextBox.Text,
                inStock = Convert.ToInt32(modifyProductInvTextBox.Text),
                price = double.Parse(modifyProductPriceCostTextBox.Text, System.Globalization.NumberStyles.Currency),
                min = Convert.ToInt32(modifyProductMinTextBox.Text),
                max = Convert.ToInt32(modifyProductMaxTextBox.Text)
            };
            foreach (Part part in productParts)
            {
                newProduct.AddAssociatedPart(part);
            }
            inventory.UpdateProduct(productIndex, newProduct);
            this.Close();
        }

        private void modifyCancelProductButton_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure you want to cancel the edit? Changes will not be saved.", "Confirm Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void modifyAddAssocProductButton_Click(object sender, EventArgs e)
        {
            productParts.Add((Part)modifyProductPartsDataGrid.CurrentRow.DataBoundItem);
        }

        private void modifyDeleteAssocPart_Click(object sender, EventArgs e)
        {
            Part partSelected = (Part)modifyAssocPartsDataGrid.CurrentRow.DataBoundItem;
            product.RemoveAssociatedPart(partSelected.partID);
        }

        private void modifyProductPriceCostTextBox_Leave(object sender, EventArgs e)
        {
            double productPrice;
            if (double.TryParse(modifyProductPriceCostTextBox.Text, out productPrice))
            {
                modifyProductPriceCostTextBox.Text = productPrice.ToString("C", new System.Globalization.CultureInfo("en-US"));
            }
        }
    }
}
