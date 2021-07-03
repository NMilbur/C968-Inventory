using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMilburn_InventoryApp
{
    public partial class PartForm : Form
    {
        public PartForm()
        {
            InitializeComponent();
            partFormLabel.Text = "Add Part";
        }

        public PartForm(Part part) {
            InitializeComponent();
            partFormLabel.Text = "Modify Part";
            loadPartForm(part);
        }

        public void loadPartForm(Part part) {
            partIDInput.Text = part.PartID.ToString();
            partNameInput.Text = part.Name;
            partInventoryInput.Text = part.InStock.ToString();
            partCostInput.Text = part.Price.ToString();
            maxInput.Text = part.Max.ToString();
            minInput.Text = part.Min.ToString();

            if (part is Inhouse) {
                loadInhouse((Inhouse)part);

            } else {
                loadOutsourced((Outsourced)part);
            }
        }

        public void loadInhouse(Inhouse part) {
            inHouseRadioBtn.Select();
            partOriginSpecificInput.Text = part.MachineID.ToString();
            partOriginSpecificLabel.Text = "Machine ID";
        }

        public void loadOutsourced(Outsourced part)
        {
            outsourceRadionBtn.Select();
            partOriginSpecificInput.Text = part.CompanyName.ToString();
            partOriginSpecificLabel.Text = "Company Name";
        }

        private void inHouseRadioBtn_Click(object sender, EventArgs e) {
            partOriginSpecificLabel.Text = "Machine ID";
        }

        private void outsourceRadionBtn_Click(object sender, EventArgs e) {
            partOriginSpecificLabel.Text = "Company Name";
        }

        private void saveBtn_Click(object sender, EventArgs e) {
            bool allowSubmit = true;
            int testInt;
            decimal testDec;

            if (!int.TryParse(partInventoryInput.Text, out testInt) ||
                !decimal.TryParse(partCostInput.Text, out testDec) ||
                !int.TryParse(maxInput.Text, out testInt) ||
                !int.TryParse(minInput.Text, out testInt))
            {
                MessageBox.Show("Invalid input, check error next to fields if applicable");
                allowSubmit = false;
            }

            else if (Convert.ToInt32(maxInput.Text) < Convert.ToInt32(minInput.Text))
            {
                MessageBox.Show("Max field should be more than the Min field");
                allowSubmit = false;
            }

            else if (Convert.ToInt32(partInventoryInput.Text) < Convert.ToInt32(minInput.Text) ||
                Convert.ToInt32(partInventoryInput.Text) > Convert.ToInt32(maxInput.Text))
            {
                MessageBox.Show("Inventory Field must be between the values in the Min and Max fields.");
                allowSubmit = false;
            }

            if (allowSubmit)
            {
                if (!String.IsNullOrWhiteSpace(partIDInput.Text))
                {
                    Part existingPart = Inventory.lookupPart(Convert.ToInt32(partIDInput.Text));
                    if (inHouseRadioBtn.Checked)
                    {
                        if (!int.TryParse(partOriginSpecificInput.Text, out testInt))
                        {
                            MessageBox.Show("Machine ID needs to be an integer value");

                        }
                        else
                        {

                            Inventory.updatePart(Convert.ToInt32(partIDInput.Text), new Inhouse(
                                partNameInput.Text,
                                Convert.ToInt32(partInventoryInput.Text),
                                Convert.ToDecimal(partCostInput.Text),
                                Convert.ToInt32(maxInput.Text),
                                Convert.ToInt32(minInput.Text),
                                Convert.ToInt32(partOriginSpecificInput.Text)
                            ));
                        }

                    }
                    else
                    {
                        Inventory.updatePart(Convert.ToInt32(partIDInput.Text), new Outsourced(
                            partNameInput.Text,
                            Convert.ToInt32(partInventoryInput.Text),
                            Convert.ToDecimal(partCostInput.Text),
                            Convert.ToInt32(maxInput.Text),
                            Convert.ToInt32(minInput.Text),
                            partOriginSpecificInput.Text
                        ));
                    }
                }
                else
                {
                    if (inHouseRadioBtn.Checked)
                    {
                        if (!int.TryParse(partOriginSpecificInput.Text, out testInt))
                        {
                            MessageBox.Show("Machine ID needs to be an integer value");

                        }
                        else
                        {
                            Inventory.PartIncrement += 1;

                            Inventory.addPart(new Inhouse(
                                Inventory.PartIncrement,
                                partNameInput.Text,
                                Convert.ToInt32(partInventoryInput.Text),
                                Convert.ToDecimal(partCostInput.Text),
                                Convert.ToInt32(maxInput.Text),
                                Convert.ToInt32(minInput.Text),
                                Convert.ToInt32(partOriginSpecificInput.Text)
                            ));
                        }
                    }
                    else
                    {
                        Inventory.PartIncrement += 1;

                        Inventory.addPart(new Outsourced(
                            Inventory.PartIncrement,
                            partNameInput.Text,
                            Convert.ToInt32(partInventoryInput.Text),
                            Convert.ToDecimal(partCostInput.Text),
                            Convert.ToInt32(maxInput.Text),
                            Convert.ToInt32(minInput.Text),
                            partOriginSpecificInput.Text
                        ));
                    }

                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void partInventoryInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                int x = Int32.Parse(partInventoryInput.Text);
                errorProvider1.SetError(partInventoryInput, "");

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(partInventoryInput, "Not an integer");
            }
        }

        private void partCostInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                decimal x = Decimal.Parse(partCostInput.Text);
                errorProvider1.SetError(partCostInput, "");

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(partCostInput, "Not a decimal");
            }
        }

        private void maxInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                int x = Int32.Parse(maxInput.Text);
                errorProvider1.SetError(maxInput, "");

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(maxInput, "Not an integer");
            }
        }

        private void minInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                int x = Int32.Parse(minInput.Text);
                errorProvider1.SetError(minInput, "");

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(minInput, "Not an integer");
            }
        }
    }
}
