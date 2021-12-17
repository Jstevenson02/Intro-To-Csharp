using System;
using System.Windows.Forms;

namespace lab3_3_4_Stevenson
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearclick_Click(object sender, EventArgs e)
        {
            test1.Text = " ";
            test2.Text = " ";
            test3.Text = " ";
            avg.Text = " ";
        }

        private void avgclick_Click(object sender, EventArgs e)
        {
            string test1Output = test1.Text;
            double test1num = double.Parse(test1Output);
            string test2Output = test2.Text;
            double test2num = double.Parse(test2Output);
            string test3Output = test3.Text;
            double test3num = double.Parse(test3Output);

            double average = test3num + test2num + test1num;
            avg.Text = average.ToString();

           
        }

        private void test1_TextChanged(object sender, EventArgs e)
        {

        }

        private void avg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
