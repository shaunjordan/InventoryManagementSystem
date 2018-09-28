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

            partsDataGrid.DataSource = inventory.GetPartsList();
            productsDataGrid.DataSource = inventory.GetProductList();

            partsDataGrid.Columns[2].DefaultCellStyle.Format = "C";
            productsDataGrid.Columns[2].DefaultCellStyle.Format = "C";
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
            inventory.RemoveProduct(productToDelete);
        }
    }
}
