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
        public AddPart()
        {
            InitializeComponent();

        }

        private void savePartButton_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            Inhouse part = new Inhouse();
            part.partID = 2;
            part.name = partNameTextBox.Text;

            inventory.AddPart(part);

            this.Close();            
        }
    }
}
