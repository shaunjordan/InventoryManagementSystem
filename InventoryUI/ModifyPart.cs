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
    public partial class ModifyPart : Form
    {
        private Inventory inventory;

        public ModifyPart(Inventory inventoryClass, Part part)
        {
            InitializeComponent();
            inventory = inventoryClass;

            if (part.GetType() == typeof(Outsourced))
            {
                modifyPartIDTextBox.Text = part.partID.ToString();
                modifyPartNameTextBox.Text = part.name;
                modifyPartInvTextBox.Text = part.inStock.ToString();
                modifyPartMinTextBox.Text = part.min.ToString();
                modifyPartMaxTextBox.Text = part.min.ToString();
                //modifyPartCompanyName.Text = part.
            }

            //modifyPartIDTextBox.Text = part.partID.ToString();
            //modifyPartNameTextBox.Text = part.name;
            //modifyPartInvTextBox.Text = part.inStock.ToString();
            //modifyPartMinTextBox.Text = part.min.ToString();
            //modifyPartMaxTextBox.Text = part.min.ToString();
            ////modifyPartCompanyName.Text = part.
        }

        private void modifySavePartButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
