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

        private bool buttonWasClicked = false;

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
            buttonWasClicked = true;
            if (buttonWasClicked == true)
            {
                if (MessageBox.Show("Are you sure you would like to exit? All unsaved changes will be lost!", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProdModifySaveBtn_Click(object sender, EventArgs e)
        {
            //Check the Name Text Box for a value
            if (string.IsNullOrEmpty(ProdModifyNameTextBox.Text))
            {
                MessageBox.Show("Product name must have a value!");
                return;
            }

            //Check the Price Text Box for a number
            if (string.IsNullOrWhiteSpace(ProdModifyPriceTextBox.Text))
            {
                MessageBox.Show("A numeric value is required for Product Price!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(ProdModifyPriceTextBox.Text, "[^0-9.]"))
            {
                    MessageBox.Show("Number is required for product inventory!");
                    ProdModifyPriceTextBox.Text = ProdModifyPriceTextBox.Text.Remove(ProdModifyPriceTextBox.Text.Length - 1);
                    return;
            }

            //Check Inventory for a number
            if (string.IsNullOrWhiteSpace(ProdModifyInventoryTextBox.Text))
            {
                MessageBox.Show("Number is required for product inventory!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(ProdModifyInventoryTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Number is required for product inventory!");
                ProdModifyInventoryTextBox.Text = ProdModifyInventoryTextBox.Text.Remove(ProdModifyInventoryTextBox.Text.Length - 1);
                return;
            }

            //Check Max for a number
            if (string.IsNullOrWhiteSpace(ProdModifyMaxTextBox.Text))
            {
                MessageBox.Show("Number is required for product max!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(ProdModifyMaxTextBox.Text, "[^0-9.]"))
            {
                 MessageBox.Show("Number is required for product max!");
                 ProdModifyMaxTextBox.Text = ProdModifyMaxTextBox.Text.Remove(ProdModifyMaxTextBox.Text.Length - 1);
                 return;
            }

            //Check Min for a number
            if (string.IsNullOrWhiteSpace(ProdModifyMinTextBox.Text))
            {
                MessageBox.Show("Number is required for product min!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(ProdModifyMinTextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Number is required for product min!");
                ProdModifyMinTextBox.Text = ProdModifyMinTextBox.Text.Remove(ProdModifyMinTextBox.Text.Length - 1);
                return;
            }

            //Check Max is greater than Min
            if (prodModifyMaxText < prodModifyMinText)
            {
                MessageBox.Show("Product Max cannot be less than Min!");
            }

            //Check Inventory is between Min and Max
            if (prodModifyMinText > prodModifyInventoryText)
            {
                MessageBox.Show("Inventory must be between the Max and the Min!");
                return;
            }

            if (prodModifyMaxText < prodModifyInventoryText)
            {
                MessageBox.Show("Inventory must be between the Max and the Min!");
                return;
            }

            //Check that Product has Associated Part
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Product must have a minimum of one part associated with it! Please add a part and try again!");
                return;
            }


            Product updatedProduct = new Product(prodModifyIDText, prodModifyNameText, prodModifyPriceText, prodModifyInventoryText, prodModifyMaxText, prodModifyMinText);

            foreach (Part part in partsToAdd)
            {
                updatedProduct.AddAssociatedPart(part);
            }

            Inventory.UpdateProduct(prodModifyIDText, updatedProduct);

            this.Close();
            MainScreenForm.LoadMainScreen();
            MainScreenForm.productsDataGridView.Refresh();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Part addPart = (Part)dataGridView1.CurrentRow.DataBoundItem;
            partsToAdd.Add(addPart);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;

            if (buttonWasClicked == true)
            {
                if (MessageBox.Show("Are you sure you would like to remove associated part?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Part selectedPart = (Part)dataGridView2.CurrentRow.DataBoundItem;
                    int foundID = this.prodModifyIDText;
                    Product selectedProduct = Inventory.LookupProduct(foundID);
                    selectedProduct.RemoveAssociatedPart(selectedPart.PartID);

                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                         dataGridView2.Rows.RemoveAt(row.Index);
                    }
                }
            }

        }

    }
}

