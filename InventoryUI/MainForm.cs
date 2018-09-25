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
        
        public MainForm()
        {
            InitializeComponent();
       
            #region Sample data generation for debugging purposes

            inventory.AddPart(new Outsourced {
                partID = inventory.AssignPartID(),
                name = "Disc Brake",
                price = 29.99,
                inStock = 4,
                min = 2, 
                max = 10,
                companyName = "Advanced Braking Co."
            });

            inventory.AddPart(new Inhouse {
                partID = inventory.AssignPartID(),
                name = "Front Light",
                price = 15.99,
                inStock = 7,
                min = 5,
                max = 15,
                machineID = 51347
            });

            inventory.AddProduct(new Product {
                productID = 5,
                name = "Electric Scooter",
                inStock = 7, 
                price = 47.00, //TODO - convert to currency
                min = 3, 
                max = 10
               
            });

            partsDataGrid.DataSource = inventory.getPartsList();
            productsDataGrid.DataSource = inventory.getProductList();
            #endregion
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //TODO confirm exit
            Application.Exit();
        }

        private void addPartsButton_Click(object sender, EventArgs e)
        {
            AddPart addPartForm = new AddPart(inventory);
            addPartForm.Show();
        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            //TODO - check if selection is null try/catch?
            //TODO - confirm deletion
            var partToDelete = (Part)partsDataGrid.CurrentRow.DataBoundItem;

            inventory.DeletePart(partToDelete);

            //if (Object.ReferenceEquals(null, partToDelete)) { MessageBox.Show(partToDelete.ToString()); }
            //partsDataGrid.CurrentRow.DataBoundItem.GetType().ToString();
        }

        private void modifyPartButton_Click(object sender, EventArgs e)
        {
            var partToModify = (Part)partsDataGrid.CurrentRow.DataBoundItem;
            ModifyPart modifyPartForm = new ModifyPart(inventory, partToModify);
            modifyPartForm.Show();
        }
    }
}
