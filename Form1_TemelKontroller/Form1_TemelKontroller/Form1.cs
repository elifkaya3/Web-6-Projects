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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSayi_TextChanged(object sender, EventArgs e)
        {
            /* lblSayi.Text = txtSayi.Text;*/
        }

        private void txtSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* if (e.KeyChar.ToString()=="A")
             {
                 MessageBox.Show("Büyük A harfine bastın.");

             }
             else
             {
                 MessageBox.Show("olmadı yar");
             }*/

            /* if (char.IsDigit(e.KeyChar))
             {
                 MessageBox.Show("Evet,Bir Rakam Yazdınız");
             }
             else
             {
                 MessageBox.Show("HAyır Rakam Dışında Bir şey YAzdınız");
             }*/

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))//back=sil tuşu olarak kullanabilirsin.Sayıları yazar//
            {
                e.Handled = true;

            }
        }

        private void txtHarf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  Isletter ise harf olup olmadığını denetler
            //if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            //{
            //    e.Handled = true;
            //}
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        private void txtBuyuk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsUpper(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);//Büyük harf için IsUpper//Küçük harf için IsLower

        }

        void Doldur()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Mobil Programlama");
            comboBox1.Items.Add("Web Programlama");
            comboBox1.Items.Add("Desktop Programlama");
            comboBox1.Items.Add("Oyun Programlama");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbEvet.Checked = true;
            Doldur();
            Doldur2();
        }
        void Doldur2()
        {
            string[] iller = { "İstanbul","Bursa","Ankara","İzmir" };
            comboBox2.Items.AddRange(iller);
        }

        private void rdbEvet_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(rdbEvet.Checked.ToString());
        }
        void KontrolEt()
        {
            if (rdbEvet.Checked)
            {
                lblSayi.Text = "Demek evet diyorsun buna çok sevindim";
            }
            else
            {
                lblSayi.Text = "hayır diyorsun aaa çok üzüldüm";
            }

        }
        private void rdbEvet_Click(object sender, EventArgs e)
        {
            KontrolEt();
        }

        private void rdbHayır_Click(object sender, EventArgs e)
        {
            KontrolEt();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox2.Text);
        }

       

        private void btnForm2_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
