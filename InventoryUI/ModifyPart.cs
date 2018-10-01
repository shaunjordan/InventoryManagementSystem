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
            //TODO - cleanup this code and add the rest of the part items for update. including data validation
            
            var partToEdit = inventory.GetPartsList().FirstOrDefault(editPart => editPart.partID == Convert.ToInt32(modifyPartIDTextBox.Text));
            int partIndex = inventory.GetPartsList().IndexOf(partToEdit);

            if (modifyInhouseRadioButton.Checked)
            {
                Inhouse modIHPart = new Inhouse();
                modIHPart.partID = Convert.ToInt32(modifyPartIDTextBox.Text);
                modIHPart.name = modifyPartNameTextBox.Text;
                modIHPart.inStock = Convert.ToInt32(modifyPartInvTextBox.Text);
                modIHPart.price = double.Parse(modifyPartPriceCostTextBox.Text, System.Globalization.NumberStyles.Currency);
                modIHPart.min = Convert.ToInt32(modifyPartMinTextBox.Text);
                modIHPart.max = Convert.ToInt32(modifyPartMaxTextBox.Text);
                modIHPart.machineID = Convert.ToInt32(modifyPartCompanyOrMachine.Text);

                inventory.UpdatePart(partIndex, modIHPart);
            }

            if (modifyOutsourcedRadioButton.Checked)
            {
                Outsourced modOsPart = new Outsourced();
                modOsPart.partID = Convert.ToInt32(modifyPartIDTextBox.Text);
                modOsPart.name = modifyPartNameTextBox.Text;
                modOsPart.inStock = Convert.ToInt32(modifyPartInvTextBox.Text);
                modOsPart.price = double.Parse(modifyPartPriceCostTextBox.Text, System.Globalization.NumberStyles.Currency);
                modOsPart.min = Convert.ToInt32(modifyPartMinTextBox.Text);
                modOsPart.max = Convert.ToInt32(modifyPartMaxTextBox.Text);
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
    }
}
