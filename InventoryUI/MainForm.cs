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
       
            Product newProduct = new Product() { productID = 5, name="Bicycle"};

            #region Sample data for table population

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

            //inventory.AddProduct({ });
            #endregion
            

            productsDataGrid.DataSource = inventory.getProductList();
            partsDataGrid.DataSource = inventory.getPartsList();
            
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addPartsButton_Click(object sender, EventArgs e)
        {
            AddPart addPartForm = new AddPart(inventory);
            addPartForm.Show();
        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            //partsDataGrid.SelectedRows[0].Index.ToString();
            
            string itemToDelete = partsDataGrid[partsDataGrid.CurrentCell.ColumnIndex, partsDataGrid.CurrentCell.RowIndex].Value.ToString();
            //Inventory p =
            //List<Part> toRemove = inventory.getPartsList().

            
            //inventory.DeletePart();

        }
    }
}
