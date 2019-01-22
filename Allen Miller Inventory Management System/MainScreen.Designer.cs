namespace Allen_Miller_Inventory_Management_System
{
    partial class MainScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupParts = new System.Windows.Forms.GroupBox();
            this.partsDeleteBtn = new System.Windows.Forms.Button();
            this.partsModifyBtn = new System.Windows.Forms.Button();
            this.partsAddBtn = new System.Windows.Forms.Button();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.partsSearchBtn = new System.Windows.Forms.Button();
            this.partsSearchBox = new System.Windows.Forms.TextBox();
            this.groupProducts = new System.Windows.Forms.GroupBox();
            this.productAddBtn = new System.Windows.Forms.Button();
            this.productModifyBtn = new System.Windows.Forms.Button();
            this.productDeleteBtn = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.productSearchBtn = new System.Windows.Forms.Button();
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.inventoryMS = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            this.groupProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupParts
            // 
            this.groupParts.Controls.Add(this.partsDeleteBtn);
            this.groupParts.Controls.Add(this.partsModifyBtn);
            this.groupParts.Controls.Add(this.partsAddBtn);
            this.groupParts.Controls.Add(this.partsDataGridView);
            this.groupParts.Controls.Add(this.partsSearchBtn);
            this.groupParts.Controls.Add(this.partsSearchBox);
            this.groupParts.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupParts.Location = new System.Drawing.Point(16, 81);
            this.groupParts.Margin = new System.Windows.Forms.Padding(4);
            this.groupParts.Name = "groupParts";
            this.groupParts.Padding = new System.Windows.Forms.Padding(4);
            this.groupParts.Size = new System.Drawing.Size(504, 362);
            this.groupParts.TabIndex = 0;
            this.groupParts.TabStop = false;
            this.groupParts.Text = "Parts";
            this.groupParts.Enter += new System.EventHandler(this.groupParts_Enter);
            // 
            // partsDeleteBtn
            // 
            this.partsDeleteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.partsDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.partsDeleteBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsDeleteBtn.Location = new System.Drawing.Point(189, 318);
            this.partsDeleteBtn.Name = "partsDeleteBtn";
            this.partsDeleteBtn.Size = new System.Drawing.Size(85, 28);
            this.partsDeleteBtn.TabIndex = 5;
            this.partsDeleteBtn.Text = "Delete";
            this.partsDeleteBtn.UseVisualStyleBackColor = false;
            this.partsDeleteBtn.Click += new System.EventHandler(this.PartsDeleteBtn_Click);
            // 
            // partsModifyBtn
            // 
            this.partsModifyBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.partsModifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.partsModifyBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsModifyBtn.Location = new System.Drawing.Point(98, 318);
            this.partsModifyBtn.Name = "partsModifyBtn";
            this.partsModifyBtn.Size = new System.Drawing.Size(85, 28);
            this.partsModifyBtn.TabIndex = 4;
            this.partsModifyBtn.Text = "Modify";
            this.partsModifyBtn.UseVisualStyleBackColor = false;
            this.partsModifyBtn.Click += new System.EventHandler(this.PartsModifyBtn_Click);
            // 
            // partsAddBtn
            // 
            this.partsAddBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.partsAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.partsAddBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsAddBtn.Location = new System.Drawing.Point(7, 318);
            this.partsAddBtn.Name = "partsAddBtn";
            this.partsAddBtn.Size = new System.Drawing.Size(85, 28);
            this.partsAddBtn.TabIndex = 3;
            this.partsAddBtn.Text = "Add";
            this.partsAddBtn.UseVisualStyleBackColor = false;
            this.partsAddBtn.Click += new System.EventHandler(this.PartsAddBtn_Click);
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.partsDataGridView.BackgroundColor = System.Drawing.Color.Azure;
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.partsDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.partsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.partsDataGridView.Location = new System.Drawing.Point(7, 66);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.ReadOnly = true;
            this.partsDataGridView.Size = new System.Drawing.Size(490, 220);
            this.partsDataGridView.TabIndex = 2;
            this.partsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsDataGridView_CellContentClick);
            // 
            // partsSearchBtn
            // 
            this.partsSearchBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.partsSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.partsSearchBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSearchBtn.Location = new System.Drawing.Point(7, 34);
            this.partsSearchBtn.Name = "partsSearchBtn";
            this.partsSearchBtn.Size = new System.Drawing.Size(100, 25);
            this.partsSearchBtn.TabIndex = 1;
            this.partsSearchBtn.Text = "Search";
            this.partsSearchBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.partsSearchBtn.UseVisualStyleBackColor = false;
            this.partsSearchBtn.Click += new System.EventHandler(this.PartsSearchBtn_Click);
            // 
            // partsSearchBox
            // 
            this.partsSearchBox.Location = new System.Drawing.Point(113, 35);
            this.partsSearchBox.Multiline = true;
            this.partsSearchBox.Name = "partsSearchBox";
            this.partsSearchBox.Size = new System.Drawing.Size(160, 25);
            this.partsSearchBox.TabIndex = 0;
            this.partsSearchBox.TextChanged += new System.EventHandler(this.PartsSearchBox_TextChanged);
            // 
            // groupProducts
            // 
            this.groupProducts.Controls.Add(this.productAddBtn);
            this.groupProducts.Controls.Add(this.productModifyBtn);
            this.groupProducts.Controls.Add(this.productDeleteBtn);
            this.groupProducts.Controls.Add(this.productsDataGridView);
            this.groupProducts.Controls.Add(this.productSearchBtn);
            this.groupProducts.Controls.Add(this.productSearchBox);
            this.groupProducts.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupProducts.Location = new System.Drawing.Point(547, 81);
            this.groupProducts.Margin = new System.Windows.Forms.Padding(4);
            this.groupProducts.Name = "groupProducts";
            this.groupProducts.Padding = new System.Windows.Forms.Padding(4);
            this.groupProducts.Size = new System.Drawing.Size(504, 362);
            this.groupProducts.TabIndex = 1;
            this.groupProducts.TabStop = false;
            this.groupProducts.Text = "Products";
            // 
            // productAddBtn
            // 
            this.productAddBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.productAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.productAddBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productAddBtn.Location = new System.Drawing.Point(231, 318);
            this.productAddBtn.Name = "productAddBtn";
            this.productAddBtn.Size = new System.Drawing.Size(85, 28);
            this.productAddBtn.TabIndex = 5;
            this.productAddBtn.Text = "Add";
            this.productAddBtn.UseVisualStyleBackColor = false;
            this.productAddBtn.Click += new System.EventHandler(this.ProductAddBtn_Click);
            // 
            // productModifyBtn
            // 
            this.productModifyBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.productModifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.productModifyBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productModifyBtn.Location = new System.Drawing.Point(322, 318);
            this.productModifyBtn.Name = "productModifyBtn";
            this.productModifyBtn.Size = new System.Drawing.Size(85, 28);
            this.productModifyBtn.TabIndex = 4;
            this.productModifyBtn.Text = "Modify";
            this.productModifyBtn.UseVisualStyleBackColor = false;
            this.productModifyBtn.Click += new System.EventHandler(this.ProductModifyBtn_Click);
            // 
            // productDeleteBtn
            // 
            this.productDeleteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.productDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.productDeleteBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDeleteBtn.Location = new System.Drawing.Point(413, 318);
            this.productDeleteBtn.Name = "productDeleteBtn";
            this.productDeleteBtn.Size = new System.Drawing.Size(85, 28);
            this.productDeleteBtn.TabIndex = 3;
            this.productDeleteBtn.Text = "Delete";
            this.productDeleteBtn.UseVisualStyleBackColor = false;
            this.productDeleteBtn.Click += new System.EventHandler(this.ProductDeleteBtn_Click);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productsDataGridView.BackgroundColor = System.Drawing.Color.Azure;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.productsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productsDataGridView.Location = new System.Drawing.Point(8, 66);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.Size = new System.Drawing.Size(490, 221);
            this.productsDataGridView.TabIndex = 2;
            this.productsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellContentClick);
            // 
            // productSearchBtn
            // 
            this.productSearchBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.productSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.productSearchBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSearchBtn.Location = new System.Drawing.Point(8, 35);
            this.productSearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.productSearchBtn.Name = "productSearchBtn";
            this.productSearchBtn.Size = new System.Drawing.Size(100, 25);
            this.productSearchBtn.TabIndex = 1;
            this.productSearchBtn.Text = "Search";
            this.productSearchBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.productSearchBtn.UseVisualStyleBackColor = false;
            this.productSearchBtn.Click += new System.EventHandler(this.ProductSearchBtn_Click);
            // 
            // productSearchBox
            // 
            this.productSearchBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.productSearchBox.Location = new System.Drawing.Point(116, 34);
            this.productSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.productSearchBox.Multiline = true;
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(160, 25);
            this.productSearchBox.TabIndex = 0;
            this.productSearchBox.TextChanged += new System.EventHandler(this.ProductSearchBox_TextChanged);
            // 
            // inventoryMS
            // 
            this.inventoryMS.AutoSize = true;
            this.inventoryMS.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryMS.Location = new System.Drawing.Point(0, 0);
            this.inventoryMS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventoryMS.Name = "inventoryMS";
            this.inventoryMS.Size = new System.Drawing.Size(624, 52);
            this.inventoryMS.TabIndex = 2;
            this.inventoryMS.Text = "Inventory Management System";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(960, 502);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(85, 28);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.inventoryMS);
            this.Controls.Add(this.groupProducts);
            this.Controls.Add(this.groupParts);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.groupParts.ResumeLayout(false);
            this.groupParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            this.groupProducts.ResumeLayout(false);
            this.groupProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupParts;
        private System.Windows.Forms.GroupBox groupProducts;
        private System.Windows.Forms.Label inventoryMS;
        private System.Windows.Forms.TextBox partsSearchBox;
        private System.Windows.Forms.Button productSearchBtn;
        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.Button partsDeleteBtn;
        private System.Windows.Forms.Button partsModifyBtn;
        private System.Windows.Forms.Button partsAddBtn;
        public System.Windows.Forms.DataGridView partsDataGridView;
        private System.Windows.Forms.Button partsSearchBtn;
        private System.Windows.Forms.Button productAddBtn;
        private System.Windows.Forms.Button productModifyBtn;
        private System.Windows.Forms.Button productDeleteBtn;
        public System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Button exitBtn;

        public int partsSearchBoxText
        {
            get { return int.Parse(partsSearchBox.Text); }
            set { partsSearchBox.Text = value.ToString(); }
        }

        public int productsSearchBoxText
        {
            get { return int.Parse(productSearchBox.Text); }
            set { productSearchBox.Text = value.ToString(); }
        }
    }
}

