using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_3_3_Stevenson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcualteSalePrice_Click(object sender, EventArgs e)
        {
            decimal originalPriceInput;
            decimal discountPercInput;
            decimal discountAmount;
            decimal finalSale;

            // declare original price input string is double
            originalPriceInput = decimal.Parse(originalPrice.Text);
            
            // declare percent discount input string is double
            discountPercInput = decimal.Parse(discountPercentage.Text);
            
            // declare discount input double is equal to itself dividied by 100
            discountPercInput = discountPercInput / 100;

            // declare discount amount is equal to discount percent input * original price input 
            discountAmount = discountPercInput * originalPriceInput;

            // final sale is = original - discount
            finalSale = originalPriceInput - discountAmount;

            // send finalSale to string.Textbox
            salePrice.Text = finalSale.ToString("c");
        }

        private void exitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void originalPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void discountPercentage_TextChanged(object sender, EventArgs e)
        {

        }

        private void salePrice_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
