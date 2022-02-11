using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int Sayi1 = int.Parse(txtSayi1.Text);
            int Sayi2 = int.Parse(txtSayi2.Text);
            int Sonuc = Sayi1 + Sayi2;
            lblSonuc.Text = Sonuc.ToString();
        }

        private void btncıkar_Click(object sender, EventArgs e)
        {
            int Sayi1 = int.Parse(txtSayi1.Text);
            int Sayi2 = int.Parse(txtSayi2.Text);
            int Sonuc = Sayi1 - Sayi2;
            lblSonuc.Text = Sonuc.ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            int Sayi1 = int.Parse(txtSayi1.Text);
            int Sayi2 = int.Parse(txtSayi2.Text);
            int Sonuc = Sayi1 * Sayi2;
            lblSonuc.Text = Sonuc.ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            int Sayi1 = int.Parse(txtSayi1.Text);
            int Sayi2 = int.Parse(txtSayi2.Text);
            int Sonuc = Sayi1 / Sayi2;
            lblSonuc.Text = Sonuc.ToString();
        }
    }
}
