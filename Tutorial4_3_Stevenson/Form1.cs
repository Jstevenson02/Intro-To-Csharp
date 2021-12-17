using System;
using System.Windows.Forms;

namespace Tutorial4_3_Stevenson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yearsAtCurrentJob_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void annualSalaryInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void loanDecisionOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            annualSalaryInput.Text = "";
            yearsAtCurrentJob.Text = "";
            loanDecisionOutput.Text = "";
        }

        private void checkQualifications_Click(object sender, EventArgs e)
        {
            decimal annualSalary = 0m;
            int yearsAtJob = 0;
            const decimal MINIMUM_SALARY = 40000m;
            const int MINIMUM_YEARS_ON_JOB = 2;

            try
            {
                annualSalary = decimal.Parse(annualSalaryInput.Text);
                yearsAtJob = int.Parse(yearsAtCurrentJob.Text);

                if (yearsAtJob >= MINIMUM_YEARS_ON_JOB)
                {
                    loanDecisionOutput.Text = "You qualify for the loan.";

                    if (annualSalary >= MINIMUM_SALARY)
                    {
                        loanDecisionOutput.Text = "You qualify for the loan.";
                    }

                    else
                    {
                        loanDecisionOutput.Text = "Minimum salary requirement not met.";
                    }
                }
                else
                {
                    loanDecisionOutput.Text = "Minimum years requirement not met.";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
