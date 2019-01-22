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
        public ProductAdd()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ProductAddCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainScreen().Show();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {

        }

        private void ProductAddInHouse_CheckedChanged(object sender, EventArgs e)
        {
            ProductAddMachineNumberLbl.Text = "Machine Number";
        }

        private void ProductAddOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            ProductAddMachineNumberLbl.Text = "Company Name";
        }

        private void ProductAddMachineNumberBox_TextChanged(object sender, EventArgs e)
        {
            if (ProductAddInHouse.Checked)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(ProductAddMachineNumberBox.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please Enter Numbers Only!");
                    ProductAddMachineNumberBox.Text = ProductAddMachineNumberBox.Text.Remove(ProductAddMachineNumberBox.Text.Length - 1);
                }

            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(ProductAddMachineNumberBox.Text, "^[a-zA-Z ]"))
            {
                //PartAddMachineNameTextBox.Text.Remove(PartAddMachineNameTextBox.Text.Length - 1);
                MessageBox.Show("Company Name May Not Contain Numbers!");
            }
        }
    }
}
