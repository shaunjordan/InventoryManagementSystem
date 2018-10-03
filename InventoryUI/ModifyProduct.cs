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
    public partial class ModifyProduct :  Form
    {
        
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

            int minVal = Convert.ToInt32(modifyProductMinTextBox.Text);
            int maxVal = Convert.ToInt32(modifyProductMaxTextBox.Text);
            int invVal = Convert.ToInt32(modifyProductInvTextBox.Text);

            if (minVal > maxVal)
            {
                modifyProductMinTextBox.BackColor = Color.Red;
                MessageBox.Show("Minimum value cannot be greater than maximum value. Please correct.", "Invalid Values");
                return;
            }

            if (invVal < minVal || invVal > maxVal)
            {
                modifyProductInvTextBox.BackColor = Color.Red;
                MessageBox.Show("Inventory value must not be lower than the minimum value or higher than the maximum value.", "Invalid Values");
                return;
            }

            Product newProduct = new Product
            {
                productID = Convert.ToInt32(modifyProductIDTextBox.Text),
                name = modifyProductNameTextBox.Text,
                inStock = invVal,
                price = double.Parse(modifyProductPriceCostTextBox.Text, System.Globalization.NumberStyles.Currency),
                min = minVal,
                max = maxVal
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
            try
            {
                Part partSelected = (Part)modifyAssocPartsDataGrid.CurrentRow.DataBoundItem;
                product.RemoveAssociatedPart(partSelected.partID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No part selected to delete.", "Error!");
                Console.Write(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }


        private void modifyProductPriceCostTextBox_Leave(object sender, EventArgs e)
        {
            double productPrice;

            if (double.TryParse(modifyProductPriceCostTextBox.Text, out productPrice))
            {
                modifyProductPriceCostTextBox.Text = productPrice.ToString("C", new System.Globalization.CultureInfo("en-US"));
                modifyProductPriceCostTextBox.BackColor = Color.White;
                modifySaveProductButton.Enabled = true;
            }

            try
            {
                productPrice = double.Parse(modifyProductPriceCostTextBox.Text, System.Globalization.NumberStyles.Currency);
            }
            catch (Exception ex)
            {
                modifyProductPriceCostTextBox.BackColor = Color.Red;
                modifySaveProductButton.Enabled = false;
                Console.WriteLine(ex.Message);
            }
        }


        private void modifyProductInvTextBox_TextChanged(object sender, EventArgs e)
        {
            int invVal;
            modifyProductInvTextBox.BackColor = Color.White;
            modifySaveProductButton.Enabled = true;

            if (!int.TryParse(modifyProductInvTextBox.Text, out invVal))
            {
                modifyProductInvTextBox.BackColor = Color.Red;
                modifySaveProductButton.Enabled = false;
            }

            if (invVal < 0)
            {
                modifyProductInvTextBox.BackColor = Color.Red;
                modifySaveProductButton.Enabled = false;
            }
        }

        private void modifyProductMinTextBox_TextChanged(object sender, EventArgs e)
        {
            int minVal;
            modifyProductMinTextBox.BackColor = Color.White;
            modifySaveProductButton.Enabled = true;

            if (!int.TryParse(modifyProductMinTextBox.Text, out minVal))
            {
                modifyProductMinTextBox.BackColor = Color.Red;
                modifySaveProductButton.Enabled = false;
            }

            if (minVal < 0)
            {
                modifyProductMinTextBox.BackColor = Color.Red;
                modifySaveProductButton.Enabled = false;
            }
        }

        private void modifyProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            int maxVal;
            modifyProductMaxTextBox.BackColor = Color.White;
            modifySaveProductButton.Enabled = true;

            if (!int.TryParse(modifyProductMaxTextBox.Text, out maxVal))
            {
                modifyProductMaxTextBox.BackColor = Color.Red;
                modifySaveProductButton.Enabled = false;
            }

            if (maxVal < 0)
            {
                modifyProductMaxTextBox.BackColor = Color.Red;
                modifySaveProductButton.Enabled = false;
            }
        }

        private void modifyAssocPartSearchButton_Click(object sender, EventArgs e)
        {          
            Part searchedPart;
            string searchTerm = modifyAssocPartSearchTextBox.Text.ToLower();
            int s;
            int rowIndex = -1;

            if (product.GetAssociatedParts().Count > 0)
            {
                if (int.TryParse(searchTerm, out s))
                {
                    searchedPart = product.LookupAssociatedPart(s);
                }
                else
                {
                    searchedPart = product.LookupAssociatedPart(searchTerm);
                }
            }

            if (int.TryParse(searchTerm, out s))
            {
                searchedPart = inventory.LookupPart(s);
            }
            else
            {
                searchedPart = inventory.LookupPart(searchTerm);
            }

            foreach (DataGridViewRow row in modifyProductPartsDataGrid.Rows)
            {
                if (row.DataBoundItem.Equals(searchedPart))
                {
                    rowIndex = row.Index;
                    modifyProductPartsDataGrid.CurrentCell = modifyProductPartsDataGrid.Rows[rowIndex].Cells[0];
                    break;
                }
            }
        }
    }
}
