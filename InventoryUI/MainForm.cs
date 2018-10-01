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
        Inventory inventory = new Inventory();

        BindingSource partListSource = new BindingSource();
        BindingSource productListSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
       
            #region Sample data generation for debugging purposes

            inventory.AddPart(new Outsourced {
                partID = 456,
                name = "Disc Brake",
                price = 29.99,
                inStock = 4,
                min = 2, 
                max = 10,
                companyName = "Advanced Braking Co."
            });

            inventory.AddPart(new Inhouse {
                partID = 197,
                name = "Front Light",
                price = 15.99,
                inStock = 7,
                min = 5,
                max = 15,
                machineID = 51347
            });

            //Inhouse n = new Inhouse();
            //n.partID = 76;
            //n.name = "Rambotuner";

            inventory.AddProduct(new Product
            {
                productID = 534,
                name = "Electric Scooter",
                inStock = 7,
                price = 47.00,
                min = 3,
                max = 10            

            });
            //Product product = new Product();
            //product.name = "Hifi Wifi";
            //product.AddAssociatedPart(n);

            //inventory.AddProduct(product);
            
            partListSource.DataSource = inventory.GetPartsList();
            partsDataGrid.DataSource = partListSource;
        
            productListSource.DataSource = inventory.GetProductList();
            productsDataGrid.DataSource = productListSource;

            partsDataGrid.Columns[2].DefaultCellStyle.Format = "C";
            
            productsDataGrid.Columns[2].DefaultCellStyle.Format = "C";
            productsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //productsDataGrid.Columns[3].MinimumWidth = "*";
            #endregion
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
            //TODO - check if selection is null try/catch?
            
            var partToDelete = (Part)partsDataGrid.CurrentRow.DataBoundItem;
                     
            if (MessageBox.Show("Are you sure you want to delete the part?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                inventory.DeletePart(partToDelete);
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
            var productToDelete = (Product)productsDataGrid.CurrentRow.DataBoundItem;
            
            if (MessageBox.Show("Are you sure you want to delete the part?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                inventory.RemoveProduct(productToDelete);
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
            //partsDataGrid.CurrentRow.Selected = false;

            string searchTerm = partSearchTextBox.Text;

            //int rowIndex = -1;
            ////TODO - overload to take a string
            //Part searchedPart = inventory.LookupPart(Convert.ToInt32(partSearchTextBox.Text));

            //foreach (DataGridViewRow row in partsDataGrid.Rows)
            //{
            //    if (row.DataBoundItem.Equals(searchedPart))
            //    {
            //        rowIndex = row.Index;

            //        //search is selecting two rows when searching for the second item
            //        partsDataGrid.Rows[rowIndex].Selected = false;
            //        partsDataGrid.Rows[rowIndex].Selected = true;

            //        break;
            //    }
            //}
            var searchResult = inventory.GetPartsList().Where(part => part.name.Contains(searchTerm));
            MessageBox.Show(searchResult.ToString());
            
        }
    }
}
