using System;
using System.Windows.Forms;

namespace lab4_4_2_Stevenson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hoursWorkedOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void hourlyPayOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void grossPayOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                // constnat declaration
                const decimal BASE_HOURS = 40m;
                const decimal OVERTIME_RATE = 1.5m;

                // variaible definition
                decimal hourlyRate;
                decimal hoursWorked;
                decimal grossPay;
                decimal basePay;
                decimal overtimeHours;
                decimal overtimePay;

                // get hoursworked and hourrate
                hoursWorked = decimal.Parse(hoursWorkedOutput.Text);
                hourlyRate = decimal.Parse(hourlyPayOutput.Text);

                if (hoursWorked > BASE_HOURS)
                {
                    basePay = hourlyRate * BASE_HOURS;
                    overtimeHours = hoursWorked - BASE_HOURS;
                    overtimePay = overtimeHours * hourlyRate * OVERTIME_RATE;
                    grossPay = basePay + overtimePay;
                }
                else
                {
                    grossPay = hoursWorked * hourlyRate;
                }
                grossPayOutput.Text = grossPay.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
        private void clear_Click(object sender, EventArgs e)
        {
            hourlyPayOutput.Text = "";
            hoursWorkedOutput.Text = "";
            grossPayOutput.Text = "";

            hoursWorkedOutput.Focus();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
