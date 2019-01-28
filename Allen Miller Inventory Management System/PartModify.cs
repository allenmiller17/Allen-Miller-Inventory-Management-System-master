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
    public partial class PartModify : Form
    {
        MainScreen MainScreenForm = (MainScreen)Application.OpenForms["MainScreen"];
        public PartModify(InHouse updatedPart)
        {
            InitializeComponent();

             PartModifyIDText = updatedPart.PartID;
             PartModifyNameText = updatedPart.Name;
             PartModifyInventoryText = updatedPart.InStock;
             PartModifyPriceText = updatedPart.Price;
             PartModifyMaxText = updatedPart.Max;
             PartModifyMinText = updatedPart.Min;
             PartModifyMachineCompanyText = updatedPart.MachineID.ToString();
        }
        public PartModify(Outsourced updatedOutPart)
        {
            InitializeComponent();

            PartModifyIDText = updatedOutPart.PartID;
            PartModifyNameText = updatedOutPart.Name;
            PartModifyInventoryText = updatedOutPart.InStock;
            PartModifyPriceText = updatedOutPart.Price;
            PartModifyMaxText = updatedOutPart.Max;
            PartModifyMinText = updatedOutPart.Min;
            PartModifyMachineCompanyText = updatedOutPart.CompanyName;
        }

        private bool buttonWasClicked = false;

        private void PartModifyCancelBtn_Click(object sender, EventArgs e)
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

        private void PartModifyInHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            PartModifyMachineNumberLabel.Text = "Machine Number";
        }

        private void PartModifyOutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            PartModifyMachineNumberLabel.Text = "Company Name";
        }

        private void PartModifyMachineNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void PartModify_Load(object sender, EventArgs e)
        {

        }

        private void PartModifyMachineNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartModifySaveBtn_Click(object sender, EventArgs e)
        {
            //Check the Name Text Box for a value
            if (string.IsNullOrEmpty(PartModifyNameTextBox.Text))
            {
                MessageBox.Show("Part name must have a value!");
                return;
            }

            //Check the Price Text Box for a number
            if (string.IsNullOrWhiteSpace(PartModifyPriceTextBox.Text))
            {
                MessageBox.Show("A numeric value is required for part price!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(PartModifyPriceTextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Number is required for part inventory!");
                PartModifyPriceTextBox.Text = PartModifyPriceTextBox.Text.Remove(PartModifyPriceTextBox.Text.Length - 1);
                return;
            }

            //Check Inventory for a number
            if (string.IsNullOrWhiteSpace(PartModifyInventoryTextBox.Text))
            {
                MessageBox.Show("Number is required for part inventory!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(PartModifyInventoryTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Number is required for part inventory!");
                PartModifyInventoryTextBox.Text = PartModifyInventoryTextBox.Text.Remove(PartModifyInventoryTextBox.Text.Length - 1);
                return;
            }

            //Check Max for a number
            if (string.IsNullOrWhiteSpace(PartModifyMaxTextBox.Text))
            {
                MessageBox.Show("Number is required for part max!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(PartModifyMaxTextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Number is required for part max!");
                PartModifyMaxTextBox.Text = PartModifyMaxTextBox.Text.Remove(PartModifyMaxTextBox.Text.Length - 1);
                return;
            }

            //Check Min for a number
            if (string.IsNullOrWhiteSpace(PartModifyMinTextBox.Text))
            {
                MessageBox.Show("Number is required for part min!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(PartModifyMinTextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Number is required for part min!");
                PartModifyMinTextBox.Text = PartModifyMinTextBox.Text.Remove(PartModifyMinTextBox.Text.Length - 1);
                return;
            }
            //Check to see if the Min is greater than the Max
            if (PartModifyMaxText < PartModifyMinText)
            {
                MessageBox.Show("Minimum Value Cannot Be Greater Than The Maximum Value!");
                return;
            }

            //Check to see if Inventory is less than or equal to the Max
            if (PartModifyMaxText < PartModifyInventoryText)
            {
                MessageBox.Show("Inventory Must Be Between Max and Min");
                return;
            }

            //Check to see if Inventory is greater than or equal to the Min
            if (PartModifyMinText > PartModifyInventoryText)
            {
                MessageBox.Show("Inventory Must Be Between Max and Min");
                return;
            }
            if (PartModifyInHouseRadio.Checked)
            {
                if (string.IsNullOrEmpty(PartModifyMachineNumberTextBox.Text))
                {
                    MessageBox.Show("Number is required for machine number!");
                    return;
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(PartModifyMachineNumberTextBox.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please Enter Numbers Only For Machine Number!");
                    PartModifyMachineNumberTextBox.Text = PartModifyMachineNumberTextBox.Text.Remove(PartModifyMachineNumberTextBox.Text.Length - 1);
                    return;
                }
                else
                {
                    InHouse inHouse = new InHouse(PartModifyIDText, PartModifyNameText, PartModifyPriceText, PartModifyInventoryText,
                    PartModifyMaxText, PartModifyMinText, int.Parse(PartModifyMachineCompanyText));
                    Inventory.InHouseModify(PartModifyIDText, inHouse);
                    PartModifyInHouseRadio.Checked = true;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(PartModifyMachineNumberTextBox.Text))
                {
                    MessageBox.Show("Name is requrired for company name!");
                    return;
                }
               else if (!System.Text.RegularExpressions.Regex.IsMatch(PartModifyMachineNumberTextBox.Text, "^[a-zA-Z ]"))
                {
                    PartModifyMachineNumberTextBox.Text.Remove(PartModifyMachineNumberTextBox.Text.Length - 1);
                    MessageBox.Show("Company Name May Not Contain Numbers!");
                    return;
                }
                else
                {
                    Outsourced outsourced = new Outsourced(PartModifyIDText, PartModifyNameText, PartModifyPriceText, PartModifyInventoryText,
                    PartModifyMaxText, PartModifyMinText, PartModifyMachineCompanyText);
                    Inventory.OutsourcedModify(PartModifyIDText, outsourced);
                    PartModifyOutsourcedRadio.Checked = true; 
                }
            }
            this.Close();
            //MainScreenForm.LoadMainScreen();
            MainScreenForm.partsDataGridView.Refresh();

        }
    }
}
