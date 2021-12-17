using System;
using System.IO;
using System.Windows.Forms;

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                string countryName;
                StreamReader inputFile;
                inputFile = File.OpenText("Countries.txt");
                countriesListBox.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    countryName = inputFile.ReadLine();
                    countriesListBox.Items.Add(countryName);
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
