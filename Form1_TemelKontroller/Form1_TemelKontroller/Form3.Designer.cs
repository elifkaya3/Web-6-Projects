
namespace Form1_TemelKontroller
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbKadın = new System.Windows.Forms.RadioButton();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.lsvKisiler = new System.Windows.Forms.ListView();
            this.btnEkle1 = new System.Windows.Forms.Button();
            this.chdAdSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdCinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(170, 44);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cinsiyet:";
            // 
            // rdbKadın
            // 
            this.rdbKadın.AutoSize = true;
            this.rdbKadın.Location = new System.Drawing.Point(170, 81);
            this.rdbKadın.Name = "rdbKadın";
            this.rdbKadın.Size = new System.Drawing.Size(51, 17);
            this.rdbKadın.TabIndex = 3;
            this.rdbKadın.TabStop = true;
            this.rdbKadın.Text = "kadın";
            this.rdbKadın.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Location = new System.Drawing.Point(170, 104);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(52, 17);
            this.rdbErkek.TabIndex = 4;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // lsvKisiler
            // 
            this.lsvKisiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdAdSoyad,
            this.chdCinsiyet});
            this.lsvKisiler.HideSelection = false;
            this.lsvKisiler.Location = new System.Drawing.Point(306, 44);
            this.lsvKisiler.Name = "lsvKisiler";
            this.lsvKisiler.Size = new System.Drawing.Size(245, 301);
            this.lsvKisiler.TabIndex = 5;
            this.lsvKisiler.UseCompatibleStateImageBehavior = false;
            this.lsvKisiler.View = System.Windows.Forms.View.Details;
            // 
            // btnEkle1
            // 
            this.btnEkle1.Location = new System.Drawing.Point(113, 127);
            this.btnEkle1.Name = "btnEkle1";
            this.btnEkle1.Size = new System.Drawing.Size(157, 45);
            this.btnEkle1.TabIndex = 6;
            this.btnEkle1.Text = "Ekle";
            this.btnEkle1.UseVisualStyleBackColor = true;
            this.btnEkle1.Click += new System.EventHandler(this.btnEkle1_Click);
            // 
            // chdAdSoyad
            // 
            this.chdAdSoyad.Text = "AdSoyad";
            // 
            // chdCinsiyet
            // 
            this.chdCinsiyet.Text = "Cinsiyet";
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEkle1);
            this.Controls.Add(this.lsvKisiler);
            this.Controls.Add(this.rdbErkek);
            this.Controls.Add(this.rdbKadın);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbKadın;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.ListView lsvKisiler;
        private System.Windows.Forms.Button btnEkle1;
        private System.Windows.Forms.ColumnHeader chdAdSoyad;
        private System.Windows.Forms.ColumnHeader chdCinsiyet;
    }
}