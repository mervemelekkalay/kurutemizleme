namespace KuruTemizlemeVTDGP
{
    partial class Menü
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
            this.btn_Yenisiparis = new System.Windows.Forms.Button();
            this.btn_Mevcut = new System.Windows.Forms.Button();
            this.btn_SiparısAra = new System.Windows.Forms.Button();
            this.btn_İstatistik = new System.Windows.Forms.Button();
            this.btn_MenuCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Yenisiparis
            // 
            this.btn_Yenisiparis.BackColor = System.Drawing.Color.Olive;
            this.btn_Yenisiparis.Location = new System.Drawing.Point(46, 153);
            this.btn_Yenisiparis.Name = "btn_Yenisiparis";
            this.btn_Yenisiparis.Size = new System.Drawing.Size(110, 54);
            this.btn_Yenisiparis.TabIndex = 0;
            this.btn_Yenisiparis.Text = "Yeni Sipariş";
            this.btn_Yenisiparis.UseVisualStyleBackColor = false;
            this.btn_Yenisiparis.Click += new System.EventHandler(this.btn_Yenisiparis_Click);
            // 
            // btn_Mevcut
            // 
            this.btn_Mevcut.BackColor = System.Drawing.Color.Olive;
            this.btn_Mevcut.Location = new System.Drawing.Point(210, 153);
            this.btn_Mevcut.Name = "btn_Mevcut";
            this.btn_Mevcut.Size = new System.Drawing.Size(110, 54);
            this.btn_Mevcut.TabIndex = 1;
            this.btn_Mevcut.Text = "Mevcut Siparişler";
            this.btn_Mevcut.UseVisualStyleBackColor = false;
            this.btn_Mevcut.Click += new System.EventHandler(this.btn_Mevcut_Click);
            // 
            // btn_SiparısAra
            // 
            this.btn_SiparısAra.BackColor = System.Drawing.Color.Olive;
            this.btn_SiparısAra.Location = new System.Drawing.Point(382, 153);
            this.btn_SiparısAra.Name = "btn_SiparısAra";
            this.btn_SiparısAra.Size = new System.Drawing.Size(110, 54);
            this.btn_SiparısAra.TabIndex = 2;
            this.btn_SiparısAra.Text = "Sipariş Ara";
            this.btn_SiparısAra.UseVisualStyleBackColor = false;
            this.btn_SiparısAra.Click += new System.EventHandler(this.btn_SiparısAra_Click);
            // 
            // btn_İstatistik
            // 
            this.btn_İstatistik.BackColor = System.Drawing.Color.Olive;
            this.btn_İstatistik.Location = new System.Drawing.Point(548, 153);
            this.btn_İstatistik.Name = "btn_İstatistik";
            this.btn_İstatistik.Size = new System.Drawing.Size(110, 54);
            this.btn_İstatistik.TabIndex = 3;
            this.btn_İstatistik.Text = "İstatistik";
            this.btn_İstatistik.UseVisualStyleBackColor = false;
            this.btn_İstatistik.Click += new System.EventHandler(this.btn_İstatistik_Click);
            // 
            // btn_MenuCikis
            // 
            this.btn_MenuCikis.Location = new System.Drawing.Point(623, 30);
            this.btn_MenuCikis.Name = "btn_MenuCikis";
            this.btn_MenuCikis.Size = new System.Drawing.Size(84, 52);
            this.btn_MenuCikis.TabIndex = 4;
            this.btn_MenuCikis.Text = "ÇIKIŞ";
            this.btn_MenuCikis.UseVisualStyleBackColor = true;
            this.btn_MenuCikis.Click += new System.EventHandler(this.btn_MenuCikis_Click);
            // 
            // Menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(732, 357);
            this.Controls.Add(this.btn_MenuCikis);
            this.Controls.Add(this.btn_İstatistik);
            this.Controls.Add(this.btn_SiparısAra);
            this.Controls.Add(this.btn_Mevcut);
            this.Controls.Add(this.btn_Yenisiparis);
            this.Name = "Menü";
            this.Text = "Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Yenisiparis;
        private System.Windows.Forms.Button btn_Mevcut;
        private System.Windows.Forms.Button btn_SiparısAra;
        private System.Windows.Forms.Button btn_İstatistik;
        private System.Windows.Forms.Button btn_MenuCikis;
    }
}