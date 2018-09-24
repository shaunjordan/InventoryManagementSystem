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



            Inhouse newPart = new Inhouse();
            newPart.partID = 2;
            newPart.name = "Wrench";
            newPart.machineID = 4;

            Outsourced outsourcedpart = new Outsourced();
            outsourcedpart.name = "Filter";

            Product newProduct = new Product() { productID = 5, name="Bicycle"};
            

            inventory.AddPart(newPart);
            inventory.AddPart(outsourcedpart);

            var bindingList = inventory.getPartsList();

            productsDataGrid.DataSource = inventory.getProductList();
            partsDataGrid.DataSource = bindingList;
            
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

            MessageBox.Show(itemToDelete);


            //inventory.DeletePart();

        }
    }
}
