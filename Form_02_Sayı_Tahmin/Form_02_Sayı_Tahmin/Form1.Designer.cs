
namespace Form_02_Sayı_Tahmin
{
    partial class Form1
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
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.lblTahminler = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblHile = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblHak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(280, 155);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(156, 20);
            this.txtTahmin.TabIndex = 0;
            this.txtTahmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTahmin_KeyDown);
            // 
            // lblTahminler
            // 
            this.lblTahminler.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTahminler.Location = new System.Drawing.Point(279, 125);
            this.lblTahminler.Name = "lblTahminler";
            this.lblTahminler.Size = new System.Drawing.Size(157, 27);
            this.lblTahminler.TabIndex = 1;
            this.lblTahminler.Text = "Tahmininizi Giriniz";
            this.lblTahminler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBaslat.Location = new System.Drawing.Point(267, 77);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(183, 45);
            this.btnBaslat.TabIndex = 2;
            this.btnBaslat.Text = "BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTahminEt.Location = new System.Drawing.Point(307, 190);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(107, 42);
            this.btnTahminEt.TabIndex = 3;
            this.btnTahminEt.Text = "Tahmin Et";
            this.btnTahminEt.UseVisualStyleBackColor = true;
            // 
            // lblMesaj
            // 
            this.lblMesaj.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblMesaj.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.Color.Red;
            this.lblMesaj.Location = new System.Drawing.Point(202, 235);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(321, 37);
            this.lblMesaj.TabIndex = 5;
            this.lblMesaj.Text = "Oyunu başlatmak için BAŞLAT butonuna tıkla";
            this.lblMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHile
            // 
            this.lblHile.AutoSize = true;
            this.lblHile.Location = new System.Drawing.Point(668, 343);
            this.lblHile.Name = "lblHile";
            this.lblHile.Size = new System.Drawing.Size(34, 13);
            this.lblHile.TabIndex = 6;
            this.lblHile.Text = "HİLE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(580, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "puanınız:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(618, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "hak:";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPuan.Location = new System.Drawing.Point(667, 70);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(29, 20);
            this.lblPuan.TabIndex = 9;
            this.lblPuan.Text = "50";
            // 
            // lblHak
            // 
            this.lblHak.AutoSize = true;
            this.lblHak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHak.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHak.Location = new System.Drawing.Point(667, 90);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(19, 20);
            this.lblHak.TabIndex = 10;
            this.lblHak.Text = "5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(733, 365);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHile);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnTahminEt);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.lblTahminler);
            this.Controls.Add(this.txtTahmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Label lblTahminler;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnTahminEt;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblHile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblHak;
    }
}

