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
    public partial class ModifyProduct : Form
    {
        Inventory inventory;
        public ModifyProduct(Inventory inventoryClass, Product product)
        {
            InitializeComponent();
            inventory = inventoryClass;

            modifyProductIDTextBox.Text = product.productID.ToString();
            modifyProductNameTextBox.Text = product.name;
            modifyProductInvTextBox.Text = product.inStock.ToString();
            modifyProductPriceCostTextBox.Text = product.price.ToString("C", new System.Globalization.CultureInfo("en-US"));
            modifyProductMinTextBox.Text = product.min.ToString();
            modifyProductMaxTextBox.Text = product.max.ToString();

            modifyProductPartsDataGrid.DataSource = inventory.GetPartsList();
            modifyAssocPartsDataGrid.DataSource = product.GetAssociatedParts();
        }

        private void modifyCancelProductButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
