namespace Allen_Miller_Inventory_Management_System
{
    partial class PartModify
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
            this.PartModifyLabel = new System.Windows.Forms.Label();
            this.PartModifyIDLabel = new System.Windows.Forms.Label();
            this.PartModifyNameLabel = new System.Windows.Forms.Label();
            this.PartModifyInventoryLabel = new System.Windows.Forms.Label();
            this.PartModifyPriceLabel = new System.Windows.Forms.Label();
            this.PartModifyMinLabel = new System.Windows.Forms.Label();
            this.PartModifyMaxLabel = new System.Windows.Forms.Label();
            this.PartModifyMachineNumberLabel = new System.Windows.Forms.Label();
            this.PartModifyInHouseRadio = new System.Windows.Forms.RadioButton();
            this.PartModifyOutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.PartModifyIDTextBox = new System.Windows.Forms.TextBox();
            this.PartModifyNameTextBox = new System.Windows.Forms.TextBox();
            this.PartModifyInventoryTextBox = new System.Windows.Forms.TextBox();
            this.PartModifyPriceTextBox = new System.Windows.Forms.TextBox();
            this.PartModifyMaxTextBox = new System.Windows.Forms.TextBox();
            this.PartModifyMinTextBox = new System.Windows.Forms.TextBox();
            this.PartModifyMachineNumberTextBox = new System.Windows.Forms.TextBox();
            this.PartModifySaveBtn = new System.Windows.Forms.Button();
            this.PartModifyCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PartModifyLabel
            // 
            this.PartModifyLabel.AutoSize = true;
            this.PartModifyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartModifyLabel.Location = new System.Drawing.Point(7, 13);
            this.PartModifyLabel.Name = "PartModifyLabel";
            this.PartModifyLabel.Size = new System.Drawing.Size(75, 16);
            this.PartModifyLabel.TabIndex = 0;
            this.PartModifyLabel.Text = "Modify Part";
            // 
            // PartModifyIDLabel
            // 
            this.PartModifyIDLabel.AutoSize = true;
            this.PartModifyIDLabel.Location = new System.Drawing.Point(69, 40);
            this.PartModifyIDLabel.Name = "PartModifyIDLabel";
            this.PartModifyIDLabel.Size = new System.Drawing.Size(18, 13);
            this.PartModifyIDLabel.TabIndex = 1;
            this.PartModifyIDLabel.Text = "ID";
            // 
            // PartModifyNameLabel
            // 
            this.PartModifyNameLabel.AutoSize = true;
            this.PartModifyNameLabel.Location = new System.Drawing.Point(52, 95);
            this.PartModifyNameLabel.Name = "PartModifyNameLabel";
            this.PartModifyNameLabel.Size = new System.Drawing.Size(35, 13);
            this.PartModifyNameLabel.TabIndex = 2;
            this.PartModifyNameLabel.Text = "Name";
            // 
            // PartModifyInventoryLabel
            // 
            this.PartModifyInventoryLabel.AutoSize = true;
            this.PartModifyInventoryLabel.Location = new System.Drawing.Point(36, 144);
            this.PartModifyInventoryLabel.Name = "PartModifyInventoryLabel";
            this.PartModifyInventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.PartModifyInventoryLabel.TabIndex = 3;
            this.PartModifyInventoryLabel.Text = "Inventory";
            // 
            // PartModifyPriceLabel
            // 
            this.PartModifyPriceLabel.AutoSize = true;
            this.PartModifyPriceLabel.Location = new System.Drawing.Point(56, 202);
            this.PartModifyPriceLabel.Name = "PartModifyPriceLabel";
            this.PartModifyPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PartModifyPriceLabel.TabIndex = 4;
            this.PartModifyPriceLabel.Text = "Price";
            // 
            // PartModifyMinLabel
            // 
            this.PartModifyMinLabel.AutoSize = true;
            this.PartModifyMinLabel.Location = new System.Drawing.Point(240, 263);
            this.PartModifyMinLabel.Name = "PartModifyMinLabel";
            this.PartModifyMinLabel.Size = new System.Drawing.Size(24, 13);
            this.PartModifyMinLabel.TabIndex = 5;
            this.PartModifyMinLabel.Text = "Min";
            // 
            // PartModifyMaxLabel
            // 
            this.PartModifyMaxLabel.AutoSize = true;
            this.PartModifyMaxLabel.Location = new System.Drawing.Point(60, 263);
            this.PartModifyMaxLabel.Name = "PartModifyMaxLabel";
            this.PartModifyMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.PartModifyMaxLabel.TabIndex = 6;
            this.PartModifyMaxLabel.Text = "Max";
            // 
            // PartModifyMachineNumberLabel
            // 
            this.PartModifyMachineNumberLabel.AutoSize = true;
            this.PartModifyMachineNumberLabel.Location = new System.Drawing.Point(5, 322);
            this.PartModifyMachineNumberLabel.Name = "PartModifyMachineNumberLabel";
            this.PartModifyMachineNumberLabel.Size = new System.Drawing.Size(88, 13);
            this.PartModifyMachineNumberLabel.TabIndex = 7;
            this.PartModifyMachineNumberLabel.Text = "Machine Number";
            this.PartModifyMachineNumberLabel.Click += new System.EventHandler(this.PartModifyMachineNumberLabel_Click);
            // 
            // PartModifyInHouseRadio
            // 
            this.PartModifyInHouseRadio.AutoSize = true;
            this.PartModifyInHouseRadio.Checked = true;
            this.PartModifyInHouseRadio.Location = new System.Drawing.Point(216, 12);
            this.PartModifyInHouseRadio.Name = "PartModifyInHouseRadio";
            this.PartModifyInHouseRadio.Size = new System.Drawing.Size(68, 17);
            this.PartModifyInHouseRadio.TabIndex = 8;
            this.PartModifyInHouseRadio.TabStop = true;
            this.PartModifyInHouseRadio.Text = "In-House";
            this.PartModifyInHouseRadio.UseVisualStyleBackColor = true;
            this.PartModifyInHouseRadio.CheckedChanged += new System.EventHandler(this.PartModifyInHouseRadio_CheckedChanged);
            // 
            // PartModifyOutsourcedRadio
            // 
            this.PartModifyOutsourcedRadio.AutoSize = true;
            this.PartModifyOutsourcedRadio.Location = new System.Drawing.Point(290, 12);
            this.PartModifyOutsourcedRadio.Name = "PartModifyOutsourcedRadio";
            this.PartModifyOutsourcedRadio.Size = new System.Drawing.Size(82, 17);
            this.PartModifyOutsourcedRadio.TabIndex = 9;
            this.PartModifyOutsourcedRadio.Text = "OutSourced";
            this.PartModifyOutsourcedRadio.UseVisualStyleBackColor = true;
            this.PartModifyOutsourcedRadio.CheckedChanged += new System.EventHandler(this.PartModifyOutsourcedRadio_CheckedChanged);
            // 
            // PartModifyIDTextBox
            // 
            this.PartModifyIDTextBox.Location = new System.Drawing.Point(99, 40);
            this.PartModifyIDTextBox.Name = "PartModifyIDTextBox";
            this.PartModifyIDTextBox.ReadOnly = true;
            this.PartModifyIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.PartModifyIDTextBox.TabIndex = 10;
            this.PartModifyIDTextBox.Text = "7";
            // 
            // PartModifyNameTextBox
            // 
            this.PartModifyNameTextBox.Location = new System.Drawing.Point(99, 95);
            this.PartModifyNameTextBox.Name = "PartModifyNameTextBox";
            this.PartModifyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.PartModifyNameTextBox.TabIndex = 11;
            this.PartModifyNameTextBox.Text = "New Part 7";
            // 
            // PartModifyInventoryTextBox
            // 
            this.PartModifyInventoryTextBox.Location = new System.Drawing.Point(99, 144);
            this.PartModifyInventoryTextBox.Name = "PartModifyInventoryTextBox";
            this.PartModifyInventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.PartModifyInventoryTextBox.TabIndex = 12;
            this.PartModifyInventoryTextBox.Text = "200";
            // 
            // PartModifyPriceTextBox
            // 
            this.PartModifyPriceTextBox.Location = new System.Drawing.Point(99, 202);
            this.PartModifyPriceTextBox.Name = "PartModifyPriceTextBox";
            this.PartModifyPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PartModifyPriceTextBox.TabIndex = 13;
            this.PartModifyPriceTextBox.Text = "50";
            // 
            // PartModifyMaxTextBox
            // 
            this.PartModifyMaxTextBox.Location = new System.Drawing.Point(99, 260);
            this.PartModifyMaxTextBox.Name = "PartModifyMaxTextBox";
            this.PartModifyMaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.PartModifyMaxTextBox.TabIndex = 14;
            this.PartModifyMaxTextBox.Text = "300";
            // 
            // PartModifyMinTextBox
            // 
            this.PartModifyMinTextBox.Location = new System.Drawing.Point(270, 256);
            this.PartModifyMinTextBox.Name = "PartModifyMinTextBox";
            this.PartModifyMinTextBox.Size = new System.Drawing.Size(100, 20);
            this.PartModifyMinTextBox.TabIndex = 15;
            this.PartModifyMinTextBox.Text = "10";
            // 
            // PartModifyMachineNumberTextBox
            // 
            this.PartModifyMachineNumberTextBox.Location = new System.Drawing.Point(99, 319);
            this.PartModifyMachineNumberTextBox.Name = "PartModifyMachineNumberTextBox";
            this.PartModifyMachineNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.PartModifyMachineNumberTextBox.TabIndex = 16;
            this.PartModifyMachineNumberTextBox.Text = "12345";
            this.PartModifyMachineNumberTextBox.TextChanged += new System.EventHandler(this.PartModifyMachineNumberTextBox_TextChanged);
            // 
            // PartModifySaveBtn
            // 
            this.PartModifySaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PartModifySaveBtn.Location = new System.Drawing.Point(103, 413);
            this.PartModifySaveBtn.Name = "PartModifySaveBtn";
            this.PartModifySaveBtn.Size = new System.Drawing.Size(75, 23);
            this.PartModifySaveBtn.TabIndex = 17;
            this.PartModifySaveBtn.Text = "Save";
            this.PartModifySaveBtn.UseVisualStyleBackColor = true;
            this.PartModifySaveBtn.Click += new System.EventHandler(this.PartModifySaveBtn_Click);
            // 
            // PartModifyCancelBtn
            // 
            this.PartModifyCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PartModifyCancelBtn.Location = new System.Drawing.Point(225, 413);
            this.PartModifyCancelBtn.Name = "PartModifyCancelBtn";
            this.PartModifyCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.PartModifyCancelBtn.TabIndex = 18;
            this.PartModifyCancelBtn.Text = "Cancel";
            this.PartModifyCancelBtn.UseVisualStyleBackColor = true;
            this.PartModifyCancelBtn.Click += new System.EventHandler(this.PartModifyCancelBtn_Click);
            // 
            // PartModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 473);
            this.Controls.Add(this.PartModifyCancelBtn);
            this.Controls.Add(this.PartModifySaveBtn);
            this.Controls.Add(this.PartModifyMachineNumberTextBox);
            this.Controls.Add(this.PartModifyMinTextBox);
            this.Controls.Add(this.PartModifyMaxTextBox);
            this.Controls.Add(this.PartModifyPriceTextBox);
            this.Controls.Add(this.PartModifyInventoryTextBox);
            this.Controls.Add(this.PartModifyNameTextBox);
            this.Controls.Add(this.PartModifyIDTextBox);
            this.Controls.Add(this.PartModifyOutsourcedRadio);
            this.Controls.Add(this.PartModifyInHouseRadio);
            this.Controls.Add(this.PartModifyMachineNumberLabel);
            this.Controls.Add(this.PartModifyMaxLabel);
            this.Controls.Add(this.PartModifyMinLabel);
            this.Controls.Add(this.PartModifyPriceLabel);
            this.Controls.Add(this.PartModifyInventoryLabel);
            this.Controls.Add(this.PartModifyNameLabel);
            this.Controls.Add(this.PartModifyIDLabel);
            this.Controls.Add(this.PartModifyLabel);
            this.Name = "PartModify";
            this.Text = "Modify Part";
            this.Load += new System.EventHandler(this.PartModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PartModifyLabel;
        private System.Windows.Forms.Label PartModifyIDLabel;
        private System.Windows.Forms.Label PartModifyNameLabel;
        private System.Windows.Forms.Label PartModifyInventoryLabel;
        private System.Windows.Forms.Label PartModifyPriceLabel;
        private System.Windows.Forms.Label PartModifyMinLabel;
        private System.Windows.Forms.Label PartModifyMaxLabel;
        private System.Windows.Forms.Label PartModifyMachineNumberLabel;
        private System.Windows.Forms.RadioButton PartModifyInHouseRadio;
        private System.Windows.Forms.RadioButton PartModifyOutsourcedRadio;

        private System.Windows.Forms.TextBox PartModifyIDTextBox;
        private System.Windows.Forms.TextBox PartModifyNameTextBox;
        private System.Windows.Forms.TextBox PartModifyInventoryTextBox;
        private System.Windows.Forms.TextBox PartModifyPriceTextBox;
        private System.Windows.Forms.TextBox PartModifyMaxTextBox;
        private System.Windows.Forms.TextBox PartModifyMinTextBox;
        private System.Windows.Forms.TextBox PartModifyMachineNumberTextBox;

        private System.Windows.Forms.Button PartModifySaveBtn;
        private System.Windows.Forms.Button PartModifyCancelBtn;

        public int PartModifyIDText
        {
            get { return int.Parse(PartModifyIDTextBox.Text); }
            set { PartModifyIDTextBox.Text = value.ToString(); }
        }

        public string PartModifyNameText
        {
            get { return PartModifyNameTextBox.Text; }
            set { PartModifyNameTextBox.Text = value; }
        }

        public int PartModifyInventoryText
        {
            get { return int.Parse(PartModifyInventoryTextBox.Text); }
            set { PartModifyInventoryTextBox.Text = value.ToString(); }
        }

        public decimal PartModifyPriceText
        {
            get { return decimal.Parse(PartModifyPriceTextBox.Text); }
            set { PartModifyPriceTextBox.Text = value.ToString(); }
        }

        public int PartModifyMaxText
        {
            get { return int.Parse(PartModifyMaxTextBox.Text); }
            set { PartModifyMaxTextBox.Text = value.ToString(); }
        }

        public int PartModifyMinText
        {
            get { return int.Parse(PartModifyMinTextBox.Text); }
            set { PartModifyMinTextBox.Text = value.ToString(); }
        }

        public string PartModifyMachineCompanyText
        {
            get { return PartModifyMachineNumberTextBox.Text; }
            set { PartModifyMachineNumberTextBox.Text = value; }
        }
    }
}