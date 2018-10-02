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
    public partial class MainForm : Form
    {
        //TODO - question: if product with associated part cannot be deleted
        //and product cannot be saved without associated parts
        // how can a product ever be deleted?
        Inventory inventory = new Inventory();

        BindingSource partListSource = new BindingSource();
        BindingSource productListSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
       
            #region Sample data generation for debugging purposes

           
            Outsourced newOutsourced = new Outsourced
            {
                partID = 456,
                name = "Disc Brake",
                price = 29.99,
                inStock = 4,
                min = 2,
                max = 10,
                companyName = "Advanced Braking Co."
            };

            Inhouse newInhouse = new Inhouse
            {
                partID = 197,
                name = "Front Light",
                price = 15.99,
                inStock = 7,
                min = 5,
                max = 15,
                machineID = 51347
            };

            inventory.AddPart(newOutsourced);
            inventory.AddPart(newInhouse);

            //Inhouse n = new Inhouse();
            //n.partID = 76;
            //n.name = "Rambotuner";

            Product electricScooter = new Product
            {
                productID = 534,
                name = "Electric Scooter",
                inStock = 7,
                price = 149.00,
                min = 3,
                max = 10
            };
            electricScooter.AddAssociatedPart(newOutsourced);
            electricScooter.AddAssociatedPart(newInhouse);

            Product chainBicycle = new Product
            {
                productID = 819,
                name = "Single-Speed Bike",
                inStock = 5,
                price = 99,
                min = 2,
                max = 8
            };

            chainBicycle.AddAssociatedPart(newInhouse);

            inventory.AddProduct(electricScooter);
            inventory.AddProduct(chainBicycle);
            #endregion

            partListSource.DataSource = inventory.GetPartsList();
            partsDataGrid.DataSource = partListSource;
        
            productListSource.DataSource = inventory.GetProductList();
            productsDataGrid.DataSource = productListSource;

            partsDataGrid.Columns[2].DefaultCellStyle.Format = "C";
            
            productsDataGrid.Columns[2].DefaultCellStyle.Format = "C";
            productsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //TODO productsDataGrid.Columns[3].MinimumWidth = "*";
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Confirm Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addPartsButton_Click(object sender, EventArgs e)
        {
            AddPart addPartForm = new AddPart(inventory);
            addPartForm.Show();
        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                var partToDelete = (Part)partsDataGrid.CurrentRow.DataBoundItem;
                if (MessageBox.Show("Are you sure you want to delete the part?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    inventory.DeletePart(partToDelete);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No part has been selected to delete.", "Error!");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
                     
            
            
            //if (Object.ReferenceEquals(null, partToDelete)) { MessageBox.Show(partToDelete.ToString()); }
            //partsDataGrid.CurrentRow.DataBoundItem.GetType().ToString();
        }

        private void modifyPartButton_Click(object sender, EventArgs e)
        {

            Outsourced partToModifyOs; 
            Inhouse partToModifyIh;

            if (partsDataGrid.CurrentRow.DataBoundItem.GetType() == typeof(Outsourced))
            {
                partToModifyOs = (Outsourced)partsDataGrid.CurrentRow.DataBoundItem;
                ModifyPart modifyPartForm = new ModifyPart(inventory, partToModifyOs);
                modifyPartForm.Show();
            }

            if (partsDataGrid.CurrentRow.DataBoundItem.GetType() == typeof(Inhouse))
            {
                partToModifyIh = (Inhouse)partsDataGrid.CurrentRow.DataBoundItem;
                ModifyPart modifyPartForm = new ModifyPart(inventory, partToModifyIh);
                modifyPartForm.Show();
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProduct addProductForm = new AddProduct(inventory);
            addProductForm.Show();
        }

        private void modifyProductButton_Click(object sender, EventArgs e)
        {
            Product productToModify = (Product)productsDataGrid.CurrentRow.DataBoundItem;

            ModifyProduct modifyProductForm = new ModifyProduct(inventory, productToModify);
            modifyProductForm.Show();
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                var productToDelete = (Product)productsDataGrid.CurrentRow.DataBoundItem;
                
                if (productToDelete.GetAssociatedParts().Count() > 0)
                {
                    MessageBox.Show("Products with associated parts cannot be deleted.");
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete the Product?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    inventory.RemoveProduct(productToDelete);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No part has been selected to delete.", "Error!");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            inventory.GetPartsList();
            inventory.GetProductList();

            partListSource.ResetBindings(false);
            productListSource.ResetBindings(false);
        }

        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            Part searchedPart;
            string searchTerm = partSearchTextBox.Text.ToLower();
            int s;
            int rowIndex = -1;

            if (int.TryParse(searchTerm, out s))
            {
                searchedPart = inventory.LookupPart(s);
            } else
            {
                searchedPart = inventory.LookupPart(searchTerm);
            }

            foreach (DataGridViewRow row in partsDataGrid.Rows)
            {
                if (row.DataBoundItem.Equals(searchedPart))
                {
                    rowIndex = row.Index;

                    partsDataGrid.CurrentCell = partsDataGrid.Rows[rowIndex].Cells[0];
                    break;
                }
            }
        }

        private void productSearchButton_Click(object sender, EventArgs e)
        {
            Product searchedPart;
            string searchTerm = productSearchTextBox.Text.ToLower();
            int s;
            int rowIndex = -1;
                      
            if (int.TryParse(searchTerm, out s))
            {
                searchedPart = inventory.LookupProduct(s);
            }
            else
            {
                searchedPart = inventory.LookupProduct(searchTerm);
            }

            foreach (DataGridViewRow row in productsDataGrid.Rows)
            {
                if (row.DataBoundItem.Equals(searchedPart))
                {
                    rowIndex = row.Index;

                    productsDataGrid.CurrentCell = productsDataGrid.Rows[rowIndex].Cells[0];
                    break;
                }
            }
        }
    }
}
