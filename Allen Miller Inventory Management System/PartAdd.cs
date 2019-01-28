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
    public partial class PartAdd : Form
    {
        MainScreen MainScreenForm = (MainScreen)Application.OpenForms["MainScreen"];

        private bool buttonWasClicked = false;

        public PartAdd()
        {
            InitializeComponent();
        }

        private void PartAddCancelBtn_Click(object sender, EventArgs e)
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

        private void PartAddSaveBtn_Click(object sender, EventArgs e)
        {
            //Check the Name Text Box for a value
            if (string.IsNullOrEmpty(PartAddNameTextBox.Text))
            {
                MessageBox.Show("Part name must have a value!");
                return;
            }

            //Check the Price Text Box for a number
            if (string.IsNullOrWhiteSpace(PartAddPriceTextBox.Text))
            {
                MessageBox.Show("A numeric value is required for part price!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(PartAddPriceTextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Number is required for part inventory!");
                PartAddPriceTextBox.Text = PartAddPriceTextBox.Text.Remove(PartAddPriceTextBox.Text.Length - 1);
                return;
            }

            //Check Inventory for a number
            if (string.IsNullOrWhiteSpace(PartAddInventoryTextBox.Text))
            {
                MessageBox.Show("Number is required for part inventory!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(PartAddInventoryTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Number is required for part inventory!");
                PartAddInventoryTextBox.Text = PartAddInventoryTextBox.Text.Remove(PartAddInventoryTextBox.Text.Length - 1);
                return;
            }

            //Check Max for a number
            if (string.IsNullOrWhiteSpace(PartAddMaxTextBox.Text))
            {
                MessageBox.Show("Number is required for part max!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(PartAddMaxTextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Number is required for part max!");
                PartAddMaxTextBox.Text = PartAddMaxTextBox.Text.Remove(PartAddMaxTextBox.Text.Length - 1);
                return;
            }

            //Check Min for a number
            if (string.IsNullOrWhiteSpace(PartAddMinTextBox.Text))
            {
                MessageBox.Show("Number is required for part min!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(PartAddMinTextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Number is required for part min!");
                PartAddMinTextBox.Text = PartAddMinTextBox.Text.Remove(PartAddMinTextBox.Text.Length - 1);
                return;
            }
            //Check to see if the Min is greater than the Max
            if (PartAddMaxText < PartAddMinText)
            {
                MessageBox.Show("Minimum Value Cannot Be Greater Than The Maximum Value!");
                return;
            }

            //Check to see if Inventory is less than or equal to the Max
            if (PartAddMaxText < PartAddInventoryText)
            {
                MessageBox.Show("Inventory Must Be Between Max and Min");
                return;
            }

            //Check to see if Inventory is greater than or equal to the Min
            if (PartAddMinText > PartAddInventoryText)
            {
                MessageBox.Show("Inventory Must Be Between Max and Min");
                return;
            }

            if (PartAddInHouseRadio.Checked)
            {
                if (string.IsNullOrEmpty(PartAddMachineNameTextBox.Text))
                {
                    MessageBox.Show("Number is required for machine number!");
                    return;
                }
               else if (System.Text.RegularExpressions.Regex.IsMatch(PartAddMachineNameTextBox.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please Enter Numbers Only!");
                    PartAddMachineNameTextBox.Text = PartAddMachineNameTextBox.Text.Remove(PartAddMachineNameTextBox.Text.Length - 1);
                }
                else
                {
                    InHouse inHouse = new InHouse((Inventory.AllParts.Count + 1), PartAddNameText, PartAddPriceText, PartAddInventoryText, PartAddMaxText, PartAddMinText, int.Parse(PartAddMachineCompanyText));
                    Inventory.AddPart(inHouse); 
                }
            }
            else
            {
                if (string.IsNullOrEmpty(PartAddMachineNameTextBox.Text))
                {
                    MessageBox.Show("Name is requrired for company name!");
                    return;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(PartAddMachineNameTextBox.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("Company Name May Not Contain Numbers!");
                }
                else
                {
                    Outsourced outsourced = new Outsourced((Inventory.AllParts.Count + 1), PartAddNameText, PartAddPriceText, PartAddInventoryText, PartAddMaxText, PartAddMinText, PartAddMachineCompanyText);
                    Inventory.AddPart(outsourced);
                }
            }

            this.Close();
            MainScreenForm.partsDataGridView.Refresh();
        }

        private void PartAddInHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            PartAddMachineNameLabel.Text = "Machine Number";
            PartAddMachineNameTextBox.Text = "12345";
        }

        private void PartAddOutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            PartAddMachineNameLabel.Text = "Company Name";
            PartAddMachineNameTextBox.Text = "Company Name";
        }

        private void PartAddIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartAddNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartAddInventoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartAddPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartAddMaxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartAddMachineNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartAddMinTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartAddMachineNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PartAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
