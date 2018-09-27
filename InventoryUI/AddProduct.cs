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
    public partial class AddProduct : Form
    {
        private Inventory inventory;
        BindingList<Part> partSelections = new BindingList<Part>(); 

        public AddProduct(Inventory inventoryClass)
        {
            InitializeComponent();
            inventory = inventoryClass;
            

            productPartsDataGrid.DataSource = inventory.GetPartsList();
            assocPartsDataGrid.DataSource = partSelections;

        }

        private void saveProductButton_Click(object sender, EventArgs e)
        {
            //Product product = new Product();
            //product.AddAssociatedPart((Part)productPartsDataGrid.CurrentRow.DataBoundItem);
            inventory.AddProduct(new Product
            {
                productID = inventory.AssignID(),
                name = productNameTextBox.Text,
                inStock = Convert.ToInt32(productInvTextBox.Text),
                price = double.Parse(productPriceCostTextBox.Text, System.Globalization.NumberStyles.Currency),
                min = Convert.ToInt32(productMinTextBox.Text),
                max = Convert.ToInt32(productMaxTextBox.Text),
                AssociatedParts = new BindingList<Part>((Part)productPartsDataGrid.CurrentRow.DataBoundItem);
                
            });
            

            
            
            
            //TODO - add selected part to associated parts list for the product

            this.Close();
         }

        private void productPriceCostTextBox_Leave(object sender, EventArgs e)
        {
            //Converts price value to currency format for aesthetic
            double productPrice;
            if (double.TryParse(productPriceCostTextBox.Text, out productPrice))
            {
                productPriceCostTextBox.Text = productPrice.ToString("C", new System.Globalization.CultureInfo("en-US"));
            }
        }

        private void cancelProductButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addAssocProductButton_Click(object sender, EventArgs e)
        {
            partSelections.Add((Part)productPartsDataGrid.CurrentRow.DataBoundItem);
        }
    }
}
