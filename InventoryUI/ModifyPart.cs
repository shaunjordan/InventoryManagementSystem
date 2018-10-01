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

        public ModifyPart(Inventory inventoryClass, Inhouse part)
        {
            InitializeComponent();
            inventory = inventoryClass;


            modifyPartIDTextBox.Text = part.partID.ToString();
            modifyPartNameTextBox.Text = part.name;
            modifyPartInvTextBox.Text = part.inStock.ToString();
            modifyPartPriceCostTextBox.Text = part.price.ToString("C", new System.Globalization.CultureInfo("en-US"));
            modifyPartMinTextBox.Text = part.min.ToString();
            modifyPartMaxTextBox.Text = part.max.ToString();
            modifyPartCompanyOrMachine.Text = part.machineID.ToString();
            modifyPartMachineOrCompanyLabel.Text = "Machine ID";
            modifyInhouseRadioButton.Checked = true;
        }

        public ModifyPart(Inventory inventoryClass, Outsourced part)
        {
            InitializeComponent();
            inventory = inventoryClass;

            modifyPartIDTextBox.Text = part.partID.ToString();
            modifyPartNameTextBox.Text = part.name;
            modifyPartInvTextBox.Text = part.inStock.ToString();
            modifyPartPriceCostTextBox.Text = part.price.ToString("C", new System.Globalization.CultureInfo("en-US"));
            modifyPartMinTextBox.Text = part.min.ToString();
            modifyPartMaxTextBox.Text = part.max.ToString();
            modifyPartCompanyOrMachine.Text = part.companyName;
            modifyPartMachineOrCompanyLabel.Text = "Company Name";
            modifyOutsourcedRadioButton.Checked = true;
        }

        private void modifySavePartButton_Click(object sender, EventArgs e)
        {
            //TODO - add the same data validation on the add part code behind
            
            var partToEdit = inventory.GetPartsList().FirstOrDefault(editPart => editPart.partID == Convert.ToInt32(modifyPartIDTextBox.Text));
            int partIndex = inventory.GetPartsList().IndexOf(partToEdit);
            int minVal = Convert.ToInt32(modifyPartMinTextBox.Text);
            int maxVal = Convert.ToInt32(modifyPartMaxTextBox.Text);
            int invVal = Convert.ToInt32(modifyPartInvTextBox.Text);

            if (minVal > maxVal)
            {
                modifyPartMinTextBox.BackColor = Color.Red;
                MessageBox.Show("Minimum value cannot be greater than maximum value. Please correct.", "Invalid Values");
                return;
            }

            if (invVal < minVal || invVal > maxVal)
            {
                modifyPartInvTextBox.BackColor = Color.Red;
                MessageBox.Show("Inventory value must not be lower than the minimum value or higher than the maximum value.", "Invalid Values");
                return;
            }

            if (modifyInhouseRadioButton.Checked)
            {
                Inhouse modIHPart = new Inhouse();
                modIHPart.partID = Convert.ToInt32(modifyPartIDTextBox.Text);
                modIHPart.name = modifyPartNameTextBox.Text;
                modIHPart.inStock = invVal;
                modIHPart.price = double.Parse(modifyPartPriceCostTextBox.Text, System.Globalization.NumberStyles.Currency);
                modIHPart.min = minVal;
                modIHPart.max = maxVal;
                modIHPart.machineID = Convert.ToInt32(modifyPartCompanyOrMachine.Text);

                inventory.UpdatePart(partIndex, modIHPart);
            }

            if (modifyOutsourcedRadioButton.Checked)
            {
                Outsourced modOsPart = new Outsourced();
                modOsPart.partID = Convert.ToInt32(modifyPartIDTextBox.Text);
                modOsPart.name = modifyPartNameTextBox.Text;
                modOsPart.inStock = invVal;
                modOsPart.price = double.Parse(modifyPartPriceCostTextBox.Text, System.Globalization.NumberStyles.Currency);
                modOsPart.min = minVal;
                modOsPart.max = maxVal;
                modOsPart.companyName = modifyPartCompanyOrMachine.Text;

                inventory.UpdatePart(partIndex, modOsPart);
            }
     
            this.Close();
        }

        private void modifyCancelAddPartButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to cancel? Any changes will not be saved.", "Confirm Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void modifyInhouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            modifyPartMachineOrCompanyLabel.Text = "Machine ID";
        }

        private void modifyOutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            modifyPartMachineOrCompanyLabel.Text = "Company Name";
        }

        private void modifyPartPriceCostTextBox_Leave(object sender, EventArgs e)
        {
            double price;
            if (double.TryParse(modifyPartPriceCostTextBox.Text, out price))
            {
                modifyPartPriceCostTextBox.Text = price.ToString("C", new System.Globalization.CultureInfo("en-US"));
            }
        }

        private void modifyPartInvTextBox_TextChanged(object sender, EventArgs e)
        {
            int invVal;

            modifyPartInvTextBox.BackColor = Color.White;
            modifySavePartButton.Enabled = true;

            if (!int.TryParse(modifyPartInvTextBox.Text, out invVal))
            {
                modifyPartInvTextBox.BackColor = Color.Red;
                modifySavePartButton.Enabled = false;
            }

            if (invVal < 0)
            {
                modifyPartInvTextBox.BackColor = Color.Red;
                modifySavePartButton.Enabled = false;
            }
        }

        private void modifyPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            int minVal;


            modifyPartMinTextBox.BackColor = Color.White;
            modifySavePartButton.Enabled = true;

            if (!int.TryParse(modifyPartMinTextBox.Text, out minVal))
            {
                modifyPartMinTextBox.BackColor = Color.Red;
                modifySavePartButton.Enabled = false;
            }

            if (minVal < 0)
            {
                modifyPartMinTextBox.BackColor = Color.Red;
                modifySavePartButton.Enabled = false;
            }
        }

        private void modifyPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            int maxVal;


            modifyPartMaxTextBox.BackColor = Color.White;
            modifySavePartButton.Enabled = true;

            if (!int.TryParse(modifyPartMaxTextBox.Text, out maxVal))
            {
                modifyPartMaxTextBox.BackColor = Color.Red;
                modifySavePartButton.Enabled = false;
            }

            if (maxVal < 0)
            {
                modifyPartMaxTextBox.BackColor = Color.Red;
                modifySavePartButton.Enabled = false;
            }
        }

        private void modifyPartCompanyOrMachine_TextChanged(object sender, EventArgs e)
        {
            int validMachineID;
            //TODO - validation does not hit when selecting inhouse on outsourced product

            modifyPartCompanyOrMachine.BackColor = Color.White;
            modifySavePartButton.Enabled = true;

            if (modifyInhouseRadioButton.Checked)
            {
                if (!int.TryParse(modifyPartCompanyOrMachine.Text, out validMachineID))
                {
                    modifyPartCompanyOrMachine.BackColor = Color.Red;
                    modifySavePartButton.Enabled = false;
                }

                if (validMachineID < 0)
                {
                    modifyPartCompanyOrMachine.BackColor = Color.Red;
                    modifySavePartButton.Enabled = false;
                }
            }

        }
    }
}
