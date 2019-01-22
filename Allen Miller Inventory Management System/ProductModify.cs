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
    public partial class ProductModify : Form
    {
        BindingList<Part> partsToAdd = new BindingList<Part>();
        MainScreen MainScreenForm = (MainScreen)Application.OpenForms["MainScreen"];

        public ProductModify(Product product)
        {
            InitializeComponent();
            LoadProductModify(product);
        }

        public void LoadProductModify(Product currentProduct)
        {
            prodModifyIDText = currentProduct.ProductID;
            prodModifyNameText = currentProduct.Name;
            prodModifyInventoryText = currentProduct.InStock;
            prodModifyPriceText = currentProduct.Price;
            prodModifyMaxText = currentProduct.Max;
            prodModifyMinText = currentProduct.Min;

            var modBindingSource = new BindingSource
            {
                DataSource = Inventory.AllParts
            };
            dataGridView1.DataSource = modBindingSource;

            dataGridView1.Columns["PartID"].HeaderText = "Part ID";
            dataGridView1.Columns["Name"].HeaderText = "Name";
            dataGridView1.Columns["InStock"].HeaderText = "Inventory";
            dataGridView1.Columns["Price"].HeaderText = "Price";
            dataGridView1.Columns["Max"].Visible = false;
            dataGridView1.Columns["Min"].Visible = false;

            foreach (Part part in currentProduct.AssociatedParts)
            {
                partsToAdd.Add(part);
            }

            var modProductBindingSource = new BindingSource
            {
                DataSource = partsToAdd
            };
            dataGridView2.DataSource = modProductBindingSource;

            dataGridView2.Columns["PartID"].HeaderText = "Part ID";
            dataGridView2.Columns["Name"].HeaderText = "Name";
            dataGridView2.Columns["InStock"].HeaderText = "Inventory";
            dataGridView2.Columns["Price"].HeaderText = "Price";
            dataGridView2.Columns["Max"].Visible = false;
            dataGridView2.Columns["Min"].Visible = false;

            AssoicatedPartsDGVLoad();
            AllPartsDGVLoad();
        }

        private void AllPartsDGVLoad()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AssoicatedPartsDGVLoad()
        {
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridView2.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ProductModify_Load(object sender, EventArgs e)
        {
            
        }

        private void ProdModifyCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProdModifyMachineNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProdModifySaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
