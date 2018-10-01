namespace InventoryUI
{
    partial class ModifyPart
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
            this.modifyPartsGroupBox = new System.Windows.Forms.GroupBox();
            this.modifyPartMinTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartCompanyOrMachine = new System.Windows.Forms.TextBox();
            this.modifyPartPriceCostTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartInvTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartNameTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartIDTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartMachineOrCompanyLabel = new System.Windows.Forms.Label();
            this.modifyPartMaxLabel = new System.Windows.Forms.Label();
            this.modifyPartMinLabel = new System.Windows.Forms.Label();
            this.modifyPartPriceCostLabel = new System.Windows.Forms.Label();
            this.modifyPartInvLabel = new System.Windows.Forms.Label();
            this.modifyPartNameLabel = new System.Windows.Forms.Label();
            this.modifyPartIDLabel = new System.Windows.Forms.Label();
            this.modifyOutsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.modifyInhouseRadioButton = new System.Windows.Forms.RadioButton();
            this.modifyCancelAddPartButton = new System.Windows.Forms.Button();
            this.modifySavePartButton = new System.Windows.Forms.Button();
            this.modifyPartsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // modifyPartsGroupBox
            // 
            this.modifyPartsGroupBox.Controls.Add(this.modifyPartMinTextBox);
            this.modifyPartsGroupBox.Controls.Add(this.modifyPartMaxTextBox);
            this.modifyPartsGroupBox.Controls.Add(this.modifyPartCompanyOrMachine);
            this.modifyPartsGroupBox.Controls.Add(this.modifyPartPriceCostTextBox);
            this.modifyPartsGroupBox.Controls.Add(this.modifyPartInvTextBox);
            this.modifyPartsGroupBox.Controls.Add(this.modifyPartNameTextBox);
            this.modifyPartsGroupBox.Controls.Add(this.modifyPartIDTextBox);
            this.modifyPartsGroupBox.Controls.Add(this.modifyPartMachineOrCompanyLabel);
            this.modifyPartsGroupBox.Controls.Add(this.modifyPartMaxLabel);
            this.modifyPartsGroupBox.Controls.Add(this.modifyPartMinLabel);
            this.modifyPartsGroupBox.Controls.Add(this.modifyPartPriceCostLabel);
            this.modifyPartsGroupBox.Controls.Add(this.modifyPartInvLabel);
            this.modifyPartsGroupBox.Controls.Add(this.modifyPartNameLabel);
            this.modifyPartsGroupBox.Controls.Add(this.modifyPartIDLabel);
            this.modifyPartsGroupBox.Controls.Add(this.modifyOutsourcedRadioButton);
            this.modifyPartsGroupBox.Controls.Add(this.modifyInhouseRadioButton);
            this.modifyPartsGroupBox.Controls.Add(this.modifyCancelAddPartButton);
            this.modifyPartsGroupBox.Controls.Add(this.modifySavePartButton);
            this.modifyPartsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyPartsGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartsGroupBox.Location = new System.Drawing.Point(426, 23);
            this.modifyPartsGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.modifyPartsGroupBox.Name = "modifyPartsGroupBox";
            this.modifyPartsGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.modifyPartsGroupBox.Size = new System.Drawing.Size(750, 819);
            this.modifyPartsGroupBox.TabIndex = 0;
            this.modifyPartsGroupBox.TabStop = false;
            this.modifyPartsGroupBox.Text = "Modify Part";
            // 
            // modifyPartMinTextBox
            // 
            this.modifyPartMinTextBox.Location = new System.Drawing.Point(316, 481);
            this.modifyPartMinTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.modifyPartMinTextBox.Name = "modifyPartMinTextBox";
            this.modifyPartMinTextBox.Size = new System.Drawing.Size(116, 42);
            this.modifyPartMinTextBox.TabIndex = 11;
            this.modifyPartMinTextBox.Text = "Min";
            this.modifyPartMinTextBox.TextChanged += new System.EventHandler(this.modifyPartMinTextBox_TextChanged);
            // 
            // modifyPartMaxTextBox
            // 
            this.modifyPartMaxTextBox.Location = new System.Drawing.Point(530, 481);
            this.modifyPartMaxTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.modifyPartMaxTextBox.Name = "modifyPartMaxTextBox";
            this.modifyPartMaxTextBox.Size = new System.Drawing.Size(116, 42);
            this.modifyPartMaxTextBox.TabIndex = 13;
            this.modifyPartMaxTextBox.Text = "Max";
            this.modifyPartMaxTextBox.TextChanged += new System.EventHandler(this.modifyPartMaxTextBox_TextChanged);
            // 
            // modifyPartCompanyOrMachine
            // 
            this.modifyPartCompanyOrMachine.Location = new System.Drawing.Point(316, 563);
            this.modifyPartCompanyOrMachine.Margin = new System.Windows.Forms.Padding(6);
            this.modifyPartCompanyOrMachine.Name = "modifyPartCompanyOrMachine";
            this.modifyPartCompanyOrMachine.Size = new System.Drawing.Size(284, 42);
            this.modifyPartCompanyOrMachine.TabIndex = 15;
            this.modifyPartCompanyOrMachine.Text = "Company Name";
            this.modifyPartCompanyOrMachine.TextChanged += new System.EventHandler(this.modifyPartCompanyOrMachine_TextChanged);
            // 
            // modifyPartPriceCostTextBox
            // 
            this.modifyPartPriceCostTextBox.Location = new System.Drawing.Point(316, 388);
            this.modifyPartPriceCostTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.modifyPartPriceCostTextBox.Name = "modifyPartPriceCostTextBox";
            this.modifyPartPriceCostTextBox.Size = new System.Drawing.Size(284, 42);
            this.modifyPartPriceCostTextBox.TabIndex = 9;
            this.modifyPartPriceCostTextBox.Text = "Price/Cost";
            this.modifyPartPriceCostTextBox.Leave += new System.EventHandler(this.modifyPartPriceCostTextBox_Leave);
            // 
            // modifyPartInvTextBox
            // 
            this.modifyPartInvTextBox.Location = new System.Drawing.Point(316, 310);
            this.modifyPartInvTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.modifyPartInvTextBox.Name = "modifyPartInvTextBox";
            this.modifyPartInvTextBox.Size = new System.Drawing.Size(284, 42);
            this.modifyPartInvTextBox.TabIndex = 7;
            this.modifyPartInvTextBox.Text = "Inv";
            this.modifyPartInvTextBox.TextChanged += new System.EventHandler(this.modifyPartInvTextBox_TextChanged);
            // 
            // modifyPartNameTextBox
            // 
            this.modifyPartNameTextBox.Location = new System.Drawing.Point(316, 240);
            this.modifyPartNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.modifyPartNameTextBox.Name = "modifyPartNameTextBox";
            this.modifyPartNameTextBox.Size = new System.Drawing.Size(284, 42);
            this.modifyPartNameTextBox.TabIndex = 5;
            this.modifyPartNameTextBox.Text = "Part Name";
            // 
            // modifyPartIDTextBox
            // 
            this.modifyPartIDTextBox.Location = new System.Drawing.Point(316, 171);
            this.modifyPartIDTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.modifyPartIDTextBox.Name = "modifyPartIDTextBox";
            this.modifyPartIDTextBox.ReadOnly = true;
            this.modifyPartIDTextBox.Size = new System.Drawing.Size(196, 42);
            this.modifyPartIDTextBox.TabIndex = 3;
            this.modifyPartIDTextBox.Text = "Part ID";
            // 
            // modifyPartMachineOrCompanyLabel
            // 
            this.modifyPartMachineOrCompanyLabel.AutoSize = true;
            this.modifyPartMachineOrCompanyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyPartMachineOrCompanyLabel.Location = new System.Drawing.Point(90, 569);
            this.modifyPartMachineOrCompanyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyPartMachineOrCompanyLabel.Name = "modifyPartMachineOrCompanyLabel";
            this.modifyPartMachineOrCompanyLabel.Size = new System.Drawing.Size(206, 36);
            this.modifyPartMachineOrCompanyLabel.TabIndex = 14;
            this.modifyPartMachineOrCompanyLabel.Text = "Company Name";
            // 
            // modifyPartMaxLabel
            // 
            this.modifyPartMaxLabel.AutoSize = true;
            this.modifyPartMaxLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyPartMaxLabel.Location = new System.Drawing.Point(448, 487);
            this.modifyPartMaxLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyPartMaxLabel.Name = "modifyPartMaxLabel";
            this.modifyPartMaxLabel.Size = new System.Drawing.Size(66, 36);
            this.modifyPartMaxLabel.TabIndex = 12;
            this.modifyPartMaxLabel.Text = "Max";
            // 
            // modifyPartMinLabel
            // 
            this.modifyPartMinLabel.AutoSize = true;
            this.modifyPartMinLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyPartMinLabel.Location = new System.Drawing.Point(90, 496);
            this.modifyPartMinLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyPartMinLabel.Name = "modifyPartMinLabel";
            this.modifyPartMinLabel.Size = new System.Drawing.Size(61, 36);
            this.modifyPartMinLabel.TabIndex = 10;
            this.modifyPartMinLabel.Text = "Min";
            // 
            // modifyPartPriceCostLabel
            // 
            this.modifyPartPriceCostLabel.AutoSize = true;
            this.modifyPartPriceCostLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyPartPriceCostLabel.Location = new System.Drawing.Point(90, 394);
            this.modifyPartPriceCostLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyPartPriceCostLabel.Name = "modifyPartPriceCostLabel";
            this.modifyPartPriceCostLabel.Size = new System.Drawing.Size(136, 36);
            this.modifyPartPriceCostLabel.TabIndex = 8;
            this.modifyPartPriceCostLabel.Text = "Price/Cost";
            // 
            // modifyPartInvLabel
            // 
            this.modifyPartInvLabel.AutoSize = true;
            this.modifyPartInvLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyPartInvLabel.Location = new System.Drawing.Point(90, 315);
            this.modifyPartInvLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyPartInvLabel.Name = "modifyPartInvLabel";
            this.modifyPartInvLabel.Size = new System.Drawing.Size(51, 36);
            this.modifyPartInvLabel.TabIndex = 6;
            this.modifyPartInvLabel.Text = "Inv";
            // 
            // modifyPartNameLabel
            // 
            this.modifyPartNameLabel.AutoSize = true;
            this.modifyPartNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyPartNameLabel.Location = new System.Drawing.Point(90, 246);
            this.modifyPartNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyPartNameLabel.Name = "modifyPartNameLabel";
            this.modifyPartNameLabel.Size = new System.Drawing.Size(86, 36);
            this.modifyPartNameLabel.TabIndex = 4;
            this.modifyPartNameLabel.Text = "Name";
            // 
            // modifyPartIDLabel
            // 
            this.modifyPartIDLabel.AutoSize = true;
            this.modifyPartIDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyPartIDLabel.Location = new System.Drawing.Point(90, 171);
            this.modifyPartIDLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyPartIDLabel.Name = "modifyPartIDLabel";
            this.modifyPartIDLabel.Size = new System.Drawing.Size(42, 36);
            this.modifyPartIDLabel.TabIndex = 2;
            this.modifyPartIDLabel.Text = "ID";
            // 
            // modifyOutsourcedRadioButton
            // 
            this.modifyOutsourcedRadioButton.AutoSize = true;
            this.modifyOutsourcedRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyOutsourcedRadioButton.Location = new System.Drawing.Point(508, 46);
            this.modifyOutsourcedRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.modifyOutsourcedRadioButton.Name = "modifyOutsourcedRadioButton";
            this.modifyOutsourcedRadioButton.Size = new System.Drawing.Size(182, 40);
            this.modifyOutsourcedRadioButton.TabIndex = 1;
            this.modifyOutsourcedRadioButton.TabStop = true;
            this.modifyOutsourcedRadioButton.Text = "Outsourced";
            this.modifyOutsourcedRadioButton.UseVisualStyleBackColor = true;
            this.modifyOutsourcedRadioButton.CheckedChanged += new System.EventHandler(this.modifyOutsourcedRadioButton_CheckedChanged);
            // 
            // modifyInhouseRadioButton
            // 
            this.modifyInhouseRadioButton.AutoSize = true;
            this.modifyInhouseRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyInhouseRadioButton.Location = new System.Drawing.Point(316, 46);
            this.modifyInhouseRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.modifyInhouseRadioButton.Name = "modifyInhouseRadioButton";
            this.modifyInhouseRadioButton.Size = new System.Drawing.Size(152, 40);
            this.modifyInhouseRadioButton.TabIndex = 0;
            this.modifyInhouseRadioButton.TabStop = true;
            this.modifyInhouseRadioButton.Text = "In-House";
            this.modifyInhouseRadioButton.UseVisualStyleBackColor = true;
            this.modifyInhouseRadioButton.CheckedChanged += new System.EventHandler(this.modifyInhouseRadioButton_CheckedChanged);
            // 
            // modifyCancelAddPartButton
            // 
            this.modifyCancelAddPartButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.modifyCancelAddPartButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.modifyCancelAddPartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyCancelAddPartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.modifyCancelAddPartButton.ForeColor = System.Drawing.SystemColors.Window;
            this.modifyCancelAddPartButton.Location = new System.Drawing.Point(560, 698);
            this.modifyCancelAddPartButton.Margin = new System.Windows.Forms.Padding(6);
            this.modifyCancelAddPartButton.Name = "modifyCancelAddPartButton";
            this.modifyCancelAddPartButton.Size = new System.Drawing.Size(140, 63);
            this.modifyCancelAddPartButton.TabIndex = 17;
            this.modifyCancelAddPartButton.Text = "Cancel";
            this.modifyCancelAddPartButton.UseVisualStyleBackColor = false;
            this.modifyCancelAddPartButton.Click += new System.EventHandler(this.modifyCancelAddPartButton_Click);
            // 
            // modifySavePartButton
            // 
            this.modifySavePartButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.modifySavePartButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.modifySavePartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifySavePartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.modifySavePartButton.ForeColor = System.Drawing.SystemColors.Window;
            this.modifySavePartButton.Location = new System.Drawing.Point(408, 698);
            this.modifySavePartButton.Margin = new System.Windows.Forms.Padding(6);
            this.modifySavePartButton.Name = "modifySavePartButton";
            this.modifySavePartButton.Size = new System.Drawing.Size(140, 63);
            this.modifySavePartButton.TabIndex = 16;
            this.modifySavePartButton.Text = "Save";
            this.modifySavePartButton.UseVisualStyleBackColor = false;
            this.modifySavePartButton.Click += new System.EventHandler(this.modifySavePartButton_Click);
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.modifyPartsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ModifyPart";
            this.modifyPartsGroupBox.ResumeLayout(false);
            this.modifyPartsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox modifyPartsGroupBox;
        private System.Windows.Forms.TextBox modifyPartMinTextBox;
        private System.Windows.Forms.TextBox modifyPartMaxTextBox;
        private System.Windows.Forms.TextBox modifyPartCompanyOrMachine;
        private System.Windows.Forms.TextBox modifyPartPriceCostTextBox;
        private System.Windows.Forms.TextBox modifyPartInvTextBox;
        private System.Windows.Forms.TextBox modifyPartNameTextBox;
        private System.Windows.Forms.TextBox modifyPartIDTextBox;
        private System.Windows.Forms.Label modifyPartMachineOrCompanyLabel;
        private System.Windows.Forms.Label modifyPartMaxLabel;
        private System.Windows.Forms.Label modifyPartMinLabel;
        private System.Windows.Forms.Label modifyPartPriceCostLabel;
        private System.Windows.Forms.Label modifyPartInvLabel;
        private System.Windows.Forms.Label modifyPartNameLabel;
        private System.Windows.Forms.Label modifyPartIDLabel;
        private System.Windows.Forms.RadioButton modifyOutsourcedRadioButton;
        private System.Windows.Forms.RadioButton modifyInhouseRadioButton;
        private System.Windows.Forms.Button modifyCancelAddPartButton;
        private System.Windows.Forms.Button modifySavePartButton;
    }
}