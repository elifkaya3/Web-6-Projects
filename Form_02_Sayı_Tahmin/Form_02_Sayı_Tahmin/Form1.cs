using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_02_Sayı_Tahmin
{
    public partial class Form1 : Form
    {
        public int hedef;
        public int puan;
        public int hak;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            hedef = rnd.Next(1,100);
            puan = 50;
            hak = 5;
            btnBaslat.Text = "yeniden başlat";
            AktifEt();
            lblPuan.Text = puan.ToString();
            lblHak.Text = hak.ToString();
            lblMesaj.Text = "OYUN BAŞLADI"; 
            lblHile.Text = "HİLE: "+hedef.ToString(); //bu satır sonradan silinecek
            txtTahmin.Focus();
        }
        void AktifEt()
        {
            txtTahmin.Enabled = true;
            txtTahmin.Enabled = true;
            btnBaslat.Enabled = false;
        }
        void PasifEt()
        {
            txtTahmin.Enabled = false;
            txtTahmin.Enabled = false;
            btnBaslat.Enabled = true;
            btnBaslat.Focus();
        }
        void kontrolEt(int tahmin)
        {
            string sozcuk=" ";
            if (tahmin > hedef)
            {
                sozcuk = "kücük";
            }
            else if(tahmin<hedef)
            {
                sozcuk = "büyük";
            } 
                
            if (tahmin!=hedef)
            {
                hak -= 1;
                puan = puan - 10;
                if (hak==0)
                {
                    lblMesaj.Text = "üzgünüm kaybettiniz";
                    PasifEt();
                }
                else
                {
                    lblMesaj.Text = "daha"+ sozcuk+"sayı gir";
                }
            }
            else
            {
                lblMesaj.Text = "tebrikler oyunu kazandın";
                PasifEt();
            }

        }
        void TahminClick()
        {     
            int tahmin = int.Parse(txtTahmin.Text);
            kontrolEt(tahmin);
            lblTahminler.Text += "   "+txtTahmin.Text;
           /* if (txtTahmin.Text=="")
            {
                btnBaslat.Text;
            }*/
           // lblTahminler.Text = lblTahminler.Text + "  " + txtTahmin.Text;
            txtTahmin.Clear();
            txtTahmin.Focus();
        }
        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            TahminClick();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PasifEt();
        }
        private void txtTahmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                TahminClick();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
