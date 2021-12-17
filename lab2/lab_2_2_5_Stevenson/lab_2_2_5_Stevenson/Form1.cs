using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2_2_5_Stevenson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void ShowFront_Click(object sender, EventArgs e)
        {
            backCard.Visible = false;
            faceCard.Visible = true;
        }

        private void ShowBack_Click(object sender, EventArgs e)
        {
            backCard.Visible = true;
            faceCard.Visible = false;
        }
    }
}
