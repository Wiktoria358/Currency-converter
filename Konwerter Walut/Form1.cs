using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konwerter_Walut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
            textBox2.Text = przelicz(hScrollBar1.Value).ToString();
        }

        private double przelicz(double x)
        {
            double walutaPrzeliczeniowa = 0;
            double walutaDocelowa = 0;
            if (radioButton1.Checked == true) walutaPrzeliczeniowa = x;
            else if (radioButton2.Checked == true) walutaPrzeliczeniowa = x * 4.5;
            else if (radioButton3.Checked == true) walutaPrzeliczeniowa = x * 4.2;

            if (radioButton4.Checked == true) walutaDocelowa = walutaPrzeliczeniowa;
            if (radioButton5.Checked == true) walutaDocelowa = walutaPrzeliczeniowa / 4.5;
            if (radioButton6.Checked == true) walutaDocelowa = walutaPrzeliczeniowa / 4.2;

            if (radioButton1.Checked == true) label1.Text = "PLN";
            if (radioButton2.Checked == true) label1.Text = "EURO";
            if (radioButton3.Checked == true) label1.Text = "USD";

            if (radioButton4.Checked == true) label2.Text = "PLN";
            if (radioButton5.Checked == true) label2.Text = "EURO";
            if (radioButton6.Checked == true) label2.Text = "USD";

            return Math.Round(walutaDocelowa, 2);
        }
    }
}
