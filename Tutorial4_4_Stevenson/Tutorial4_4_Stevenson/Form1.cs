using System;
using System.Windows.Forms;

namespace Tutorial4_4_Stevenson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CalculateMpg_Click(object sender, EventArgs e)
        {
            double miles; // To hold miles driven
            double gallons; // To hold gallons used
            double mpg; // To hold MPG

            // Validate the milesTextBox control.
            if (double.TryParse(numberOfMilesDriven.Text, out miles))
            {
                // Validate the gallonsTextBox control.
                if (double.TryParse(gallonsUsedInput.Text, out gallons))
                {
                    // Calculate MPG.
                    mpg = miles / gallons;

                    // Display the MPG in the mpgLabel control.
                    calculateMpgOutput.Text = mpg.ToString("n1");
                }
                else
                {
                    // Display an error message for gallonsTextBox.
                    MessageBox.Show("Invalid input for gallons.");
                }
            }
            else
            {
                // Display an error message for milesTextBox.
                MessageBox.Show("Invalid input for miles.");
            }
        }
    }
}