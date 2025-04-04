using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cw_1a_Kalkulator_walutowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pln = double.Parse(iloscpln.Text);
            double usd = 3.86;
            double zamianausd = pln/3.86;

            double eur = 4.18;
            double chf = 4.38;
            double gbp = 5.01;

            if (waluta.Text == "EUR")
            {
                wynik.Text = "Wynik: " + zamianausd * (usd / eur);
            }
            else if (waluta.Text == "CHF") 
            {
                wynik.Text = "Wynik: " + zamianausd * (usd / chf);
            }
            else if (waluta.Text == "GBP") 
            {
                wynik.Text = "Wynik: " + zamianausd * (usd / gbp);
            }
            else if (waluta.Text == "test") 
            {
                wynik.Text = "Wynik: ";
            }
            else
            {
                wynik.Text = "Błąd! Brak wybranej walutylub nie poprawna waluta";
            }



        }
    }
}
