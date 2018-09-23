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
    public partial class AddPart : Form
    {
        
        private Inventory inventory;

        public AddPart(Inventory inventoryClass)
        {
            InitializeComponent();

            inventory = inventoryClass;
            
        }

        private void savePartButton_Click(object sender, EventArgs e)
        {
            Random randPartNumber = new Random();           
            Inhouse part = new Inhouse();
            part.partID = randPartNumber.Next(1000, 99999);
            part.name = partNameTextBox.Text;
            


            inventory.AddPart(part);


            //this.Close();
        }
    }
}
