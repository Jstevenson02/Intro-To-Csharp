using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_3_5_Stevenson
{
    public partial class Form1 : Form
    {

        const decimal totalFive = 0.05m;
        const decimal totalFifty = 0.50m;
        const decimal totalTwenty = 0.20m;
        const decimal totalTen = 0.10m;

        private decimal totalChange = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void clickcoin_Click(object sender, EventArgs e)
        {

        }

        private void fivecent_Click(object sender, EventArgs e)
        {
            totalChange += totalFive;
            changeCounted.Text = totalChange.ToString("c");
            
        }

        private void twentyfivecent_Click(object sender, EventArgs e)
        {
            totalChange += totalTwenty;
            changeCounted.Text = totalChange.ToString("c");
        }

        private void tencent_Click(object sender, EventArgs e)
        {
            totalChange += totalTen;
            changeCounted.Text = totalChange.ToString("c");
        }

        private void fiftycent_Click(object sender, EventArgs e)
        {
            totalChange += totalFifty;
            changeCounted.Text = totalChange.ToString("c");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
