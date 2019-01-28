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
    public partial class ProductAdd : Form
    {
        MainScreen MainScreenForm = (MainScreen)Application.OpenForms["MainScreen"];
        BindingList<Part> partsToAdd = new BindingList<Part>();

        private bool buttonWasClicked = false;
        
        public ProductAdd(Product product)
        {
            InitializeComponent();
            LoadProductAdd(product);
        }

        public void LoadProductAdd(Product currentProduct)
        {
            ProductAddID = currentProduct.ProductID;
            ProductAddName = currentProduct.Name;
            ProductAddInventory = currentProduct.InStock;
            ProductAddPrice = currentProduct.Price;
            ProductAddMax = currentProduct.Max;
            ProductAddMin = currentProduct.Min;

            var modBindingSource = new BindingSource
            {
                DataSource = Inventory.AllParts
            };
            AllPartsDGV.DataSource = modBindingSource;

            AllPartsDGV.Columns["PartID"].HeaderText = "Part ID";
            AllPartsDGV.Columns["Name"].HeaderText = "Name";
            AllPartsDGV.Columns["InStock"].HeaderText = "Inventory";
            AllPartsDGV.Columns["Price"].HeaderText = "Price";
            AllPartsDGV.Columns["Max"].Visible = false;
            AllPartsDGV.Columns["Min"].Visible = false;

            foreach (Part part in currentProduct.AssociatedParts)
            {
                partsToAdd.Add(part);
            }

            var modProductBindingSource = new BindingSource
            {
                DataSource = partsToAdd
            };
            AssiociatedPartsDGV.DataSource = modProductBindingSource;

            AssiociatedPartsDGV.Columns["PartID"].HeaderText = "Part ID";
            AssiociatedPartsDGV.Columns["Name"].HeaderText = "Name";
            AssiociatedPartsDGV.Columns["InStock"].HeaderText = "Inventory";
            AssiociatedPartsDGV.Columns["Price"].HeaderText = "Price";
            AssiociatedPartsDGV.Columns["Max"].Visible = false;
            AssiociatedPartsDGV.Columns["Min"].Visible = false;

            AssoicatedPartsDGVLoad();
            AllPartsDGVLoad();
        }

        private void AllPartsDGVLoad()
        {
            AllPartsDGV.RowHeadersVisible = false;
            AllPartsDGV.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightCoral;
            AllPartsDGV.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            AllPartsDGV
.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AssoicatedPartsDGVLoad()
        {
            AssiociatedPartsDGV.RowHeadersVisible = false;
            AssiociatedPartsDGV.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightCoral;
            AssiociatedPartsDGV.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            AssiociatedPartsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ProductAddCancelBtn_Click(object sender, EventArgs e)
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

        private void ProductAdd_Load(object sender, EventArgs e)
        {

        }

        private void ProductAddSaveBtn_Click(object sender, EventArgs e)
        {
            //Check the Name Text Box for a value
            if (string.IsNullOrEmpty(ProductAddNameBox.Text))
            {
                MessageBox.Show("Product name must have a value!");
                return;
            }

            //Check the Price Text Box for a number
            if (string.IsNullOrWhiteSpace(ProductAddPriceBox.Text))
            {
                MessageBox.Show("A numeric value is required for Product Price!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(ProductAddPriceBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Number is required for product inventory!");
                ProductAddPriceBox.Text = ProductAddPriceBox.Text.Remove(ProductAddPriceBox.Text.Length - 1);
                return;
            }

            //Check Inventory for a number
            if (string.IsNullOrWhiteSpace(ProductAddInventoryBox.Text))
            {
                MessageBox.Show("Number is required for product inventory!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(ProductAddInventoryBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Number is required for product inventory!");
                ProductAddInventoryBox.Text = ProductAddInventoryBox.Text.Remove(ProductAddInventoryBox.Text.Length - 1);
                return;
            }

            //Check Max for a number
            if (string.IsNullOrWhiteSpace(ProductAddMaxBox.Text))
            {
                MessageBox.Show("Number is required for product max!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(ProductAddMaxBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Number is required for product max!");
                ProductAddMaxBox.Text = ProductAddMaxBox.Text.Remove(ProductAddMaxBox.Text.Length - 1);
                return;
            }

            //Check Min for a number
            if (string.IsNullOrWhiteSpace(ProductAddMinBox.Text))
            {
                MessageBox.Show("Number is required for product min!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(ProductAddMinBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Number is required for product min!");
                ProductAddMinBox.Text = ProductAddMinBox.Text.Remove(ProductAddMinBox.Text.Length - 1);
                return;
            }

            //Check Max is greater than Min
            if (ProductAddMax < ProductAddMin)
            {
                MessageBox.Show("Product Max cannot be less than Min!");
            }

            //Check Inventory is between Min and Max
            if (ProductAddMin > ProductAddInventory)
            {
                MessageBox.Show("Inventory must be between the Max and the Min!");
                return;
            }

            if (ProductAddMax < ProductAddInventory)
            {
                MessageBox.Show("Inventory must be between the Max and the Min!");
                return;
            }

            //Check that Product has Associated Part
            if (AssiociatedPartsDGV.Rows.Count == 0)
            {
                MessageBox.Show("Product must have a minimum of one part associated with it! Please add a part and try again!");
                return;
            }


            Product updatedProduct = new Product(ProductAddID, ProductAddName, ProductAddPrice, ProductAddInventory, ProductAddMax, ProductAddMin);

            foreach (Part part in partsToAdd)
            {
                updatedProduct.AddAssociatedPart(part);
            }

            Inventory.UpdateProduct(ProductAddID, updatedProduct);

            this.Close();
            MainScreenForm.productsDataGridView.Refresh();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                MessageBox.Show("A number is required to search for a part!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(SearchTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Number is required to search for a part!");
                SearchTextBox.Text = SearchTextBox.Text.Remove(SearchTextBox.Text.Length - 1);
                return;
            }
            int searchBoxText = int.Parse(SearchTextBox.Text);
            Part find = Inventory.LookupPart(searchBoxText);
            foreach (DataGridViewRow row in AllPartsDGV.Rows)
            {
                Part foundPart = (Part)row.DataBoundItem;

                if (find == null)
                {
                    MessageBox.Show("No part found. Please try again!");
                    return;
                }
                else if (foundPart.PartID == find.PartID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void AddAssociatedPartBtn_Click(object sender, EventArgs e)
        {
            Part addPart = (Part)AllPartsDGV.CurrentRow.DataBoundItem;
            partsToAdd.Add(addPart);
        }

        private void DeleteAssociatePartBtn_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;

            if (buttonWasClicked == true)
            {
                if (MessageBox.Show("Are you sure you would like to remove associated part?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Part selectedPart = (Part)AssiociatedPartsDGV.CurrentRow.DataBoundItem;
                    int foundID = this.ProductAddID;
                    Product selectedProduct = Inventory.LookupProduct(foundID);
                    selectedProduct.RemoveAssociatedPart(selectedPart.PartID);

                    foreach (DataGridViewRow row in AssiociatedPartsDGV.SelectedRows)
                    {
                        AssiociatedPartsDGV.Rows.RemoveAt(row.Index);
                    }
                }
            }
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchBtn.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
    }
}
