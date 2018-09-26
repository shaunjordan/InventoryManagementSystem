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
            if (inhouseRadioButton.Checked)
                {

                    inventory.AddPart(new Inhouse
                    {
                        partID = inventory.AssignPartID(),
                        name = partNameTextBox.Text,
                        price = double.Parse(partPriceCostTextBox.Text, System.Globalization.NumberStyles.Currency),
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
                    price = double.Parse(partPriceCostTextBox.Text, System.Globalization.NumberStyles.Currency),
                    inStock = Convert.ToInt32(partInvTextBox.Text),
                    min = Convert.ToInt32(partMinTextBox.Text),
                    max = Convert.ToInt32(partMaxTextBox.Text),
                    companyName = partCompanyNameMachineIDTextBox.Text
                });
            }
            this.Close();
        }

           #region Label changes
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
            #endregion

       
        private void partPriceCostTextBox_Leave(object sender, EventArgs e)
        {
            //Converts entered number into currency format for display
            double price;
            if (double.TryParse(partPriceCostTextBox.Text, out price))
            {
                partPriceCostTextBox.Text = price.ToString("C", new System.Globalization.CultureInfo("en-US"));
            }
        }

        private void partInvTextBox_TextChanged(object sender, EventArgs e)
        {
            //int invVal;
            //partInvTextBox.BackColor = Color.White;
            //savePartButton.Enabled = true;
            //if (!int.TryParse(partInvTextBox.Text, out invVal))
            //{
            //    partInvTextBox.BackColor = Color.Red;
            //    savePartButton.Enabled = false;
            //}
            
        }

        private void cancelAddPartButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
