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
            bool formValid = true;
            //Random randPartNumber = new Random();
            

            if (partNameTextBox.Text == "")
            {
                partNameTextBox.BackColor = Color.Red;
                formValid = false;
                errorMessage();
            }

            if (formValid)
            {
                if (inhouseRadioButton.Checked)
                {

                    inventory.AddPart(new Inhouse
                    {
                        partID = inventory.AssignPartID(),
                        name = partNameTextBox.Text,
                        price = Convert.ToDouble(partPriceCostTextBox.Text),
                        inStock = Convert.ToInt32(partInvTextBox.Text),
                        min = Convert.ToInt32(partMinTextBox.Text),
                        max = Convert.ToInt32(partMaxTextBox.Text),
                        machineID = Convert.ToInt32(partCompanyNameMachineIDTextBox.Text)
                    });
                }

                if (outsourcedRadioButton.Checked)
                {

                    inventory.AddPart(new Outsourced
                    {
                        partID = inventory.AssignPartID(),
                        name = partNameTextBox.Text,
                        price = Convert.ToDouble(partPriceCostTextBox.Text),
                        inStock = Convert.ToInt32(partInvTextBox.Text),
                        min = Convert.ToInt32(partMinTextBox.Text),
                        max = Convert.ToInt32(partMaxTextBox.Text),
                        companyName = partCompanyNameMachineIDTextBox.Text
                    });
                }
            }




            //this.Close();
        }

        private void errorMessage()
        {
            MessageBox.Show("Please correct the highlighted fields to continue.");
        }

        private void inhouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            partCompanyMachineLabel.Text = "Machine ID";
            partCompanyNameMachineIDTextBox.Text = "Machine ID";
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            partCompanyMachineLabel.Text = "Company Name";
            partCompanyNameMachineIDTextBox.Text = "Company Name";
        }
    }
}
