namespace InventoryUI
{
    partial class MainForm
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
            this.partsGroupBox = new System.Windows.Forms.GroupBox();
            this.partSearchTextBox = new System.Windows.Forms.TextBox();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.modifyPartButton = new System.Windows.Forms.Button();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.addPartsButton = new System.Windows.Forms.Button();
            this.partsDataGrid = new System.Windows.Forms.DataGridView();
            this.productsGroupBox = new System.Windows.Forms.GroupBox();
            this.productSearchTextBox = new System.Windows.Forms.TextBox();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.productSearchButton = new System.Windows.Forms.Button();
            this.productsDataGrid = new System.Windows.Forms.DataGridView();
            this.addProductButton = new System.Windows.Forms.Button();
            this.mainFormLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.partsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGrid)).BeginInit();
            this.productsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // partsGroupBox
            // 
            this.partsGroupBox.Controls.Add(this.partSearchTextBox);
            this.partsGroupBox.Controls.Add(this.deletePartButton);
            this.partsGroupBox.Controls.Add(this.modifyPartButton);
            this.partsGroupBox.Controls.Add(this.partsSearchButton);
            this.partsGroupBox.Controls.Add(this.addPartsButton);
            this.partsGroupBox.Controls.Add(this.partsDataGrid);
            this.partsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.partsGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsGroupBox.Location = new System.Drawing.Point(24, 181);
            this.partsGroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.partsGroupBox.Name = "partsGroupBox";
            this.partsGroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.partsGroupBox.Size = new System.Drawing.Size(750, 500);
            this.partsGroupBox.TabIndex = 0;
            this.partsGroupBox.TabStop = false;
            this.partsGroupBox.Text = "Parts";
            // 
            // partSearchTextBox
            // 
            this.partSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partSearchTextBox.Location = new System.Drawing.Point(446, 40);
            this.partSearchTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.partSearchTextBox.Name = "partSearchTextBox";
            this.partSearchTextBox.Size = new System.Drawing.Size(290, 42);
            this.partSearchTextBox.TabIndex = 3;
            // 
            // deletePartButton
            // 
            this.deletePartButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.deletePartButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.deletePartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.deletePartButton.ForeColor = System.Drawing.SystemColors.Window;
            this.deletePartButton.Location = new System.Drawing.Point(598, 392);
            this.deletePartButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(140, 63);
            this.deletePartButton.TabIndex = 1;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = false;
            // 
            // modifyPartButton
            // 
            this.modifyPartButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.modifyPartButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.modifyPartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyPartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.modifyPartButton.ForeColor = System.Drawing.SystemColors.Window;
            this.modifyPartButton.Location = new System.Drawing.Point(446, 392);
            this.modifyPartButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyPartButton.Name = "modifyPartButton";
            this.modifyPartButton.Size = new System.Drawing.Size(140, 63);
            this.modifyPartButton.TabIndex = 1;
            this.modifyPartButton.Text = "Modify";
            this.modifyPartButton.UseVisualStyleBackColor = false;
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.partsSearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.partsSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.partsSearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.partsSearchButton.ForeColor = System.Drawing.SystemColors.Window;
            this.partsSearchButton.Location = new System.Drawing.Point(318, 40);
            this.partsSearchButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(116, 48);
            this.partsSearchButton.TabIndex = 1;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = false;
            // 
            // addPartsButton
            // 
            this.addPartsButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addPartsButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.addPartsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPartsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.addPartsButton.ForeColor = System.Drawing.SystemColors.Window;
            this.addPartsButton.Location = new System.Drawing.Point(294, 392);
            this.addPartsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addPartsButton.Name = "addPartsButton";
            this.addPartsButton.Size = new System.Drawing.Size(140, 63);
            this.addPartsButton.TabIndex = 1;
            this.addPartsButton.Text = "Add";
            this.addPartsButton.UseVisualStyleBackColor = false;
            this.addPartsButton.Click += new System.EventHandler(this.addPartsButton_Click);
            // 
            // partsDataGrid
            // 
            this.partsDataGrid.AllowUserToAddRows = false;
            this.partsDataGrid.AllowUserToDeleteRows = false;
            this.partsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGrid.Location = new System.Drawing.Point(14, 100);
            this.partsDataGrid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.partsDataGrid.Name = "partsDataGrid";
            this.partsDataGrid.ReadOnly = true;
            this.partsDataGrid.Size = new System.Drawing.Size(724, 281);
            this.partsDataGrid.TabIndex = 0;
            // 
            // productsGroupBox
            // 
            this.productsGroupBox.Controls.Add(this.productSearchTextBox);
            this.productsGroupBox.Controls.Add(this.deleteProductButton);
            this.productsGroupBox.Controls.Add(this.modifyProductButton);
            this.productsGroupBox.Controls.Add(this.productSearchButton);
            this.productsGroupBox.Controls.Add(this.productsDataGrid);
            this.productsGroupBox.Controls.Add(this.addProductButton);
            this.productsGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsGroupBox.Location = new System.Drawing.Point(826, 181);
            this.productsGroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productsGroupBox.Name = "productsGroupBox";
            this.productsGroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productsGroupBox.Size = new System.Drawing.Size(750, 500);
            this.productsGroupBox.TabIndex = 0;
            this.productsGroupBox.TabStop = false;
            this.productsGroupBox.Text = "Products";
            // 
            // productSearchTextBox
            // 
            this.productSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productSearchTextBox.Location = new System.Drawing.Point(446, 37);
            this.productSearchTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productSearchTextBox.Name = "productSearchTextBox";
            this.productSearchTextBox.Size = new System.Drawing.Size(290, 42);
            this.productSearchTextBox.TabIndex = 3;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.deleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProductButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.deleteProductButton.ForeColor = System.Drawing.SystemColors.Window;
            this.deleteProductButton.Location = new System.Drawing.Point(598, 392);
            this.deleteProductButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(140, 63);
            this.deleteProductButton.TabIndex = 1;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = false;
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.modifyProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.modifyProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyProductButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.modifyProductButton.ForeColor = System.Drawing.SystemColors.Window;
            this.modifyProductButton.Location = new System.Drawing.Point(446, 392);
            this.modifyProductButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(140, 63);
            this.modifyProductButton.TabIndex = 1;
            this.modifyProductButton.Text = "Modify";
            this.modifyProductButton.UseVisualStyleBackColor = false;
            // 
            // productSearchButton
            // 
            this.productSearchButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.productSearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.productSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productSearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.productSearchButton.ForeColor = System.Drawing.SystemColors.Window;
            this.productSearchButton.Location = new System.Drawing.Point(318, 37);
            this.productSearchButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productSearchButton.Name = "productSearchButton";
            this.productSearchButton.Size = new System.Drawing.Size(116, 48);
            this.productSearchButton.TabIndex = 1;
            this.productSearchButton.Text = "Search";
            this.productSearchButton.UseVisualStyleBackColor = false;
            // 
            // productsDataGrid
            // 
            this.productsDataGrid.AllowUserToAddRows = false;
            this.productsDataGrid.AllowUserToDeleteRows = false;
            this.productsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGrid.Location = new System.Drawing.Point(14, 100);
            this.productsDataGrid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productsDataGrid.Name = "productsDataGrid";
            this.productsDataGrid.ReadOnly = true;
            this.productsDataGrid.Size = new System.Drawing.Size(724, 281);
            this.productsDataGrid.TabIndex = 0;
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.addProductButton.ForeColor = System.Drawing.SystemColors.Window;
            this.addProductButton.Location = new System.Drawing.Point(294, 392);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(140, 63);
            this.addProductButton.TabIndex = 1;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = false;
            // 
            // mainFormLabel
            // 
            this.mainFormLabel.AutoSize = true;
            this.mainFormLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainFormLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormLabel.Location = new System.Drawing.Point(38, 48);
            this.mainFormLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mainFormLabel.Name = "mainFormLabel";
            this.mainFormLabel.Size = new System.Drawing.Size(476, 45);
            this.mainFormLabel.TabIndex = 1;
            this.mainFormLabel.Text = "Inventory Management System";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.SystemColors.Window;
            this.exitButton.Location = new System.Drawing.Point(1356, 737);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 63);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.mainFormLabel);
            this.Controls.Add(this.productsGroupBox);
            this.Controls.Add(this.partsGroupBox);
            this.Controls.Add(this.exitButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.partsGroupBox.ResumeLayout(false);
            this.partsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGrid)).EndInit();
            this.productsGroupBox.ResumeLayout(false);
            this.productsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox partsGroupBox;
        private System.Windows.Forms.GroupBox productsGroupBox;
        private System.Windows.Forms.DataGridView partsDataGrid;
        private System.Windows.Forms.DataGridView productsDataGrid;
        private System.Windows.Forms.Button addPartsButton;
        private System.Windows.Forms.Label mainFormLabel;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Button modifyPartButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox partSearchTextBox;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.TextBox productSearchTextBox;
        private System.Windows.Forms.Button productSearchButton;
    }
}

