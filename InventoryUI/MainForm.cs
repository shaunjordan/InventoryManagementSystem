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
        public MainForm()
        {
            InitializeComponent();

            Inventory inventory = new Inventory();
            Inhouse newPart = new Inhouse();
            newPart.partID = 2;
            newPart.name = "Wrench";
            newPart.machineID = 4;

            Outsourced outsourcedpart = new Outsourced();
            outsourcedpart.name = "Filter";
            
            inventory.AddPart(newPart);
            inventory.AddPart(outsourcedpart);

           //List<Inventory> list = new List<Inventory>(inventory.getPartsList());

            //var allParts = new BindingList<Inventory>(list);
            //partsDataGrid.DataSource = allParts;
            partsDataGrid.DataSource = inventory.getPartsList();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addPartsButton_Click(object sender, EventArgs e)
        {
            AddPart addPartForm = new AddPart();
            addPartForm.Show();
        }
    }
}
