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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
       string CinsiyetBelirle()
        {
            if (rdbKadın.Checked==true)
            {
                return "kadın";
            }
            else
            {
                return "erkek";
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            rdbKadın.Checked = true;
        }

        void Ekle()
        {   
            ListViewItem lvi = new ListViewItem();
            lvi.Text = txtAdSoyad.Text;//lvi nin text özelliği 1. kolon işarte eder oraya yazdırır.
            lvi.SubItems.Add(CinsiyetBelirle());
            lsvKisiler.Items.Add(lvi);
            txtAdSoyad.ResetText();

        }
        private void btnEkle1_Click(object sender, EventArgs e)
        {
            Ekle();
        }
    }
}
