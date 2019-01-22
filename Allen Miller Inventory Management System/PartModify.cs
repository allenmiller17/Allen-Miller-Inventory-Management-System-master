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

        private void PartModifyCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
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
            if (PartModifyInHouseRadio.Checked)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(PartModifyMachineNumberTextBox.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please Enter Numbers Only For Machine Number!");
                    PartModifyMachineNumberTextBox.Text = PartModifyMachineNumberTextBox.Text.Remove(PartModifyMachineNumberTextBox.Text.Length - 1);
                    return;
                }

                InHouse inHouse = new InHouse(PartModifyIDText, PartModifyNameText, PartModifyPriceText, PartModifyInventoryText,
                    PartModifyMaxText, PartModifyMinText, int.Parse(PartModifyMachineCompanyText));
                Inventory.InHouseModify(PartModifyIDText, inHouse);
                PartModifyInHouseRadio.Checked = true;
            }
            else
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(PartModifyMachineNumberTextBox.Text, "^[a-zA-Z ]"))
                {
                    PartModifyMachineNumberTextBox.Text.Remove(PartModifyMachineNumberTextBox.Text.Length - 1);
                    MessageBox.Show("Company Name May Not Contain Numbers!");
                    return;
                }

                Outsourced outsourced = new Outsourced(PartModifyIDText, PartModifyNameText, PartModifyPriceText, PartModifyInventoryText,
                    PartModifyMaxText, PartModifyMinText, PartModifyMachineCompanyText);
                Inventory.OutsourcedModify(PartModifyIDText, outsourced);
                PartModifyOutsourcedRadio.Checked = true;

            }
            this.Close();
            MainScreenForm.LoadMainScreen();
            MainScreenForm.partsDataGridView.Refresh();

        }
    }
}
