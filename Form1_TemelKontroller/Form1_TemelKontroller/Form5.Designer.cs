﻿
namespace Form1_TemelKontroller
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.rdbTek = new System.Windows.Forms.RadioButton();
            this.rdbCift = new System.Windows.Forms.RadioButton();
            this.lblSayi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lstTahmin = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rdbTek
            // 
            this.rdbTek.AutoSize = true;
            this.rdbTek.Location = new System.Drawing.Point(12, 326);
            this.rdbTek.Name = "rdbTek";
            this.rdbTek.Size = new System.Drawing.Size(67, 17);
            this.rdbTek.TabIndex = 0;
            this.rdbTek.TabStop = true;
            this.rdbTek.Text = "Tek Sayı";
            this.rdbTek.UseVisualStyleBackColor = true;
            // 
            // rdbCift
            // 
            this.rdbCift.AutoSize = true;
            this.rdbCift.Location = new System.Drawing.Point(12, 360);
            this.rdbCift.Name = "rdbCift";
            this.rdbCift.Size = new System.Drawing.Size(63, 17);
            this.rdbCift.TabIndex = 1;
            this.rdbCift.TabStop = true;
            this.rdbCift.Text = "Çift Sayı";
            this.rdbCift.UseVisualStyleBackColor = true;
            // 
            // lblSayi
            // 
            this.lblSayi.BackColor = System.Drawing.Color.Coral;
            this.lblSayi.Font = new System.Drawing.Font("Wide Latin", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSayi.ForeColor = System.Drawing.Color.Cyan;
            this.lblSayi.Location = new System.Drawing.Point(79, 28);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(382, 239);
            this.lblSayi.TabIndex = 2;
            this.lblSayi.Text = "100";
            this.lblSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSayi.Click += new System.EventHandler(this.lblSayi_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(79, 275);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(41, 13);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "Sonuc:";
            // 
            // lstTahmin
            // 
            this.lstTahmin.FormattingEnabled = true;
            this.lstTahmin.Location = new System.Drawing.Point(223, 275);
            this.lstTahmin.Name = "lstTahmin";
            this.lstTahmin.Size = new System.Drawing.Size(120, 147);
            this.lstTahmin.TabIndex = 4;
            this.lstTahmin.SelectedIndexChanged += new System.EventHandler(this.lstTahmin_SelectedIndexChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 482);
            this.Controls.Add(this.lstTahmin);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.rdbCift);
            this.Controls.Add(this.rdbTek);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbTek;
        private System.Windows.Forms.RadioButton rdbCift;
        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.ListBox lstTahmin;
    }
}