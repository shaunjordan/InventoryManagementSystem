﻿using System;
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
            modifyPartCompanyName.Text = part.machineID.ToString();

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
            modifyPartCompanyName.Text = part.companyName;
        }

        private void modifySavePartButton_Click(object sender, EventArgs e)
        {
            
        }

        private void modifyCancelAddPartButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
