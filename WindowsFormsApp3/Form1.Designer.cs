namespace WindowsFormsApp3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.txtSatışFiyatı = new System.Windows.Forms.TextBox();
            this.txtMiktarı = new System.Windows.Forms.TextBox();
            this.txtAçıklama = new System.Windows.Forms.TextBox();
            this.txtStokKodu = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatışİptal = new System.Windows.Forms.Button();
            this.btnSatış = new System.Windows.Forms.Button();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.frmSatis = new System.Windows.Forms.Panel();
            this.btnÜrünEkle = new System.Windows.Forms.Button();
            this.btnSatışListele = new System.Windows.Forms.Button();
            this.btnÜrünListele = new System.Windows.Forms.Button();
            this.btnMüşteriListele = new System.Windows.Forms.Button();
            this.btnMüşteriEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.frmSatis.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(753, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTelefon);
            this.groupBox2.Controls.Add(this.txtAdSoyad);
            this.groupBox2.Controls.Add(this.txtTcNo);
            this.groupBox2.Location = new System.Drawing.Point(37, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 139);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri İşlemleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tc No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(28, 91);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 9;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(28, 63);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyad.TabIndex = 6;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(28, 35);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(100, 22);
            this.txtTcNo.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtToplam);
            this.groupBox1.Controls.Add(this.txtSatışFiyatı);
            this.groupBox1.Controls.Add(this.txtMiktarı);
            this.groupBox1.Controls.Add(this.txtAçıklama);
            this.groupBox1.Controls.Add(this.txtStokKodu);
            this.groupBox1.Location = new System.Drawing.Point(36, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 174);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün İşlemleri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Toplam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Açıklama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "StokKodu";
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(28, 146);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(100, 22);
            this.txtToplam.TabIndex = 8;
            // 
            // txtSatışFiyatı
            // 
            this.txtSatışFiyatı.Location = new System.Drawing.Point(28, 118);
            this.txtSatışFiyatı.Name = "txtSatışFiyatı";
            this.txtSatışFiyatı.Size = new System.Drawing.Size(100, 22);
            this.txtSatışFiyatı.TabIndex = 7;
            // 
            // txtMiktarı
            // 
            this.txtMiktarı.Location = new System.Drawing.Point(28, 86);
            this.txtMiktarı.Name = "txtMiktarı";
            this.txtMiktarı.Size = new System.Drawing.Size(100, 22);
            this.txtMiktarı.TabIndex = 6;
            // 
            // txtAçıklama
            // 
            this.txtAçıklama.Location = new System.Drawing.Point(28, 58);
            this.txtAçıklama.Name = "txtAçıklama";
            this.txtAçıklama.Size = new System.Drawing.Size(100, 22);
            this.txtAçıklama.TabIndex = 5;
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(28, 30);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(100, 22);
            this.txtStokKodu.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(1077, 136);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1077, 229);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnSatışİptal
            // 
            this.btnSatışİptal.Location = new System.Drawing.Point(1077, 199);
            this.btnSatışİptal.Name = "btnSatışİptal";
            this.btnSatışİptal.Size = new System.Drawing.Size(75, 23);
            this.btnSatışİptal.TabIndex = 6;
            this.btnSatışİptal.Text = "Satış İptal";
            this.btnSatışİptal.UseVisualStyleBackColor = true;
            // 
            // btnSatış
            // 
            this.btnSatış.Location = new System.Drawing.Point(1077, 166);
            this.btnSatış.Name = "btnSatış";
            this.btnSatış.Size = new System.Drawing.Size(75, 23);
            this.btnSatış.TabIndex = 7;
            this.btnSatış.Text = "Satış ";
            this.btnSatış.UseVisualStyleBackColor = true;
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(642, 174);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(0, 16);
            this.lblGenelToplam.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(924, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Genel Toplam";
            // 
            // frmSatis
            // 
            this.frmSatis.Controls.Add(this.btnÜrünEkle);
            this.frmSatis.Controls.Add(this.btnSatışListele);
            this.frmSatis.Controls.Add(this.btnÜrünListele);
            this.frmSatis.Controls.Add(this.btnMüşteriListele);
            this.frmSatis.Controls.Add(this.btnMüşteriEkle);
            this.frmSatis.Dock = System.Windows.Forms.DockStyle.Top;
            this.frmSatis.Location = new System.Drawing.Point(0, 0);
            this.frmSatis.Name = "frmSatis";
            this.frmSatis.Size = new System.Drawing.Size(1160, 100);
            this.frmSatis.TabIndex = 10;
            // 
            // btnÜrünEkle
            // 
            this.btnÜrünEkle.Location = new System.Drawing.Point(555, 23);
            this.btnÜrünEkle.Name = "btnÜrünEkle";
            this.btnÜrünEkle.Size = new System.Drawing.Size(153, 48);
            this.btnÜrünEkle.TabIndex = 3;
            this.btnÜrünEkle.Text = "Ürün Ekle";
            this.btnÜrünEkle.UseVisualStyleBackColor = true;
            this.btnÜrünEkle.Click += new System.EventHandler(this.btnÜrünEkle_Click);
            // 
            // btnSatışListele
            // 
            this.btnSatışListele.Location = new System.Drawing.Point(920, 23);
            this.btnSatışListele.Name = "btnSatışListele";
            this.btnSatışListele.Size = new System.Drawing.Size(190, 48);
            this.btnSatışListele.TabIndex = 2;
            this.btnSatışListele.Text = "Satış Listele";
            this.btnSatışListele.UseVisualStyleBackColor = true;
            // 
            // btnÜrünListele
            // 
            this.btnÜrünListele.Location = new System.Drawing.Point(714, 23);
            this.btnÜrünListele.Name = "btnÜrünListele";
            this.btnÜrünListele.Size = new System.Drawing.Size(173, 48);
            this.btnÜrünListele.TabIndex = 1;
            this.btnÜrünListele.Text = "Ürün Listele";
            this.btnÜrünListele.UseVisualStyleBackColor = true;
            // 
            // btnMüşteriListele
            // 
            this.btnMüşteriListele.Location = new System.Drawing.Point(273, 23);
            this.btnMüşteriListele.Name = "btnMüşteriListele";
            this.btnMüşteriListele.Size = new System.Drawing.Size(149, 48);
            this.btnMüşteriListele.TabIndex = 4;
            this.btnMüşteriListele.Text = "Müşteri Listele";
            this.btnMüşteriListele.UseVisualStyleBackColor = true;
            this.btnMüşteriListele.Click += new System.EventHandler(this.btnMüşteriListele_Click);
            // 
            // btnMüşteriEkle
            // 
            this.btnMüşteriEkle.Location = new System.Drawing.Point(105, 23);
            this.btnMüşteriEkle.Name = "btnMüşteriEkle";
            this.btnMüşteriEkle.Size = new System.Drawing.Size(162, 48);
            this.btnMüşteriEkle.TabIndex = 0;
            this.btnMüşteriEkle.Text = "Müşteri Ekle";
            this.btnMüşteriEkle.UseVisualStyleBackColor = true;
            this.btnMüşteriEkle.Click += new System.EventHandler(this.btnMüşteriEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1160, 506);
            this.Controls.Add(this.frmSatis);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.btnSatış);
            this.Controls.Add(this.btnSatışİptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takip";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.frmSatis.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.TextBox txtSatışFiyatı;
        private System.Windows.Forms.TextBox txtMiktarı;
        private System.Windows.Forms.TextBox txtAçıklama;
        private System.Windows.Forms.TextBox txtStokKodu;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatışİptal;
        private System.Windows.Forms.Button btnSatış;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel frmSatis;
        private System.Windows.Forms.Button btnMüşteriListele;
        private System.Windows.Forms.Button btnÜrünEkle;
        private System.Windows.Forms.Button btnSatışListele;
        private System.Windows.Forms.Button btnÜrünListele;
        private System.Windows.Forms.Button btnMüşteriEkle;
    }
}

