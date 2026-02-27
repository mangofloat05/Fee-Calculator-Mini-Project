using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeeCalculatorUI
{
    public partial class SimpleCalc : Form
    {
        private double surchargeOffset = 5;
        private double percentageRate = 0.045;
        private double fixedFee = 10;

        public SimpleCalc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double surcharge = Convert.ToDouble(txtSurcharge.Text);
                double plusOffset = surcharge + surchargeOffset;
                double calculation = plusOffset * percentageRate;
                double roundedUp = Math.Ceiling(calculation);
                double fee = roundedUp + fixedFee;

                lblResult.Text = "Fee = ROUNDUP((" + surcharge.ToString("0.##") + "+" + surchargeOffset.ToString("0.###") + ")*" + percentageRate.ToString("0.###") + ",0) + " + fixedFee.ToString("0.###")
                    + Environment.NewLine
                    + "Fee = ROUNDUP(" + plusOffset.ToString("0.###") + "*" + percentageRate.ToString("0.###") + ",0) + " + fixedFee.ToString("0.###")
                    + Environment.NewLine
                    + "Fee = ROUNDUP(" + calculation.ToString("0.###") + ",0) + " + fixedFee.ToString("0.###")
                    + Environment.NewLine
                    + "Fee = " + roundedUp.ToString("0") + " + " + fixedFee.ToString("0.###")
                    + Environment.NewLine
                    + "Total Fee: " + fee.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-PH"));
                lblResult.ForeColor = Color.Green;
            }
            catch
            {
                MessageBox.Show("Please enter a valid numeric surcharge.");
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtSurcharge_change(object sender, EventArgs e)
        {

        }

        private void btnCalculateAR_Click(object sender, EventArgs e)
        {
            try
            {
                // Formula: AR Amount = Ticket Total + Payment Service Fee
                double ticketTotal = Convert.ToDouble(txtTicketTotal.Text);
                double serviceFee = Convert.ToDouble(txtServiceFee.Text);
                double arAmount = ticketTotal + serviceFee;

                lblArResult.Text = "AR Amount: " + arAmount.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-PH"));
                lblArResult.ForeColor = Color.Blue;
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers for Ticket and Service fees.");
            }
        }

        private void txtTicketTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtServiceFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblArResult_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEditFormula_Click(object sender, EventArgs e)
        {
            using (Form dialog = new Form())
            {
                dialog.Text = "Admin - Edit Fee Formula";
                dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.ClientSize = new Size(340, 180);
                dialog.MaximizeBox = false;
                dialog.MinimizeBox = false;

                Label lblOffset = new Label { Left = 15, Top = 20, Width = 200, Text = "Surcharge Offset (+X):" };
                TextBox txtOffset = new TextBox { Left = 220, Top = 17, Width = 100, Text = surchargeOffset.ToString("0.###") };

                Label lblRate = new Label { Left = 15, Top = 55, Width = 200, Text = "Percentage Rate (*Y):" };
                TextBox txtRate = new TextBox { Left = 220, Top = 52, Width = 100, Text = percentageRate.ToString("0.###") };

                Label lblFixed = new Label { Left = 15, Top = 90, Width = 200, Text = "Fixed Fee (+Z):" };
                TextBox txtFixed = new TextBox { Left = 220, Top = 87, Width = 100, Text = fixedFee.ToString("0.###") };

                Button btnSave = new Button { Text = "Save", Left = 164, Width = 75, Top = 130, DialogResult = DialogResult.OK };
                Button btnCancel = new Button { Text = "Cancel", Left = 245, Width = 75, Top = 130, DialogResult = DialogResult.Cancel };

                dialog.Controls.Add(lblOffset);
                dialog.Controls.Add(txtOffset);
                dialog.Controls.Add(lblRate);
                dialog.Controls.Add(txtRate);
                dialog.Controls.Add(lblFixed);
                dialog.Controls.Add(txtFixed);
                dialog.Controls.Add(btnSave);
                dialog.Controls.Add(btnCancel);

                dialog.AcceptButton = btnSave;
                dialog.CancelButton = btnCancel;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    double newOffset;
                    double newRate;
                    double newFixed;

                    if (!double.TryParse(txtOffset.Text, out newOffset) ||
                        !double.TryParse(txtRate.Text, out newRate) ||
                        !double.TryParse(txtFixed.Text, out newFixed))
                    {
                        MessageBox.Show("Please enter valid numeric values for formula settings.");
                        return;
                    }

                    surchargeOffset = newOffset;
                    percentageRate = newRate;
                    fixedFee = newFixed;

                    MessageBox.Show("Fee formula updated successfully.");
                }
            }
        }
    }
}
