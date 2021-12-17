using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_2_4_Stevenson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FinnishFlag_Click(object sender, EventArgs e)
        {
            outputCountry.Text = "Finland";
        }

        private void GermanFlag_Click(object sender, EventArgs e)
        {
            outputCountry.Text = "Germany";

        }

        private void FrenchFlag_Click(object sender, EventArgs e)
        {
            outputCountry.Text = "France";

        }

        private void OutputCountry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
