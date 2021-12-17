using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_1_Stevenson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void test1_TextChanged(object sender, EventArgs e)
        {

        }

        private void test2_TextChanged(object sender, EventArgs e)
        {

        }

        private void test3_TextChanged(object sender, EventArgs e)
        {
        }

        private void AverageForTests_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateAverage_Click(object sender, EventArgs e)
        {
            double Test1 = double.Parse(test1.Text);
            double Test2 = double.Parse(test2.Text);
            double Test3 = double.Parse(test3.Text);
            const double HIGH_SCORE = 95.0;

            double average = (Test1 + Test2 + Test3) / 3.0;
            AverageForTests.Text = average.ToString("n1");

            if (average >= 95.0)
            {
                MessageBox.Show("Congratulations you got a high score!");
            }
            else
                MessageBox.Show("Well, you did your best!");
            
        }

        private void ClearFields_Click(object sender, EventArgs e)
        {
            test1.Text = "";
            test2.Text = "";
            test3.Text = "";
            AverageForTests.Text = "";

            test1.Focus();
        }

        private void ExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
