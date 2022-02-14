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
    public partial class Form5 : Form
    {
        Random rnd = new Random();
        int rSayi = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rSayi = rnd.Next(1,100);
            lblSayi.Text = rSayi.ToString();
        }

        private void lblSayi_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled==true)
            {
                timer1.Stop();
                MessageBox.Show(timer1.Enabled.ToString());

                  if (rSayi%2==0 && lblSonuc.Text==rdbCift.Checked.ToString() )               
                  {
                    lblSonuc.Text=" Kazandınız";

                  }
                  else
                  {
                    lblSonuc.Text=" Kaybettiniz";
                  }
            }
            else
            {
                timer1.Start();
            }
        }
        void status()
        {
            lblSonuc.Text = "Oyun Devam Ediyor...";
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }
         private void lstTahmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbTek.Checked && rSayi!=0)
            {
                MessageBox.Show("KAZANDIN");
            }
            else
            {
                MessageBox.Show("KAYBETTİN");
            }

        }
    }
}
