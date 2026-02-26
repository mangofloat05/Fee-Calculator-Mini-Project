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
                // Formula: Fee = ROUNDUP((SURCHARGE+5)*0.045,0) + 10
                double surcharge = Convert.ToDouble(txtSurcharge.Text);
                double calculation = (surcharge + 5) * 0.045;
                double fee = Math.Ceiling(calculation) + 10;

                lblResult.Text = "Total Fee: " + fee.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-PH")); ;
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
    }
}
