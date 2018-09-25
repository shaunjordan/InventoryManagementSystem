namespace InventoryUI
{
    partial class AddPart
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
            this.partMinTextBox = new System.Windows.Forms.TextBox();
            this.partMaxTextBox = new System.Windows.Forms.TextBox();
            this.partCompanyNameMachineIDTextBox = new System.Windows.Forms.TextBox();
            this.partPriceCostTextBox = new System.Windows.Forms.TextBox();
            this.partInvTextBox = new System.Windows.Forms.TextBox();
            this.partNameTextBox = new System.Windows.Forms.TextBox();
            this.partIDTextBox = new System.Windows.Forms.TextBox();
            this.partCompanyMachineLabel = new System.Windows.Forms.Label();
            this.partMaxLabel = new System.Windows.Forms.Label();
            this.partMinLabel = new System.Windows.Forms.Label();
            this.partPriceCostLabel = new System.Windows.Forms.Label();
            this.partInvLabel = new System.Windows.Forms.Label();
            this.partNameLabel = new System.Windows.Forms.Label();
            this.partIDLabel = new System.Windows.Forms.Label();
            this.outsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.inhouseRadioButton = new System.Windows.Forms.RadioButton();
            this.cancelAddPartButton = new System.Windows.Forms.Button();
            this.savePartButton = new System.Windows.Forms.Button();
            this.partsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // partsGroupBox
            // 
            this.partsGroupBox.Controls.Add(this.partMinTextBox);
            this.partsGroupBox.Controls.Add(this.partMaxTextBox);
            this.partsGroupBox.Controls.Add(this.partCompanyNameMachineIDTextBox);
            this.partsGroupBox.Controls.Add(this.partPriceCostTextBox);
            this.partsGroupBox.Controls.Add(this.partInvTextBox);
            this.partsGroupBox.Controls.Add(this.partNameTextBox);
            this.partsGroupBox.Controls.Add(this.partIDTextBox);
            this.partsGroupBox.Controls.Add(this.partCompanyMachineLabel);
            this.partsGroupBox.Controls.Add(this.partMaxLabel);
            this.partsGroupBox.Controls.Add(this.partMinLabel);
            this.partsGroupBox.Controls.Add(this.partPriceCostLabel);
            this.partsGroupBox.Controls.Add(this.partInvLabel);
            this.partsGroupBox.Controls.Add(this.partNameLabel);
            this.partsGroupBox.Controls.Add(this.partIDLabel);
            this.partsGroupBox.Controls.Add(this.outsourcedRadioButton);
            this.partsGroupBox.Controls.Add(this.inhouseRadioButton);
            this.partsGroupBox.Controls.Add(this.cancelAddPartButton);
            this.partsGroupBox.Controls.Add(this.savePartButton);
            this.partsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.partsGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsGroupBox.Location = new System.Drawing.Point(213, 12);
            this.partsGroupBox.Name = "partsGroupBox";
            this.partsGroupBox.Size = new System.Drawing.Size(375, 426);
            this.partsGroupBox.TabIndex = 0;
            this.partsGroupBox.TabStop = false;
            this.partsGroupBox.Text = "Add Part";
            // 
            // partMinTextBox
            // 
            this.partMinTextBox.Location = new System.Drawing.Point(158, 250);
            this.partMinTextBox.Name = "partMinTextBox";
            this.partMinTextBox.Size = new System.Drawing.Size(60, 25);
            this.partMinTextBox.TabIndex = 13;
            this.partMinTextBox.Text = "Min";
            // 
            // partMaxTextBox
            // 
            this.partMaxTextBox.Location = new System.Drawing.Point(265, 250);
            this.partMaxTextBox.Name = "partMaxTextBox";
            this.partMaxTextBox.Size = new System.Drawing.Size(60, 25);
            this.partMaxTextBox.TabIndex = 15;
            this.partMaxTextBox.Text = "Max";
            // 
            // partCompanyNameMachineIDTextBox
            // 
            this.partCompanyNameMachineIDTextBox.Location = new System.Drawing.Point(158, 293);
            this.partCompanyNameMachineIDTextBox.Name = "partCompanyNameMachineIDTextBox";
            this.partCompanyNameMachineIDTextBox.Size = new System.Drawing.Size(144, 25);
            this.partCompanyNameMachineIDTextBox.TabIndex = 17;
            this.partCompanyNameMachineIDTextBox.Text = "Machine ID";
            // 
            // partPriceCostTextBox
            // 
            this.partPriceCostTextBox.Location = new System.Drawing.Point(158, 202);
            this.partPriceCostTextBox.Name = "partPriceCostTextBox";
            this.partPriceCostTextBox.Size = new System.Drawing.Size(144, 25);
            this.partPriceCostTextBox.TabIndex = 11;
            this.partPriceCostTextBox.Text = "Price/Cost";
            // 
            // partInvTextBox
            // 
            this.partInvTextBox.Location = new System.Drawing.Point(158, 161);
            this.partInvTextBox.Name = "partInvTextBox";
            this.partInvTextBox.Size = new System.Drawing.Size(144, 25);
            this.partInvTextBox.TabIndex = 9;
            this.partInvTextBox.Text = "Inv";
            // 
            // partNameTextBox
            // 
            this.partNameTextBox.Location = new System.Drawing.Point(158, 125);
            this.partNameTextBox.Name = "partNameTextBox";
            this.partNameTextBox.Size = new System.Drawing.Size(144, 25);
            this.partNameTextBox.TabIndex = 7;
            this.partNameTextBox.Text = "Part Name";
            // 
            // partIDTextBox
            // 
            this.partIDTextBox.Location = new System.Drawing.Point(158, 89);
            this.partIDTextBox.Name = "partIDTextBox";
            this.partIDTextBox.ReadOnly = true;
            this.partIDTextBox.Size = new System.Drawing.Size(116, 25);
            this.partIDTextBox.TabIndex = 5;
            this.partIDTextBox.Text = "Auto Generated";
            this.partIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // partCompanyMachineLabel
            // 
            this.partCompanyMachineLabel.AutoSize = true;
            this.partCompanyMachineLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.partCompanyMachineLabel.Location = new System.Drawing.Point(45, 296);
            this.partCompanyMachineLabel.Name = "partCompanyMachineLabel";
            this.partCompanyMachineLabel.Size = new System.Drawing.Size(76, 17);
            this.partCompanyMachineLabel.TabIndex = 16;
            this.partCompanyMachineLabel.Text = "Machine ID";
            // 
            // partMaxLabel
            // 
            this.partMaxLabel.AutoSize = true;
            this.partMaxLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.partMaxLabel.Location = new System.Drawing.Point(224, 253);
            this.partMaxLabel.Name = "partMaxLabel";
            this.partMaxLabel.Size = new System.Drawing.Size(34, 17);
            this.partMaxLabel.TabIndex = 14;
            this.partMaxLabel.Text = "Max";
            // 
            // partMinLabel
            // 
            this.partMinLabel.AutoSize = true;
            this.partMinLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.partMinLabel.Location = new System.Drawing.Point(45, 258);
            this.partMinLabel.Name = "partMinLabel";
            this.partMinLabel.Size = new System.Drawing.Size(31, 17);
            this.partMinLabel.TabIndex = 12;
            this.partMinLabel.Text = "Min";
            // 
            // partPriceCostLabel
            // 
            this.partPriceCostLabel.AutoSize = true;
            this.partPriceCostLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.partPriceCostLabel.Location = new System.Drawing.Point(45, 205);
            this.partPriceCostLabel.Name = "partPriceCostLabel";
            this.partPriceCostLabel.Size = new System.Drawing.Size(69, 17);
            this.partPriceCostLabel.TabIndex = 10;
            this.partPriceCostLabel.Text = "Price/Cost";
            // 
            // partInvLabel
            // 
            this.partInvLabel.AutoSize = true;
            this.partInvLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.partInvLabel.Location = new System.Drawing.Point(45, 164);
            this.partInvLabel.Name = "partInvLabel";
            this.partInvLabel.Size = new System.Drawing.Size(27, 17);
            this.partInvLabel.TabIndex = 8;
            this.partInvLabel.Text = "Inv";
            // 
            // partNameLabel
            // 
            this.partNameLabel.AutoSize = true;
            this.partNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.partNameLabel.Location = new System.Drawing.Point(45, 128);
            this.partNameLabel.Name = "partNameLabel";
            this.partNameLabel.Size = new System.Drawing.Size(44, 17);
            this.partNameLabel.TabIndex = 6;
            this.partNameLabel.Text = "Name";
            // 
            // partIDLabel
            // 
            this.partIDLabel.AutoSize = true;
            this.partIDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.partIDLabel.Location = new System.Drawing.Point(45, 89);
            this.partIDLabel.Name = "partIDLabel";
            this.partIDLabel.Size = new System.Drawing.Size(21, 17);
            this.partIDLabel.TabIndex = 4;
            this.partIDLabel.Text = "ID";
            // 
            // outsourcedRadioButton
            // 
            this.outsourcedRadioButton.AutoSize = true;
            this.outsourcedRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outsourcedRadioButton.Location = new System.Drawing.Point(254, 24);
            this.outsourcedRadioButton.Name = "outsourcedRadioButton";
            this.outsourcedRadioButton.Size = new System.Drawing.Size(96, 21);
            this.outsourcedRadioButton.TabIndex = 3;
            this.outsourcedRadioButton.Text = "Outsourced";
            this.outsourcedRadioButton.UseVisualStyleBackColor = true;
            this.outsourcedRadioButton.CheckedChanged += new System.EventHandler(this.outsourcedRadioButton_CheckedChanged);
            // 
            // inhouseRadioButton
            // 
            this.inhouseRadioButton.AutoSize = true;
            this.inhouseRadioButton.Checked = true;
            this.inhouseRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inhouseRadioButton.Location = new System.Drawing.Point(158, 24);
            this.inhouseRadioButton.Name = "inhouseRadioButton";
            this.inhouseRadioButton.Size = new System.Drawing.Size(81, 21);
            this.inhouseRadioButton.TabIndex = 2;
            this.inhouseRadioButton.TabStop = true;
            this.inhouseRadioButton.Text = "In-House";
            this.inhouseRadioButton.UseVisualStyleBackColor = true;
            this.inhouseRadioButton.CheckedChanged += new System.EventHandler(this.inhouseRadioButton_CheckedChanged);
            // 
            // cancelAddPartButton
            // 
            this.cancelAddPartButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cancelAddPartButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.cancelAddPartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelAddPartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cancelAddPartButton.ForeColor = System.Drawing.SystemColors.Window;
            this.cancelAddPartButton.Location = new System.Drawing.Point(280, 363);
            this.cancelAddPartButton.Name = "cancelAddPartButton";
            this.cancelAddPartButton.Size = new System.Drawing.Size(70, 33);
            this.cancelAddPartButton.TabIndex = 1;
            this.cancelAddPartButton.Text = "Cancel";
            this.cancelAddPartButton.UseVisualStyleBackColor = false;
            // 
            // savePartButton
            // 
            this.savePartButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.savePartButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.savePartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.savePartButton.ForeColor = System.Drawing.SystemColors.Window;
            this.savePartButton.Location = new System.Drawing.Point(204, 363);
            this.savePartButton.Name = "savePartButton";
            this.savePartButton.Size = new System.Drawing.Size(70, 33);
            this.savePartButton.TabIndex = 0;
            this.savePartButton.Text = "Save";
            this.savePartButton.UseVisualStyleBackColor = false;
            this.savePartButton.Click += new System.EventHandler(this.savePartButton_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.partsGroupBox);
            this.Name = "AddPart";
            this.partsGroupBox.ResumeLayout(false);
            this.partsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox partsGroupBox;
        private System.Windows.Forms.Button cancelAddPartButton;
        private System.Windows.Forms.Button savePartButton;
        private System.Windows.Forms.RadioButton outsourcedRadioButton;
        private System.Windows.Forms.RadioButton inhouseRadioButton;
        private System.Windows.Forms.Label partCompanyMachineLabel;
        private System.Windows.Forms.Label partMaxLabel;
        private System.Windows.Forms.Label partMinLabel;
        private System.Windows.Forms.Label partPriceCostLabel;
        private System.Windows.Forms.Label partInvLabel;
        private System.Windows.Forms.Label partNameLabel;
        private System.Windows.Forms.Label partIDLabel;
        private System.Windows.Forms.TextBox partIDTextBox;
        private System.Windows.Forms.TextBox partMinTextBox;
        private System.Windows.Forms.TextBox partMaxTextBox;
        private System.Windows.Forms.TextBox partCompanyNameMachineIDTextBox;
        private System.Windows.Forms.TextBox partPriceCostTextBox;
        private System.Windows.Forms.TextBox partInvTextBox;
        private System.Windows.Forms.TextBox partNameTextBox;
    }
}