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

            //Datasource is the existing list of parts
            productPartsDataGrid.DataSource = inventory.GetPartsList();

            //Parts selected display in datagrid and are added to the Product's
            //AssociatedParts list
            assocPartsDataGrid.DataSource = partSelections;
        }


        private void saveProductButton_Click(object sender, EventArgs e)
        {

            int minVal = Convert.ToInt32(productMinTextBox.Text);
            int maxVal = Convert.ToInt32(productMaxTextBox.Text);
            int invVal = Convert.ToInt32(productInvTextBox.Text);

            
            if (minVal > maxVal)
            {
                productMinTextBox.BackColor = Color.Red;
                MessageBox.Show("Minimum value cannot be greater than maximum value. Please correct.", "Invalid Values");
                return;
            }

            if (invVal < minVal || invVal > maxVal)
            {
                productInvTextBox.BackColor = Color.Red;
                MessageBox.Show("Inventory value must not be lower than the minimum value or higher than the maximum value.", "Invalid Values");
                return;
            }

            if (partSelections.Count() == 0)
            {
                MessageBox.Show("A product must have at least one associated part.", "No Parts Selected");
                return;
            }

            Product newProduct = new Product
                {
                    productID = inventory.AssignID(),
                    name = productNameTextBox.Text,
                    inStock = invVal,
                    price = double.Parse(productPriceCostTextBox.Text, System.Globalization.NumberStyles.Currency),
                    min = minVal,
                    max = maxVal
                };
                foreach (Part part in partSelections)
                {
                    newProduct.AddAssociatedPart(part);
                }
                inventory.AddProduct(newProduct);
                this.Close();
         }


        private void productPriceCostTextBox_Leave(object sender, EventArgs e)
        {
            //Converts price value to currency format for aesthetic
            //TODO - this is weird
            double productPrice;
            productPriceCostTextBox.BackColor = Color.White;
            saveProductButton.Enabled = true;

            if (!double.TryParse(productPriceCostTextBox.Text, out productPrice))
            {
                productPriceCostTextBox.BackColor = Color.Red;
                saveProductButton.Enabled = false;
            } 

            if (double.TryParse(productPriceCostTextBox.Text, out productPrice))
            {
                productPriceCostTextBox.Text = productPrice.ToString("C", new System.Globalization.CultureInfo("en-US"));
            }           
        }


        private void cancelProductButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to cancel? Any changes will not be saved.", "Confirm Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void addAssocProductButton_Click(object sender, EventArgs e)
        {
            partSelections.Add((Part)productPartsDataGrid.CurrentRow.DataBoundItem);

        }


        private void deleteAssocPart_Click(object sender, EventArgs e)
        {
            try
            {
                assocPartsDataGrid.Rows.Remove(assocPartsDataGrid.SelectedRows[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No part has been selected to delete.", "Error!");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }


        private void assocPartSearchButton_Click(object sender, EventArgs e)
        {
            
            Part searchedPart;
            string searchTerm = assocPartSearchTextBox.Text.ToLower();
            int s;
            int rowIndex = -1;
                                                
            if (int.TryParse(searchTerm, out s))
            {
                searchedPart = inventory.LookupPart(s);

            }
            else
            {
                searchedPart = inventory.LookupPart(searchTerm);
            }

            foreach (DataGridViewRow row in productPartsDataGrid.Rows)
            {
                if (row.DataBoundItem.Equals(searchedPart))
                {
                    rowIndex = row.Index;

                    productPartsDataGrid.CurrentCell = productPartsDataGrid.Rows[rowIndex].Cells[0];
                    break;
                }
            }
        }


        private void productInvTextBox_TextChanged(object sender, EventArgs e)
        {
            int invVal;

            productInvTextBox.BackColor = Color.White;
            saveProductButton.Enabled = true;

            if (!int.TryParse(productInvTextBox.Text, out invVal))
            {
                productInvTextBox.BackColor = Color.Red;
                saveProductButton.Enabled = false;
            }

            if (invVal < 0)
            {
                productInvTextBox.BackColor = Color.Red;
                saveProductButton.Enabled = false;
            }
        }


        private void productMinTextBox_TextChanged(object sender, EventArgs e)
        {
            int minVal;

            productMinTextBox.BackColor = Color.White;
            saveProductButton.Enabled = true;

            if (!int.TryParse(productMinTextBox.Text, out minVal))
            {
                productMinTextBox.BackColor = Color.Red;
                saveProductButton.Enabled = false;
            }

            if (minVal < 0)
            {
                productMinTextBox.BackColor = Color.Red;
                saveProductButton.Enabled = false;
            }

        }


        private void productMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            int maxVal;

            productMaxTextBox.BackColor = Color.White;
            saveProductButton.Enabled = true;

            if (!int.TryParse(productMaxTextBox.Text, out maxVal))
            {
                productMaxTextBox.BackColor = Color.Red;
                saveProductButton.Enabled = false;
            }

            if (maxVal < 0)
            {
                productMaxTextBox.BackColor = Color.Red;
                saveProductButton.Enabled = false;
            }
        }
    }
}

