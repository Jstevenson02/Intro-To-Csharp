using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial4_4_Stevenson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            yellow.Checked = false;
            backToNormal.Checked = false;
            white.Checked = false;
            red.Checked = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (yellow.Checked)
                this.BackColor = Color.Yellow;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (backToNormal.Checked)
            this.BackColor = Color.Gray;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (white.Checked)
                this.BackColor = Color.White;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (red.Checked)
                this.BackColor = Color.Red;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
