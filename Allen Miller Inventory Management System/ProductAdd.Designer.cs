namespace Allen_Miller_Inventory_Management_System
{
    partial class ProductAdd
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
            this.ProductAddCancelBtn = new System.Windows.Forms.Button();
            this.ProductAddSaveBtn = new System.Windows.Forms.Button();
            this.ProductAddLbl = new System.Windows.Forms.Label();
            this.ProductAddIDLbl = new System.Windows.Forms.Label();
            this.productAddMinLbl = new System.Windows.Forms.Label();
            this.ProductAddMaxLbl = new System.Windows.Forms.Label();
            this.ProductAddPriceLbl = new System.Windows.Forms.Label();
            this.ProductAddInventoryLbl = new System.Windows.Forms.Label();
            this.ProductAddNameLbl = new System.Windows.Forms.Label();
            this.ProductAddIDBox = new System.Windows.Forms.TextBox();
            this.ProductAddNameBox = new System.Windows.Forms.TextBox();
            this.ProductAddInventoryBox = new System.Windows.Forms.TextBox();
            this.ProductAddPriceBox = new System.Windows.Forms.TextBox();
            this.ProductAddMaxBox = new System.Windows.Forms.TextBox();
            this.ProductAddMinBox = new System.Windows.Forms.TextBox();
            this.AllPartsDGV = new System.Windows.Forms.DataGridView();
            this.AssiociatedPartsDGV = new System.Windows.Forms.DataGridView();
            this.AssociatedPartsLbl = new System.Windows.Forms.Label();
            this.AllPartsLbl = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AddAssociatedPartBtn = new System.Windows.Forms.Button();
            this.DeleteAssociatePartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssiociatedPartsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductAddCancelBtn
            // 
            this.ProductAddCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductAddCancelBtn.Location = new System.Drawing.Point(110, 514);
            this.ProductAddCancelBtn.Name = "ProductAddCancelBtn";
            this.ProductAddCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.ProductAddCancelBtn.TabIndex = 0;
            this.ProductAddCancelBtn.Text = "Cancel";
            this.ProductAddCancelBtn.UseVisualStyleBackColor = true;
            this.ProductAddCancelBtn.Click += new System.EventHandler(this.ProductAddCancelBtn_Click);
            // 
            // ProductAddSaveBtn
            // 
            this.ProductAddSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductAddSaveBtn.Location = new System.Drawing.Point(29, 514);
            this.ProductAddSaveBtn.Name = "ProductAddSaveBtn";
            this.ProductAddSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.ProductAddSaveBtn.TabIndex = 1;
            this.ProductAddSaveBtn.Text = "Save";
            this.ProductAddSaveBtn.UseVisualStyleBackColor = true;
            this.ProductAddSaveBtn.Click += new System.EventHandler(this.ProductAddSaveBtn_Click);
            // 
            // ProductAddLbl
            // 
            this.ProductAddLbl.AutoSize = true;
            this.ProductAddLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductAddLbl.Location = new System.Drawing.Point(7, 13);
            this.ProductAddLbl.Name = "ProductAddLbl";
            this.ProductAddLbl.Size = new System.Drawing.Size(82, 16);
            this.ProductAddLbl.TabIndex = 2;
            this.ProductAddLbl.Text = "Add Product";
            // 
            // ProductAddIDLbl
            // 
            this.ProductAddIDLbl.AutoSize = true;
            this.ProductAddIDLbl.Location = new System.Drawing.Point(45, 88);
            this.ProductAddIDLbl.Name = "ProductAddIDLbl";
            this.ProductAddIDLbl.Size = new System.Drawing.Size(18, 13);
            this.ProductAddIDLbl.TabIndex = 3;
            this.ProductAddIDLbl.Text = "ID";
            // 
            // productAddMinLbl
            // 
            this.productAddMinLbl.AutoSize = true;
            this.productAddMinLbl.Location = new System.Drawing.Point(213, 413);
            this.productAddMinLbl.Name = "productAddMinLbl";
            this.productAddMinLbl.Size = new System.Drawing.Size(24, 13);
            this.productAddMinLbl.TabIndex = 4;
            this.productAddMinLbl.Text = "Min";
            // 
            // ProductAddMaxLbl
            // 
            this.ProductAddMaxLbl.AutoSize = true;
            this.ProductAddMaxLbl.Location = new System.Drawing.Point(36, 413);
            this.ProductAddMaxLbl.Name = "ProductAddMaxLbl";
            this.ProductAddMaxLbl.Size = new System.Drawing.Size(27, 13);
            this.ProductAddMaxLbl.TabIndex = 6;
            this.ProductAddMaxLbl.Text = "Max";
            // 
            // ProductAddPriceLbl
            // 
            this.ProductAddPriceLbl.AutoSize = true;
            this.ProductAddPriceLbl.Location = new System.Drawing.Point(32, 240);
            this.ProductAddPriceLbl.Name = "ProductAddPriceLbl";
            this.ProductAddPriceLbl.Size = new System.Drawing.Size(31, 13);
            this.ProductAddPriceLbl.TabIndex = 7;
            this.ProductAddPriceLbl.Text = "Price";
            // 
            // ProductAddInventoryLbl
            // 
            this.ProductAddInventoryLbl.AutoSize = true;
            this.ProductAddInventoryLbl.Location = new System.Drawing.Point(12, 328);
            this.ProductAddInventoryLbl.Name = "ProductAddInventoryLbl";
            this.ProductAddInventoryLbl.Size = new System.Drawing.Size(51, 13);
            this.ProductAddInventoryLbl.TabIndex = 8;
            this.ProductAddInventoryLbl.Text = "Inventory";
            this.ProductAddInventoryLbl.Click += new System.EventHandler(this.Label5_Click);
            // 
            // ProductAddNameLbl
            // 
            this.ProductAddNameLbl.AutoSize = true;
            this.ProductAddNameLbl.Location = new System.Drawing.Point(32, 160);
            this.ProductAddNameLbl.Name = "ProductAddNameLbl";
            this.ProductAddNameLbl.Size = new System.Drawing.Size(35, 13);
            this.ProductAddNameLbl.TabIndex = 9;
            this.ProductAddNameLbl.Text = "Name";
            // 
            // ProductAddIDBox
            // 
            this.ProductAddIDBox.Location = new System.Drawing.Point(72, 88);
            this.ProductAddIDBox.Name = "ProductAddIDBox";
            this.ProductAddIDBox.ReadOnly = true;
            this.ProductAddIDBox.Size = new System.Drawing.Size(100, 20);
            this.ProductAddIDBox.TabIndex = 10;
            // 
            // ProductAddNameBox
            // 
            this.ProductAddNameBox.Location = new System.Drawing.Point(72, 160);
            this.ProductAddNameBox.Name = "ProductAddNameBox";
            this.ProductAddNameBox.Size = new System.Drawing.Size(100, 20);
            this.ProductAddNameBox.TabIndex = 11;
            this.ProductAddNameBox.Text = "New Product 7";
            // 
            // ProductAddInventoryBox
            // 
            this.ProductAddInventoryBox.Location = new System.Drawing.Point(72, 328);
            this.ProductAddInventoryBox.Name = "ProductAddInventoryBox";
            this.ProductAddInventoryBox.Size = new System.Drawing.Size(100, 20);
            this.ProductAddInventoryBox.TabIndex = 12;
            this.ProductAddInventoryBox.Text = "500";
            // 
            // ProductAddPriceBox
            // 
            this.ProductAddPriceBox.Location = new System.Drawing.Point(72, 241);
            this.ProductAddPriceBox.Name = "ProductAddPriceBox";
            this.ProductAddPriceBox.Size = new System.Drawing.Size(100, 20);
            this.ProductAddPriceBox.TabIndex = 13;
            this.ProductAddPriceBox.Text = "200.00";
            // 
            // ProductAddMaxBox
            // 
            this.ProductAddMaxBox.Location = new System.Drawing.Point(72, 413);
            this.ProductAddMaxBox.Name = "ProductAddMaxBox";
            this.ProductAddMaxBox.Size = new System.Drawing.Size(100, 20);
            this.ProductAddMaxBox.TabIndex = 14;
            this.ProductAddMaxBox.Text = "600";
            // 
            // ProductAddMinBox
            // 
            this.ProductAddMinBox.Location = new System.Drawing.Point(243, 413);
            this.ProductAddMinBox.Name = "ProductAddMinBox";
            this.ProductAddMinBox.Size = new System.Drawing.Size(100, 20);
            this.ProductAddMinBox.TabIndex = 16;
            this.ProductAddMinBox.Text = "10";
            // 
            // AllPartsDGV
            // 
            this.AllPartsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllPartsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AllPartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPartsDGV.Location = new System.Drawing.Point(447, 40);
            this.AllPartsDGV.Name = "AllPartsDGV";
            this.AllPartsDGV.ReadOnly = true;
            this.AllPartsDGV.Size = new System.Drawing.Size(503, 209);
            this.AllPartsDGV.TabIndex = 17;
            // 
            // AssiociatedPartsDGV
            // 
            this.AssiociatedPartsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AssiociatedPartsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AssiociatedPartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssiociatedPartsDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AssiociatedPartsDGV.GridColor = System.Drawing.Color.Azure;
            this.AssiociatedPartsDGV.Location = new System.Drawing.Point(447, 299);
            this.AssiociatedPartsDGV.Name = "AssiociatedPartsDGV";
            this.AssiociatedPartsDGV.ReadOnly = true;
            this.AssiociatedPartsDGV.Size = new System.Drawing.Size(503, 209);
            this.AssiociatedPartsDGV.TabIndex = 18;
            // 
            // AssociatedPartsLbl
            // 
            this.AssociatedPartsLbl.AutoSize = true;
            this.AssociatedPartsLbl.Location = new System.Drawing.Point(444, 283);
            this.AssociatedPartsLbl.Name = "AssociatedPartsLbl";
            this.AssociatedPartsLbl.Size = new System.Drawing.Size(174, 13);
            this.AssociatedPartsLbl.TabIndex = 19;
            this.AssociatedPartsLbl.Text = "Parts Associated With This Product";
            // 
            // AllPartsLbl
            // 
            this.AllPartsLbl.AutoSize = true;
            this.AllPartsLbl.Location = new System.Drawing.Point(444, 22);
            this.AllPartsLbl.Name = "AllPartsLbl";
            this.AllPartsLbl.Size = new System.Drawing.Size(45, 13);
            this.AllPartsLbl.TabIndex = 20;
            this.AllPartsLbl.Text = "All Parts";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(771, 14);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(179, 20);
            this.SearchTextBox.TabIndex = 21;
            this.SearchTextBox.Text = "Search by part ID";
            this.SearchTextBox.Click += new System.EventHandler(this.SearchTextBox_Enter);
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(690, 12);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 22;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AddAssociatedPartBtn
            // 
            this.AddAssociatedPartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAssociatedPartBtn.Location = new System.Drawing.Point(875, 255);
            this.AddAssociatedPartBtn.Name = "AddAssociatedPartBtn";
            this.AddAssociatedPartBtn.Size = new System.Drawing.Size(75, 23);
            this.AddAssociatedPartBtn.TabIndex = 23;
            this.AddAssociatedPartBtn.Text = "Add";
            this.AddAssociatedPartBtn.UseVisualStyleBackColor = true;
            this.AddAssociatedPartBtn.Click += new System.EventHandler(this.AddAssociatedPartBtn_Click);
            // 
            // DeleteAssociatePartBtn
            // 
            this.DeleteAssociatePartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAssociatePartBtn.Location = new System.Drawing.Point(875, 514);
            this.DeleteAssociatePartBtn.Name = "DeleteAssociatePartBtn";
            this.DeleteAssociatePartBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteAssociatePartBtn.TabIndex = 24;
            this.DeleteAssociatePartBtn.Text = "Delete";
            this.DeleteAssociatePartBtn.UseVisualStyleBackColor = true;
            this.DeleteAssociatePartBtn.Click += new System.EventHandler(this.DeleteAssociatePartBtn_Click);
            // 
            // ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 557);
            this.Controls.Add(this.DeleteAssociatePartBtn);
            this.Controls.Add(this.AddAssociatedPartBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.AllPartsLbl);
            this.Controls.Add(this.AssociatedPartsLbl);
            this.Controls.Add(this.AssiociatedPartsDGV);
            this.Controls.Add(this.AllPartsDGV);
            this.Controls.Add(this.ProductAddMinBox);
            this.Controls.Add(this.ProductAddMaxBox);
            this.Controls.Add(this.ProductAddPriceBox);
            this.Controls.Add(this.ProductAddInventoryBox);
            this.Controls.Add(this.ProductAddNameBox);
            this.Controls.Add(this.ProductAddIDBox);
            this.Controls.Add(this.ProductAddNameLbl);
            this.Controls.Add(this.ProductAddInventoryLbl);
            this.Controls.Add(this.ProductAddPriceLbl);
            this.Controls.Add(this.ProductAddMaxLbl);
            this.Controls.Add(this.productAddMinLbl);
            this.Controls.Add(this.ProductAddIDLbl);
            this.Controls.Add(this.ProductAddLbl);
            this.Controls.Add(this.ProductAddSaveBtn);
            this.Controls.Add(this.ProductAddCancelBtn);
            this.Name = "ProductAdd";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssiociatedPartsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProductAddCancelBtn;
        private System.Windows.Forms.Button ProductAddSaveBtn;


        private System.Windows.Forms.Label ProductAddLbl;
        private System.Windows.Forms.Label ProductAddIDLbl;
        private System.Windows.Forms.Label productAddMinLbl;
        private System.Windows.Forms.Label ProductAddMaxLbl;
        private System.Windows.Forms.Label ProductAddPriceLbl;
        private System.Windows.Forms.Label ProductAddInventoryLbl;
        private System.Windows.Forms.Label ProductAddNameLbl;


        private System.Windows.Forms.TextBox ProductAddIDBox;
        private System.Windows.Forms.TextBox ProductAddNameBox;
        private System.Windows.Forms.TextBox ProductAddInventoryBox;
        private System.Windows.Forms.TextBox ProductAddPriceBox;
        private System.Windows.Forms.TextBox ProductAddMaxBox;
        private System.Windows.Forms.TextBox ProductAddMinBox;
        private System.Windows.Forms.DataGridView AllPartsDGV;
        private System.Windows.Forms.DataGridView AssiociatedPartsDGV;
        private System.Windows.Forms.Label AssociatedPartsLbl;
        private System.Windows.Forms.Label AllPartsLbl;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button AddAssociatedPartBtn;
        private System.Windows.Forms.Button DeleteAssociatePartBtn;

        public int ProductAddID
        {
            get { return int.Parse(ProductAddIDBox.Text); }
            set { ProductAddIDBox.Text = value.ToString(); }
        }

        public string ProductAddName
        {
            get { return ProductAddNameBox.Text; }
            set { ProductAddNameBox.Text = value.ToString(); }
        }

        public int ProductAddInventory
        {
            get { return int.Parse(ProductAddInventoryBox.Text); }
            set { ProductAddInventoryBox.Text = value.ToString(); }
        }

        public decimal ProductAddPrice
        {
            get { return decimal.Parse(ProductAddPriceBox.Text); }
            set { ProductAddPriceBox.Text = value.ToString(); }
        }

        public int ProductAddMax
        {
            get { return int.Parse(ProductAddMaxBox.Text); }
            set { ProductAddMaxBox.Text = value.ToString(); }
        }

        public int ProductAddMin
        {
            get { return int.Parse(ProductAddMinBox.Text); }
            set { ProductAddMinBox.Text = value.ToString(); }
        }
    }
}