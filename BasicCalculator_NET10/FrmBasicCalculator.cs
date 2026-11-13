
using System;
using System.Globalization;
using System.Windows.Forms;
using CalculatorLibrary;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        Calculator calculator = new Calculator();

        public FrmBasicCalculator()
        {
            InitializeComponent();
            cmbOperation.SelectedIndex = 0;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double first, second;

            if (!TryReadNumber(txtFirstNumber.Text, out first) ||
                !TryReadNumber(txtSecondNumber.Text, out second))
            {
                MessageBox.Show(
                    "Please enter valid numbers in both boxes.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            double result;

            try
            {
                switch (cmbOperation.SelectedItem.ToString())
                {
                    case "+":
                        result = calculator.Add(first, second);
                        break;

                    case "-":
                        result = calculator.Subtract(first, second);
                        break;

                    case "×":
                        result = calculator.Multiply(first, second);
                        break;

                    case "÷":
                        result = calculator.Divide(first, second);
                        break;

                    default:
                        MessageBox.Show("Please select an operation.");
                        return;
                }

                if (double.IsNaN(result) ||
                    double.IsInfinity(result))
                {
                    MessageBox.Show(
                        "The result is too large to display.",
                        "Math Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                lblResult.Text = result.ToString(
                    "G12",
                    CultureInfo.CurrentCulture);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show(
                    "Cannot divide by zero.",
                    "Math Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private static bool TryReadNumber(
            string value, out double result)
        {
            return double.TryParse(
                value,
                NumberStyles.Float |
                NumberStyles.AllowThousands,
                CultureInfo.CurrentCulture,
                out result);
        }
    }
}

    