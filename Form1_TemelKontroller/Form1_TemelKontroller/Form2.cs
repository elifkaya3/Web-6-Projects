using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1_TemelKontroller
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void Ekle()
        {
            lstKisiler.Items.Add(txtAdSoyad.Text.ToUpper().Trim());
            //  txtAdSoyad.Text = "";
            // txtAdSoyad.Clear();
            txtAdSoyad.ResetText();//yazdığımı enterdan sonra sil//enter için acceptbutton değiş
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            string adSoyad = txtAdSoyad.Text;
            int uzunluk = adSoyad.Length;
            if (uzunluk >= 1)
            {
                int konum = uzunluk - 1;
           
                if (adSoyad[konum].ToString()=="")
                {
                     e.Handled = e.KeyChar == (char)Keys.Space;
                }               
            }
            else
            {
                e.Handled = e.KeyChar == (char)Keys.Space;

            }
            if (e.KeyChar==(char)Keys.Enter)
            {
                Ekle();
            }
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Kişi Sayısı:{lstKisiler.Items.Count}");
        }
        void Arama()
        {
            string aranan = txtAranan.Text.ToUpper();
            if (lstKisiler.Items.Contains(aranan))
            {
                lblBulunan.Text = aranan;
            }
            else
            {
                lblBulunan.Text = "Aradığınız kayıt bulunamadı.";
            }
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            Arama();
        }

        private void txtAranan_KeyPress(object sender, KeyPressEventArgs e)
        {
            //enter tuşunu kontrol eden keys.enter
            if (e.KeyChar==(char)Keys.Enter)//enter tuşuna basılınca buton çalışsın 
            {
                Arama(); //eklme yap!!
            }

        }

       
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        { 
            Form1 form1 = new Form1();
            form1.Show();

        }
    }
}
