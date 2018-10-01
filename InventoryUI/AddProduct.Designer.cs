﻿namespace InventoryUI
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productMinTextBox = new System.Windows.Forms.TextBox();
            this.productMaxTextBox = new System.Windows.Forms.TextBox();
            this.productPriceCostTextBox = new System.Windows.Forms.TextBox();
            this.productInvTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productMaxLabel = new System.Windows.Forms.Label();
            this.productMinLabel = new System.Windows.Forms.Label();
            this.productPriceCostLabel = new System.Windows.Forms.Label();
            this.productInvLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.assocPartSearchTextBox = new System.Windows.Forms.TextBox();
            this.assocPartSearchButton = new System.Windows.Forms.Button();
            this.productPartsDataGrid = new System.Windows.Forms.DataGridView();
            this.addAssocProductButton = new System.Windows.Forms.Button();
            this.assocPartsDataGrid = new System.Windows.Forms.DataGridView();
            this.deleteAssocPart = new System.Windows.Forms.Button();
            this.saveProductButton = new System.Windows.Forms.Button();
            this.cancelProductButton = new System.Windows.Forms.Button();
            this.addProductLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productPartsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assocPartsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // productMinTextBox
            // 
            this.productMinTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.productMinTextBox.Location = new System.Drawing.Point(216, 613);
            this.productMinTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productMinTextBox.Name = "productMinTextBox";
            this.productMinTextBox.Size = new System.Drawing.Size(116, 42);
            this.productMinTextBox.TabIndex = 25;
            this.productMinTextBox.Text = "Min";
            // 
            // productMaxTextBox
            // 
            this.productMaxTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.productMaxTextBox.Location = new System.Drawing.Point(430, 613);
            this.productMaxTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productMaxTextBox.Name = "productMaxTextBox";
            this.productMaxTextBox.Size = new System.Drawing.Size(116, 42);
            this.productMaxTextBox.TabIndex = 27;
            this.productMaxTextBox.Text = "Max";
            // 
            // productPriceCostTextBox
            // 
            this.productPriceCostTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.productPriceCostTextBox.Location = new System.Drawing.Point(216, 521);
            this.productPriceCostTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productPriceCostTextBox.Name = "productPriceCostTextBox";
            this.productPriceCostTextBox.Size = new System.Drawing.Size(284, 42);
            this.productPriceCostTextBox.TabIndex = 23;
            this.productPriceCostTextBox.Text = "Price";
            this.productPriceCostTextBox.Leave += new System.EventHandler(this.productPriceCostTextBox_Leave);
            // 
            // productInvTextBox
            // 
            this.productInvTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.productInvTextBox.Location = new System.Drawing.Point(216, 442);
            this.productInvTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productInvTextBox.Name = "productInvTextBox";
            this.productInvTextBox.Size = new System.Drawing.Size(284, 42);
            this.productInvTextBox.TabIndex = 21;
            this.productInvTextBox.Text = "Inv";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.productNameTextBox.Location = new System.Drawing.Point(216, 373);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(284, 42);
            this.productNameTextBox.TabIndex = 19;
            this.productNameTextBox.Text = "Product Name";
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.productIDTextBox.Location = new System.Drawing.Point(216, 304);
            this.productIDTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(228, 42);
            this.productIDTextBox.TabIndex = 17;
            this.productIDTextBox.Text = "Auto Generated";
            this.productIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productMaxLabel
            // 
            this.productMaxLabel.AutoSize = true;
            this.productMaxLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productMaxLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.productMaxLabel.Location = new System.Drawing.Point(348, 619);
            this.productMaxLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.productMaxLabel.Name = "productMaxLabel";
            this.productMaxLabel.Size = new System.Drawing.Size(66, 36);
            this.productMaxLabel.TabIndex = 26;
            this.productMaxLabel.Text = "Max";
            // 
            // productMinLabel
            // 
            this.productMinLabel.AutoSize = true;
            this.productMinLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productMinLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.productMinLabel.Location = new System.Drawing.Point(116, 619);
            this.productMinLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.productMinLabel.Name = "productMinLabel";
            this.productMinLabel.Size = new System.Drawing.Size(61, 36);
            this.productMinLabel.TabIndex = 24;
            this.productMinLabel.Text = "Min";
            // 
            // productPriceCostLabel
            // 
            this.productPriceCostLabel.AutoSize = true;
            this.productPriceCostLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productPriceCostLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.productPriceCostLabel.Location = new System.Drawing.Point(116, 527);
            this.productPriceCostLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.productPriceCostLabel.Name = "productPriceCostLabel";
            this.productPriceCostLabel.Size = new System.Drawing.Size(73, 36);
            this.productPriceCostLabel.TabIndex = 22;
            this.productPriceCostLabel.Text = "Price";
            // 
            // productInvLabel
            // 
            this.productInvLabel.AutoSize = true;
            this.productInvLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productInvLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.productInvLabel.Location = new System.Drawing.Point(116, 448);
            this.productInvLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.productInvLabel.Name = "productInvLabel";
            this.productInvLabel.Size = new System.Drawing.Size(51, 36);
            this.productInvLabel.TabIndex = 20;
            this.productInvLabel.Text = "Inv";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.productNameLabel.Location = new System.Drawing.Point(116, 379);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(86, 36);
            this.productNameLabel.TabIndex = 18;
            this.productNameLabel.Text = "Name";
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productIDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.productIDLabel.Location = new System.Drawing.Point(116, 304);
            this.productIDLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(42, 36);
            this.productIDLabel.TabIndex = 16;
            this.productIDLabel.Text = "ID";
            // 
            // assocPartSearchTextBox
            // 
            this.assocPartSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assocPartSearchTextBox.Location = new System.Drawing.Point(1162, 62);
            this.assocPartSearchTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.assocPartSearchTextBox.Name = "assocPartSearchTextBox";
            this.assocPartSearchTextBox.Size = new System.Drawing.Size(290, 31);
            this.assocPartSearchTextBox.TabIndex = 31;
            // 
            // assocPartSearchButton
            // 
            this.assocPartSearchButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.assocPartSearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.assocPartSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assocPartSearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.assocPartSearchButton.ForeColor = System.Drawing.SystemColors.Window;
            this.assocPartSearchButton.Location = new System.Drawing.Point(1034, 54);
            this.assocPartSearchButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.assocPartSearchButton.Name = "assocPartSearchButton";
            this.assocPartSearchButton.Size = new System.Drawing.Size(116, 48);
            this.assocPartSearchButton.TabIndex = 29;
            this.assocPartSearchButton.Text = "Search";
            this.assocPartSearchButton.UseVisualStyleBackColor = false;
            this.assocPartSearchButton.Click += new System.EventHandler(this.assocPartSearchButton_Click);
            // 
            // productPartsDataGrid
            // 
            this.productPartsDataGrid.AllowUserToAddRows = false;
            this.productPartsDataGrid.AllowUserToDeleteRows = false;
            this.productPartsDataGrid.AllowUserToResizeColumns = false;
            this.productPartsDataGrid.AllowUserToResizeRows = false;
            this.productPartsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productPartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productPartsDataGrid.Location = new System.Drawing.Point(730, 117);
            this.productPartsDataGrid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productPartsDataGrid.Name = "productPartsDataGrid";
            this.productPartsDataGrid.ReadOnly = true;
            this.productPartsDataGrid.RowHeadersVisible = false;
            this.productPartsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productPartsDataGrid.Size = new System.Drawing.Size(724, 281);
            this.productPartsDataGrid.TabIndex = 28;
            // 
            // addAssocProductButton
            // 
            this.addAssocProductButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addAssocProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.addAssocProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAssocProductButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.addAssocProductButton.ForeColor = System.Drawing.SystemColors.Window;
            this.addAssocProductButton.Location = new System.Drawing.Point(1314, 410);
            this.addAssocProductButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addAssocProductButton.Name = "addAssocProductButton";
            this.addAssocProductButton.Size = new System.Drawing.Size(140, 63);
            this.addAssocProductButton.TabIndex = 30;
            this.addAssocProductButton.Text = "Add";
            this.addAssocProductButton.UseVisualStyleBackColor = false;
            this.addAssocProductButton.Click += new System.EventHandler(this.addAssocProductButton_Click);
            // 
            // assocPartsDataGrid
            // 
            this.assocPartsDataGrid.AllowUserToAddRows = false;
            this.assocPartsDataGrid.AllowUserToDeleteRows = false;
            this.assocPartsDataGrid.AllowUserToResizeColumns = false;
            this.assocPartsDataGrid.AllowUserToResizeRows = false;
            this.assocPartsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.assocPartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assocPartsDataGrid.Location = new System.Drawing.Point(730, 521);
            this.assocPartsDataGrid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.assocPartsDataGrid.Name = "assocPartsDataGrid";
            this.assocPartsDataGrid.ReadOnly = true;
            this.assocPartsDataGrid.RowHeadersVisible = false;
            this.assocPartsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assocPartsDataGrid.Size = new System.Drawing.Size(724, 281);
            this.assocPartsDataGrid.TabIndex = 32;
            // 
            // deleteAssocPart
            // 
            this.deleteAssocPart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.deleteAssocPart.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.deleteAssocPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAssocPart.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.deleteAssocPart.ForeColor = System.Drawing.SystemColors.Window;
            this.deleteAssocPart.Location = new System.Drawing.Point(1314, 813);
            this.deleteAssocPart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deleteAssocPart.Name = "deleteAssocPart";
            this.deleteAssocPart.Size = new System.Drawing.Size(140, 63);
            this.deleteAssocPart.TabIndex = 33;
            this.deleteAssocPart.Text = "Delete";
            this.deleteAssocPart.UseVisualStyleBackColor = false;
            this.deleteAssocPart.Click += new System.EventHandler(this.deleteAssocPart_Click);
            // 
            // saveProductButton
            // 
            this.saveProductButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.saveProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.saveProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveProductButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.saveProductButton.ForeColor = System.Drawing.SystemColors.Window;
            this.saveProductButton.Location = new System.Drawing.Point(1162, 960);
            this.saveProductButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.saveProductButton.Name = "saveProductButton";
            this.saveProductButton.Size = new System.Drawing.Size(140, 63);
            this.saveProductButton.TabIndex = 34;
            this.saveProductButton.Text = "Save";
            this.saveProductButton.UseVisualStyleBackColor = false;
            this.saveProductButton.Click += new System.EventHandler(this.saveProductButton_Click);
            // 
            // cancelProductButton
            // 
            this.cancelProductButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cancelProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.cancelProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelProductButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cancelProductButton.ForeColor = System.Drawing.SystemColors.Window;
            this.cancelProductButton.Location = new System.Drawing.Point(1314, 960);
            this.cancelProductButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cancelProductButton.Name = "cancelProductButton";
            this.cancelProductButton.Size = new System.Drawing.Size(140, 63);
            this.cancelProductButton.TabIndex = 35;
            this.cancelProductButton.Text = "Cancel";
            this.cancelProductButton.UseVisualStyleBackColor = false;
            this.cancelProductButton.Click += new System.EventHandler(this.cancelProductButton_Click);
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabel.Location = new System.Drawing.Point(114, 117);
            this.addProductLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(203, 45);
            this.addProductLabel.TabIndex = 36;
            this.addProductLabel.Text = "Add Product";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 1079);
            this.Controls.Add(this.addProductLabel);
            this.Controls.Add(this.cancelProductButton);
            this.Controls.Add(this.saveProductButton);
            this.Controls.Add(this.assocPartsDataGrid);
            this.Controls.Add(this.deleteAssocPart);
            this.Controls.Add(this.assocPartSearchTextBox);
            this.Controls.Add(this.assocPartSearchButton);
            this.Controls.Add(this.productPartsDataGrid);
            this.Controls.Add(this.addAssocProductButton);
            this.Controls.Add(this.productMinTextBox);
            this.Controls.Add(this.productMaxTextBox);
            this.Controls.Add(this.productPriceCostTextBox);
            this.Controls.Add(this.productInvTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(this.productMaxLabel);
            this.Controls.Add(this.productMinLabel);
            this.Controls.Add(this.productPriceCostLabel);
            this.Controls.Add(this.productInvLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productIDLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.productPartsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assocPartsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productMinTextBox;
        private System.Windows.Forms.TextBox productMaxTextBox;
        private System.Windows.Forms.TextBox productPriceCostTextBox;
        private System.Windows.Forms.TextBox productInvTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.Label productMaxLabel;
        private System.Windows.Forms.Label productMinLabel;
        private System.Windows.Forms.Label productPriceCostLabel;
        private System.Windows.Forms.Label productInvLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.TextBox assocPartSearchTextBox;
        private System.Windows.Forms.Button assocPartSearchButton;
        public System.Windows.Forms.DataGridView productPartsDataGrid;
        private System.Windows.Forms.Button addAssocProductButton;
        public System.Windows.Forms.DataGridView assocPartsDataGrid;
        private System.Windows.Forms.Button deleteAssocPart;
        private System.Windows.Forms.Button saveProductButton;
        private System.Windows.Forms.Button cancelProductButton;
        private System.Windows.Forms.Label addProductLabel;
    }
}