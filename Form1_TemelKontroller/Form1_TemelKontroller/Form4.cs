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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int sure = 100;
        private void timer1_Tick(object sender, EventArgs e)
        {
           label1.Left  = label1.Left+1;//     
        } 
        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            lblSüre.Text = sure.ToString();
            timer2.Enabled = true;
            timer2.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {            
            sure -=1;
            lblSüre.Text = sure.ToString();
            if (sure==0)
            {
                sure = 100;
                timer2.Stop();
                btnRestart.Visible = true;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            timer2.Start();
            btnRestart.Visible = false;
            label1.Left =0;
        }
    }
}
