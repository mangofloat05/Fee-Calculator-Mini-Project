using System;
using System.Windows.Forms;

namespace FeeCalculatorUI
{
    public partial class AdminFormulaForm : Form
    {
        public double SurchargeOffset { get; private set; }
        public double PercentageRate { get; private set; }
        public double FixedFee { get; private set; }

        public AdminFormulaForm(double surchargeOffset, double percentageRate, double fixedFee)
        {
            InitializeComponent();

            SurchargeOffset = surchargeOffset;
            PercentageRate = percentageRate;
            FixedFee = fixedFee;

            txtOffset.Text = SurchargeOffset.ToString("0.###");
            txtRate.Text = PercentageRate.ToString("0.###");
            txtFixed.Text = FixedFee.ToString("0.###");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double newOffset;
            double newRate;
            double newFixed;

            if (!double.TryParse(txtOffset.Text, out newOffset) ||
                !double.TryParse(txtRate.Text, out newRate) ||
                !double.TryParse(txtFixed.Text, out newFixed))
            {
                MessageBox.Show("Please enter valid numeric values for formula settings.");
                DialogResult = DialogResult.None;
                return;
            }

            SurchargeOffset = newOffset;
            PercentageRate = newRate;
            FixedFee = newFixed;
        }
    }
}
