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
            int minVal = Convert.ToInt32(partMinTextBox.Text);
            int maxVal = Convert.ToInt32(partMaxTextBox.Text);
            int invVal = Convert.ToInt32(partInvTextBox.Text);

            if (minVal > maxVal)
            {
                partMinTextBox.BackColor = Color.Red;
                MessageBox.Show("Minimum value cannot be greater than maximum value. Please correct.", "Invalid Values");
                return;
            }
            
            if (invVal < minVal || invVal > maxVal)
            {
                partInvTextBox.BackColor = Color.Red;
                MessageBox.Show("Inventory value must not be lower than the minimum value or higher than the maximum value.", "Invalid Values");
                return;
            }
        
            if (inhouseRadioButton.Checked)
            {
                inventory.AddPart(new Inhouse
                {
                    partID = inventory.AssignID(),
                    name = partNameTextBox.Text,
                    inStock = invVal,
                    price = double.Parse(partPriceCostTextBox.Text, System.Globalization.NumberStyles.Currency),
                    min = minVal,
                    max = maxVal,
                    machineID = Convert.ToInt32(partCompanyNameMachineIDTextBox.Text)
                });
            }

            if (outsourcedRadioButton.Checked)
            {
                inventory.AddPart(new Outsourced
                {
                    partID = inventory.AssignID(),
                    name = partNameTextBox.Text,
                    price = double.Parse(partPriceCostTextBox.Text, System.Globalization.NumberStyles.Currency),
                    inStock = invVal,
                    min = minVal,
                    max = maxVal,
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

       
        private void partInvTextBox_TextChanged(object sender, EventArgs e)
        {
            
            int invVal;
            partInvTextBox.BackColor = Color.White;
            savePartButton.Enabled = true;

            if (!int.TryParse(partInvTextBox.Text, out invVal))
            {
                partInvTextBox.BackColor = Color.Red;
                savePartButton.Enabled = false;
            }

            if (invVal < 0)
            {
                partInvTextBox.BackColor = Color.Red;
                savePartButton.Enabled = false;
            }
        }

        private void partPriceCostTextBox_Leave(object sender, EventArgs e)
        {

            double price;

            if (double.TryParse(partPriceCostTextBox.Text, out price))
            {
                partPriceCostTextBox.Text = price.ToString("C", new System.Globalization.CultureInfo("en-US"));
                partPriceCostTextBox.BackColor = Color.White;
                savePartButton.Enabled = true;
            }

            try
            {
                price = double.Parse(partPriceCostTextBox.Text, System.Globalization.NumberStyles.Currency);
            }
            catch (Exception ex)
            {
                partPriceCostTextBox.BackColor = Color.Red;
                savePartButton.Enabled = false;
                Console.WriteLine(ex.Message);
            }
        }

        private void cancelAddPartButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to cancel? Any changes will not be saved.", "Confirm Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void partMinTextBox_TextChanged(object sender, EventArgs e)
        {
            int minVal;
            partMinTextBox.BackColor = Color.White;
            savePartButton.Enabled = true;

            if (!int.TryParse(partMinTextBox.Text, out minVal))
            {
                partMinTextBox.BackColor = Color.Red;
                savePartButton.Enabled = false;
            }

            if (minVal < 0)
            {
                partMinTextBox.BackColor = Color.Red;
                savePartButton.Enabled = false;
            }
        }

        private void partMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            int maxVal;
            partMaxTextBox.BackColor = Color.White;
            savePartButton.Enabled = true;

            if (!int.TryParse(partMaxTextBox.Text, out maxVal))
            {
                partMaxTextBox.BackColor = Color.Red;
                savePartButton.Enabled = false;
            }

            if (maxVal < 0)
            {
                partMaxTextBox.BackColor = Color.Red;
                savePartButton.Enabled = false;
            }
        }

        private void partCompanyNameMachineIDTextBox_TextChanged(object sender, EventArgs e)
        {
            int validMachineID;
            partCompanyNameMachineIDTextBox.BackColor = Color.White;
            savePartButton.Enabled = true;

            if (inhouseRadioButton.Checked)
            {
                if (!int.TryParse(partCompanyNameMachineIDTextBox.Text, out validMachineID))
                {
                    partCompanyNameMachineIDTextBox.BackColor = Color.Red;
                    savePartButton.Enabled = false;
                }

                if (validMachineID < 0)
                {
                    partCompanyNameMachineIDTextBox.BackColor = Color.Red;
                    savePartButton.Enabled = false;
                }
            }
        }
    }
}
