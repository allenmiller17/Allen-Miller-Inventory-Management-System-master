using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Allen_Miller_Inventory_Management_System
{
    public partial class MainScreen : Form
    {
        public int partsIndex { get; set; }
        public int productIndex { get; set; }

        public MainScreen()
        {
            InitializeComponent();
            LoadMainScreen();
            PartsDataGridViewLoad();
            ProductDataGridViewLoad();
        }

        public void LoadMainScreen()
        {
            Inventory.CreateList();

            var bindingSource = new BindingSource
            {
                DataSource = Inventory.AllParts
            };
            partsDataGridView.DataSource = bindingSource;

            partsDataGridView.Columns["PartID"].HeaderText = "Part ID";
            partsDataGridView.Columns["Name"].HeaderText = "Name";
            partsDataGridView.Columns["InStock"].HeaderText = "Inventory";
            partsDataGridView.Columns["Price"].HeaderText = "Price";
            partsDataGridView.Columns["Max"].Visible = false;
            partsDataGridView.Columns["Min"].Visible = false;


            BindingSource bindingSource1 = new BindingSource();
            var bindingSourceProduct = bindingSource1;
            bindingSourceProduct.DataSource = Inventory.Products;
            productsDataGridView.DataSource = bindingSourceProduct;

            productsDataGridView.Columns["ProductID"].HeaderText = "Part ID";
            productsDataGridView.Columns["Name"].HeaderText = "Name";
            productsDataGridView.Columns["InStock"].HeaderText = "Inventory";
            productsDataGridView.Columns["Price"].HeaderText = "Price";
            productsDataGridView.Columns["Max"].Visible = false;
            productsDataGridView.Columns["Min"].Visible = false;

        }

        public void MainScreen_Load()
        {

        }
 

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void PartsAddBtn_Click(object sender, EventArgs e)
        {
            new PartAdd().Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PartsSearchBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void PartsSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductSearchBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ProductSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartsDataGridViewLoad()
        {
            partsDataGridView.RowHeadersVisible = false;
            partsDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightCoral;
            partsDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            partsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ProductDataGridViewLoad()
        {
            productsDataGridView.RowHeadersVisible = false;
            productsDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightCoral;
            productsDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void PartsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productIndex = e.RowIndex;
        }

        private void PartsModifyBtn_Click(object sender, EventArgs e)
        {
            if (partsDataGridView.CurrentRow.DataBoundItem.GetType() == typeof(Allen_Miller_Inventory_Management_System.InHouse))
            {
                InHouse inHouse = (InHouse)partsDataGridView.CurrentRow.DataBoundItem;
                new PartModify(inHouse).ShowDialog();
            }
            else
            {
                Outsourced outsourced = (Outsourced)partsDataGridView.CurrentRow.DataBoundItem;
                new PartModify(outsourced).ShowDialog();
            }
        }

        private void PartsDeleteBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in partsDataGridView.SelectedRows)
            {
                partsDataGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void ProductAddBtn_Click(object sender, EventArgs e)
        {
            new ProductAdd().Show();
        }

        private void ProductModifyBtn_Click(object sender, EventArgs e)
        {
            Product currentProduct = (Product)productsDataGridView.CurrentRow.DataBoundItem;
            new ProductModify(currentProduct).ShowDialog();
            
        }

        private void ProductDeleteBtn_Click(object sender, EventArgs e)
        {
            Product product = (Product)productsDataGridView.CurrentRow.DataBoundItem;
            if (product.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Cannot Delete A Product With A Part Assigned! Please Remove Part and Try Again!");
            }
        }

        private void groupParts_Enter(object sender, EventArgs e)
        {

        }
    }
}
