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
        public PartAdd()
        {
            InitializeComponent();
        }

        private void PartAddCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainScreen().Show();
        }

        private void PartAddSaveBtn_Click(object sender, EventArgs e)
        {
            //Check to see if the Min is greater than the Max
            if (PartAddMaxText < PartAddMinText)
            {
                MessageBox.Show("Minimum Value Cannot Be Greater Than The Maximum Value!");
                return;
            }

            //Check to see if Inventory is less than or equal to the Max
            if (PartAddMaxText <= PartAddInventoryText)
            {
                MessageBox.Show("Inventory Must Be Between Max and Min");
                return;
            }

            //Check to see if Inventory is greater than or equal to the Min
            if (PartAddMinText >= PartAddInventoryText)
            {
                MessageBox.Show("Inventory Must Be Between Max and Min");
                return;
            }

            if (PartAddInHouseRadio.Checked)
            {
                InHouse inHouse = new InHouse((Inventory.AllParts.Count + 1), PartAddNameText, PartAddPriceText, PartAddInventoryText, PartAddMaxText, PartAddMinText, int.Parse(PartAddMachineCompanyText));
                Inventory.AddPart(inHouse);
            }
            else
            {
                Outsourced outsourced = new Outsourced((Inventory.AllParts.Count + 1), PartAddNameText, PartAddPriceText, PartAddInventoryText, PartAddMaxText, PartAddMinText, PartAddMachineCompanyText);
            }

            this.Close();
            new MainScreen().Show();
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
            if (PartAddInHouseRadio.Checked)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(PartAddMachineNameTextBox.Text, "[^0-9]"))
                {
                     MessageBox.Show("Please Enter Numbers Only!");
                     PartAddMachineNameTextBox.Text = PartAddMachineNameTextBox.Text.Remove(PartAddMachineNameTextBox.Text.Length - 1);
                }
                
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(PartAddMachineNameTextBox.Text, "^[a-zA-Z ]"))
            {
                //PartAddMachineNameTextBox.Text.Remove(PartAddMachineNameTextBox.Text.Length - 1);
                MessageBox.Show("Company Name May Not Contain Numbers!");
            }

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
