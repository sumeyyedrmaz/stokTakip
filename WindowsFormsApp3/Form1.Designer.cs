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
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.btnÜrünEkle = new System.Windows.Forms.Button();
            this.btnÜrünListele = new System.Windows.Forms.Button();
            this.btnMüşteriListele = new System.Windows.Forms.Button();
            this.btnMüşteriEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(596, 154);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(0, 16);
            this.lblGenelToplam.TabIndex = 8;
            // 
            // btnÜrünEkle
            // 
            this.btnÜrünEkle.Location = new System.Drawing.Point(145, 249);
            this.btnÜrünEkle.Name = "btnÜrünEkle";
            this.btnÜrünEkle.Size = new System.Drawing.Size(203, 88);
            this.btnÜrünEkle.TabIndex = 3;
            this.btnÜrünEkle.Text = "Ürün Ekle";
            this.btnÜrünEkle.UseVisualStyleBackColor = true;
            this.btnÜrünEkle.Click += new System.EventHandler(this.btnÜrünEkle_Click);
            // 
            // btnÜrünListele
            // 
            this.btnÜrünListele.Location = new System.Drawing.Point(397, 250);
            this.btnÜrünListele.Name = "btnÜrünListele";
            this.btnÜrünListele.Size = new System.Drawing.Size(228, 87);
            this.btnÜrünListele.TabIndex = 1;
            this.btnÜrünListele.Text = "Ürün Listele";
            this.btnÜrünListele.UseVisualStyleBackColor = true;
            this.btnÜrünListele.Click += new System.EventHandler(this.btnÜrünListele_Click);
            // 
            // btnMüşteriListele
            // 
            this.btnMüşteriListele.Location = new System.Drawing.Point(406, 105);
            this.btnMüşteriListele.Name = "btnMüşteriListele";
            this.btnMüşteriListele.Size = new System.Drawing.Size(228, 83);
            this.btnMüşteriListele.TabIndex = 4;
            this.btnMüşteriListele.Text = "Müşteri Listele";
            this.btnMüşteriListele.UseVisualStyleBackColor = true;
            this.btnMüşteriListele.Click += new System.EventHandler(this.btnMüşteriListele_Click);
            // 
            // btnMüşteriEkle
            // 
            this.btnMüşteriEkle.Location = new System.Drawing.Point(147, 105);
            this.btnMüşteriEkle.Name = "btnMüşteriEkle";
            this.btnMüşteriEkle.Size = new System.Drawing.Size(201, 83);
            this.btnMüşteriEkle.TabIndex = 0;
            this.btnMüşteriEkle.Text = "Müşteri Ekle";
            this.btnMüşteriEkle.UseVisualStyleBackColor = true;
            this.btnMüşteriEkle.Click += new System.EventHandler(this.btnMüşteriEkle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(714, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 88);
            this.button1.TabIndex = 5;
            this.button1.Text = "Marka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(714, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 83);
            this.button2.TabIndex = 6;
            this.button2.Text = "Kategori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1055, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.btnÜrünListele);
            this.Controls.Add(this.btnÜrünEkle);
            this.Controls.Add(this.btnMüşteriEkle);
            this.Controls.Add(this.btnMüşteriListele);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takip";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Button btnMüşteriListele;
        private System.Windows.Forms.Button btnÜrünEkle;
        private System.Windows.Forms.Button btnÜrünListele;
        private System.Windows.Forms.Button btnMüşteriEkle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

