﻿namespace InventoryUI
{
    partial class ModifyProduct
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
            this.modifyProductLabel = new System.Windows.Forms.Label();
            this.modifyCancelProductButton = new System.Windows.Forms.Button();
            this.modifySaveProductButton = new System.Windows.Forms.Button();
            this.modifyAssocPartsDataGrid = new System.Windows.Forms.DataGridView();
            this.modifyDeleteAssocPart = new System.Windows.Forms.Button();
            this.modifyAssocPartSearchTextBox = new System.Windows.Forms.TextBox();
            this.modifyAssocPartSearchButton = new System.Windows.Forms.Button();
            this.modifyProductPartsDataGrid = new System.Windows.Forms.DataGridView();
            this.modifyAddAssocProductButton = new System.Windows.Forms.Button();
            this.modifyProductMinTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductPriceCostTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductInvTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductNameTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductIDTextBox = new System.Windows.Forms.TextBox();
            this.productMaxLabel = new System.Windows.Forms.Label();
            this.modifyProductMinLabel = new System.Windows.Forms.Label();
            this.modifyProductPriceCostLabel = new System.Windows.Forms.Label();
            this.modifyProductInvLabel = new System.Windows.Forms.Label();
            this.modifyProductNameLabel = new System.Windows.Forms.Label();
            this.modifyProductIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modifyAssocPartsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductPartsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyProductLabel
            // 
            this.modifyProductLabel.AutoSize = true;
            this.modifyProductLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyProductLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductLabel.Location = new System.Drawing.Point(114, 117);
            this.modifyProductLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyProductLabel.Name = "modifyProductLabel";
            this.modifyProductLabel.Size = new System.Drawing.Size(248, 45);
            this.modifyProductLabel.TabIndex = 57;
            this.modifyProductLabel.Text = "Modify Product";
            // 
            // modifyCancelProductButton
            // 
            this.modifyCancelProductButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.modifyCancelProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.modifyCancelProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyCancelProductButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.modifyCancelProductButton.ForeColor = System.Drawing.SystemColors.Window;
            this.modifyCancelProductButton.Location = new System.Drawing.Point(1314, 960);
            this.modifyCancelProductButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyCancelProductButton.Name = "modifyCancelProductButton";
            this.modifyCancelProductButton.Size = new System.Drawing.Size(140, 63);
            this.modifyCancelProductButton.TabIndex = 56;
            this.modifyCancelProductButton.Text = "Cancel";
            this.modifyCancelProductButton.UseVisualStyleBackColor = false;
            this.modifyCancelProductButton.Click += new System.EventHandler(this.modifyCancelProductButton_Click);
            // 
            // modifySaveProductButton
            // 
            this.modifySaveProductButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.modifySaveProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.modifySaveProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifySaveProductButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.modifySaveProductButton.ForeColor = System.Drawing.SystemColors.Window;
            this.modifySaveProductButton.Location = new System.Drawing.Point(1162, 960);
            this.modifySaveProductButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifySaveProductButton.Name = "modifySaveProductButton";
            this.modifySaveProductButton.Size = new System.Drawing.Size(140, 63);
            this.modifySaveProductButton.TabIndex = 55;
            this.modifySaveProductButton.Text = "Save";
            this.modifySaveProductButton.UseVisualStyleBackColor = false;
            this.modifySaveProductButton.Click += new System.EventHandler(this.modifySaveProductButton_Click);
            // 
            // modifyAssocPartsDataGrid
            // 
            this.modifyAssocPartsDataGrid.AllowUserToAddRows = false;
            this.modifyAssocPartsDataGrid.AllowUserToDeleteRows = false;
            this.modifyAssocPartsDataGrid.AllowUserToResizeColumns = false;
            this.modifyAssocPartsDataGrid.AllowUserToResizeRows = false;
            this.modifyAssocPartsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modifyAssocPartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyAssocPartsDataGrid.Location = new System.Drawing.Point(730, 521);
            this.modifyAssocPartsDataGrid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyAssocPartsDataGrid.Name = "modifyAssocPartsDataGrid";
            this.modifyAssocPartsDataGrid.ReadOnly = true;
            this.modifyAssocPartsDataGrid.RowHeadersVisible = false;
            this.modifyAssocPartsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modifyAssocPartsDataGrid.Size = new System.Drawing.Size(724, 281);
            this.modifyAssocPartsDataGrid.TabIndex = 53;
            // 
            // modifyDeleteAssocPart
            // 
            this.modifyDeleteAssocPart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.modifyDeleteAssocPart.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.modifyDeleteAssocPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyDeleteAssocPart.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.modifyDeleteAssocPart.ForeColor = System.Drawing.SystemColors.Window;
            this.modifyDeleteAssocPart.Location = new System.Drawing.Point(1314, 813);
            this.modifyDeleteAssocPart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyDeleteAssocPart.Name = "modifyDeleteAssocPart";
            this.modifyDeleteAssocPart.Size = new System.Drawing.Size(140, 63);
            this.modifyDeleteAssocPart.TabIndex = 54;
            this.modifyDeleteAssocPart.Text = "Delete";
            this.modifyDeleteAssocPart.UseVisualStyleBackColor = false;
            this.modifyDeleteAssocPart.Click += new System.EventHandler(this.modifyDeleteAssocPart_Click);
            // 
            // modifyAssocPartSearchTextBox
            // 
            this.modifyAssocPartSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modifyAssocPartSearchTextBox.Location = new System.Drawing.Point(1162, 54);
            this.modifyAssocPartSearchTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyAssocPartSearchTextBox.Name = "modifyAssocPartSearchTextBox";
            this.modifyAssocPartSearchTextBox.Size = new System.Drawing.Size(290, 31);
            this.modifyAssocPartSearchTextBox.TabIndex = 52;
            // 
            // modifyAssocPartSearchButton
            // 
            this.modifyAssocPartSearchButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.modifyAssocPartSearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.modifyAssocPartSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyAssocPartSearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.modifyAssocPartSearchButton.ForeColor = System.Drawing.SystemColors.Window;
            this.modifyAssocPartSearchButton.Location = new System.Drawing.Point(1034, 54);
            this.modifyAssocPartSearchButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyAssocPartSearchButton.Name = "modifyAssocPartSearchButton";
            this.modifyAssocPartSearchButton.Size = new System.Drawing.Size(116, 48);
            this.modifyAssocPartSearchButton.TabIndex = 50;
            this.modifyAssocPartSearchButton.Text = "Search";
            this.modifyAssocPartSearchButton.UseVisualStyleBackColor = false;
            this.modifyAssocPartSearchButton.Click += new System.EventHandler(this.modifyAssocPartSearchButton_Click);
            // 
            // modifyProductPartsDataGrid
            // 
            this.modifyProductPartsDataGrid.AllowUserToAddRows = false;
            this.modifyProductPartsDataGrid.AllowUserToDeleteRows = false;
            this.modifyProductPartsDataGrid.AllowUserToResizeColumns = false;
            this.modifyProductPartsDataGrid.AllowUserToResizeRows = false;
            this.modifyProductPartsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modifyProductPartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyProductPartsDataGrid.Location = new System.Drawing.Point(730, 117);
            this.modifyProductPartsDataGrid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductPartsDataGrid.Name = "modifyProductPartsDataGrid";
            this.modifyProductPartsDataGrid.ReadOnly = true;
            this.modifyProductPartsDataGrid.RowHeadersVisible = false;
            this.modifyProductPartsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modifyProductPartsDataGrid.Size = new System.Drawing.Size(724, 281);
            this.modifyProductPartsDataGrid.TabIndex = 49;
            // 
            // modifyAddAssocProductButton
            // 
            this.modifyAddAssocProductButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.modifyAddAssocProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.modifyAddAssocProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyAddAssocProductButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.modifyAddAssocProductButton.ForeColor = System.Drawing.SystemColors.Window;
            this.modifyAddAssocProductButton.Location = new System.Drawing.Point(1314, 410);
            this.modifyAddAssocProductButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyAddAssocProductButton.Name = "modifyAddAssocProductButton";
            this.modifyAddAssocProductButton.Size = new System.Drawing.Size(140, 63);
            this.modifyAddAssocProductButton.TabIndex = 51;
            this.modifyAddAssocProductButton.Text = "Add";
            this.modifyAddAssocProductButton.UseVisualStyleBackColor = false;
            this.modifyAddAssocProductButton.Click += new System.EventHandler(this.modifyAddAssocProductButton_Click);
            // 
            // modifyProductMinTextBox
            // 
            this.modifyProductMinTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.modifyProductMinTextBox.Location = new System.Drawing.Point(216, 613);
            this.modifyProductMinTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductMinTextBox.Name = "modifyProductMinTextBox";
            this.modifyProductMinTextBox.Size = new System.Drawing.Size(116, 42);
            this.modifyProductMinTextBox.TabIndex = 46;
            this.modifyProductMinTextBox.Text = "Min";
            this.modifyProductMinTextBox.TextChanged += new System.EventHandler(this.modifyProductMinTextBox_TextChanged);
            // 
            // modifyProductMaxTextBox
            // 
            this.modifyProductMaxTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.modifyProductMaxTextBox.Location = new System.Drawing.Point(430, 613);
            this.modifyProductMaxTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductMaxTextBox.Name = "modifyProductMaxTextBox";
            this.modifyProductMaxTextBox.Size = new System.Drawing.Size(116, 42);
            this.modifyProductMaxTextBox.TabIndex = 48;
            this.modifyProductMaxTextBox.Text = "Max";
            this.modifyProductMaxTextBox.TextChanged += new System.EventHandler(this.modifyProductMaxTextBox_TextChanged);
            // 
            // modifyProductPriceCostTextBox
            // 
            this.modifyProductPriceCostTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.modifyProductPriceCostTextBox.Location = new System.Drawing.Point(216, 521);
            this.modifyProductPriceCostTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductPriceCostTextBox.Name = "modifyProductPriceCostTextBox";
            this.modifyProductPriceCostTextBox.Size = new System.Drawing.Size(284, 42);
            this.modifyProductPriceCostTextBox.TabIndex = 44;
            this.modifyProductPriceCostTextBox.Text = "Price";
            this.modifyProductPriceCostTextBox.Leave += new System.EventHandler(this.modifyProductPriceCostTextBox_Leave);
            // 
            // modifyProductInvTextBox
            // 
            this.modifyProductInvTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.modifyProductInvTextBox.Location = new System.Drawing.Point(216, 442);
            this.modifyProductInvTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductInvTextBox.Name = "modifyProductInvTextBox";
            this.modifyProductInvTextBox.Size = new System.Drawing.Size(284, 42);
            this.modifyProductInvTextBox.TabIndex = 42;
            this.modifyProductInvTextBox.Text = "Inv";
            this.modifyProductInvTextBox.TextChanged += new System.EventHandler(this.modifyProductInvTextBox_TextChanged);
            // 
            // modifyProductNameTextBox
            // 
            this.modifyProductNameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.modifyProductNameTextBox.Location = new System.Drawing.Point(216, 373);
            this.modifyProductNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductNameTextBox.Name = "modifyProductNameTextBox";
            this.modifyProductNameTextBox.Size = new System.Drawing.Size(284, 42);
            this.modifyProductNameTextBox.TabIndex = 40;
            this.modifyProductNameTextBox.Text = "Product Name";
            // 
            // modifyProductIDTextBox
            // 
            this.modifyProductIDTextBox.Enabled = false;
            this.modifyProductIDTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.modifyProductIDTextBox.Location = new System.Drawing.Point(216, 304);
            this.modifyProductIDTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductIDTextBox.Name = "modifyProductIDTextBox";
            this.modifyProductIDTextBox.ReadOnly = true;
            this.modifyProductIDTextBox.Size = new System.Drawing.Size(228, 42);
            this.modifyProductIDTextBox.TabIndex = 38;
            this.modifyProductIDTextBox.Text = "Auto Generated";
            this.modifyProductIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.productMaxLabel.TabIndex = 47;
            this.productMaxLabel.Text = "Max";
            // 
            // modifyProductMinLabel
            // 
            this.modifyProductMinLabel.AutoSize = true;
            this.modifyProductMinLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyProductMinLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.modifyProductMinLabel.Location = new System.Drawing.Point(116, 619);
            this.modifyProductMinLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyProductMinLabel.Name = "modifyProductMinLabel";
            this.modifyProductMinLabel.Size = new System.Drawing.Size(61, 36);
            this.modifyProductMinLabel.TabIndex = 45;
            this.modifyProductMinLabel.Text = "Min";
            // 
            // modifyProductPriceCostLabel
            // 
            this.modifyProductPriceCostLabel.AutoSize = true;
            this.modifyProductPriceCostLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyProductPriceCostLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.modifyProductPriceCostLabel.Location = new System.Drawing.Point(116, 527);
            this.modifyProductPriceCostLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyProductPriceCostLabel.Name = "modifyProductPriceCostLabel";
            this.modifyProductPriceCostLabel.Size = new System.Drawing.Size(73, 36);
            this.modifyProductPriceCostLabel.TabIndex = 43;
            this.modifyProductPriceCostLabel.Text = "Price";
            // 
            // modifyProductInvLabel
            // 
            this.modifyProductInvLabel.AutoSize = true;
            this.modifyProductInvLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyProductInvLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.modifyProductInvLabel.Location = new System.Drawing.Point(116, 448);
            this.modifyProductInvLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyProductInvLabel.Name = "modifyProductInvLabel";
            this.modifyProductInvLabel.Size = new System.Drawing.Size(51, 36);
            this.modifyProductInvLabel.TabIndex = 41;
            this.modifyProductInvLabel.Text = "Inv";
            // 
            // modifyProductNameLabel
            // 
            this.modifyProductNameLabel.AutoSize = true;
            this.modifyProductNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyProductNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.modifyProductNameLabel.Location = new System.Drawing.Point(116, 379);
            this.modifyProductNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyProductNameLabel.Name = "modifyProductNameLabel";
            this.modifyProductNameLabel.Size = new System.Drawing.Size(86, 36);
            this.modifyProductNameLabel.TabIndex = 39;
            this.modifyProductNameLabel.Text = "Name";
            // 
            // modifyProductIDLabel
            // 
            this.modifyProductIDLabel.AutoSize = true;
            this.modifyProductIDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyProductIDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.modifyProductIDLabel.Location = new System.Drawing.Point(116, 304);
            this.modifyProductIDLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyProductIDLabel.Name = "modifyProductIDLabel";
            this.modifyProductIDLabel.Size = new System.Drawing.Size(42, 36);
            this.modifyProductIDLabel.TabIndex = 37;
            this.modifyProductIDLabel.Text = "ID";
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 1079);
            this.Controls.Add(this.modifyProductLabel);
            this.Controls.Add(this.modifyCancelProductButton);
            this.Controls.Add(this.modifySaveProductButton);
            this.Controls.Add(this.modifyAssocPartsDataGrid);
            this.Controls.Add(this.modifyDeleteAssocPart);
            this.Controls.Add(this.modifyAssocPartSearchTextBox);
            this.Controls.Add(this.modifyAssocPartSearchButton);
            this.Controls.Add(this.modifyProductPartsDataGrid);
            this.Controls.Add(this.modifyAddAssocProductButton);
            this.Controls.Add(this.modifyProductMinTextBox);
            this.Controls.Add(this.modifyProductMaxTextBox);
            this.Controls.Add(this.modifyProductPriceCostTextBox);
            this.Controls.Add(this.modifyProductInvTextBox);
            this.Controls.Add(this.modifyProductNameTextBox);
            this.Controls.Add(this.modifyProductIDTextBox);
            this.Controls.Add(this.productMaxLabel);
            this.Controls.Add(this.modifyProductMinLabel);
            this.Controls.Add(this.modifyProductPriceCostLabel);
            this.Controls.Add(this.modifyProductInvLabel);
            this.Controls.Add(this.modifyProductNameLabel);
            this.Controls.Add(this.modifyProductIDLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModifyProduct";
            this.Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)(this.modifyAssocPartsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductPartsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modifyProductLabel;
        private System.Windows.Forms.Button modifyCancelProductButton;
        private System.Windows.Forms.Button modifySaveProductButton;
        public System.Windows.Forms.DataGridView modifyAssocPartsDataGrid;
        private System.Windows.Forms.Button modifyDeleteAssocPart;
        private System.Windows.Forms.TextBox modifyAssocPartSearchTextBox;
        private System.Windows.Forms.Button modifyAssocPartSearchButton;
        public System.Windows.Forms.DataGridView modifyProductPartsDataGrid;
        private System.Windows.Forms.Button modifyAddAssocProductButton;
        private System.Windows.Forms.TextBox modifyProductMinTextBox;
        private System.Windows.Forms.TextBox modifyProductMaxTextBox;
        private System.Windows.Forms.TextBox modifyProductPriceCostTextBox;
        private System.Windows.Forms.TextBox modifyProductInvTextBox;
        private System.Windows.Forms.TextBox modifyProductNameTextBox;
        private System.Windows.Forms.TextBox modifyProductIDTextBox;
        private System.Windows.Forms.Label productMaxLabel;
        private System.Windows.Forms.Label modifyProductMinLabel;
        private System.Windows.Forms.Label modifyProductPriceCostLabel;
        private System.Windows.Forms.Label modifyProductInvLabel;
        private System.Windows.Forms.Label modifyProductNameLabel;
        private System.Windows.Forms.Label modifyProductIDLabel;
    }
}