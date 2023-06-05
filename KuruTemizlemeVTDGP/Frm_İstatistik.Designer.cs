namespace KuruTemizlemeVTDGP
{
    partial class Frm_İstatistik
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
            this.btn_Anasayfa = new System.Windows.Forms.Button();
            this.lbl_Kazanc = new System.Windows.Forms.Label();
            this.lbl_TopMusteri = new System.Windows.Forms.Label();
            this.lbl_OrtKazanc = new System.Windows.Forms.Label();
            this.txtbx_KazancMiktarı = new System.Windows.Forms.TextBox();
            this.txtbx_TopMusteri = new System.Windows.Forms.TextBox();
            this.txtbx_OrtKazanc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Anasayfa
            // 
            this.btn_Anasayfa.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Anasayfa.Location = new System.Drawing.Point(23, 24);
            this.btn_Anasayfa.Name = "btn_Anasayfa";
            this.btn_Anasayfa.Size = new System.Drawing.Size(124, 40);
            this.btn_Anasayfa.TabIndex = 0;
            this.btn_Anasayfa.Text = "Ana Sayfa";
            this.btn_Anasayfa.UseVisualStyleBackColor = true;
            // 
            // lbl_Kazanc
            // 
            this.lbl_Kazanc.AutoSize = true;
            this.lbl_Kazanc.Location = new System.Drawing.Point(229, 91);
            this.lbl_Kazanc.Name = "lbl_Kazanc";
            this.lbl_Kazanc.Size = new System.Drawing.Size(107, 16);
            this.lbl_Kazanc.TabIndex = 1;
            this.lbl_Kazanc.Text = "Kazanılan Miktar:";
            // 
            // lbl_TopMusteri
            // 
            this.lbl_TopMusteri.AutoSize = true;
            this.lbl_TopMusteri.Location = new System.Drawing.Point(233, 144);
            this.lbl_TopMusteri.Name = "lbl_TopMusteri";
            this.lbl_TopMusteri.Size = new System.Drawing.Size(103, 16);
            this.lbl_TopMusteri.TabIndex = 2;
            this.lbl_TopMusteri.Text = "Toplam Müşteri:";
            // 
            // lbl_OrtKazanc
            // 
            this.lbl_OrtKazanc.AutoSize = true;
            this.lbl_OrtKazanc.Location = new System.Drawing.Point(224, 188);
            this.lbl_OrtKazanc.Name = "lbl_OrtKazanc";
            this.lbl_OrtKazanc.Size = new System.Drawing.Size(112, 16);
            this.lbl_OrtKazanc.TabIndex = 3;
            this.lbl_OrtKazanc.Text = "Ortalama Kazanç:";
            // 
            // txtbx_KazancMiktarı
            // 
            this.txtbx_KazancMiktarı.Location = new System.Drawing.Point(342, 88);
            this.txtbx_KazancMiktarı.Name = "txtbx_KazancMiktarı";
            this.txtbx_KazancMiktarı.Size = new System.Drawing.Size(100, 22);
            this.txtbx_KazancMiktarı.TabIndex = 4;
            // 
            // txtbx_TopMusteri
            // 
            this.txtbx_TopMusteri.Location = new System.Drawing.Point(342, 138);
            this.txtbx_TopMusteri.Name = "txtbx_TopMusteri";
            this.txtbx_TopMusteri.Size = new System.Drawing.Size(100, 22);
            this.txtbx_TopMusteri.TabIndex = 5;
            // 
            // txtbx_OrtKazanc
            // 
            this.txtbx_OrtKazanc.Location = new System.Drawing.Point(342, 182);
            this.txtbx_OrtKazanc.Name = "txtbx_OrtKazanc";
            this.txtbx_OrtKazanc.Size = new System.Drawing.Size(100, 22);
            this.txtbx_OrtKazanc.TabIndex = 6;
            // 
            // Frm_İstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbx_OrtKazanc);
            this.Controls.Add(this.txtbx_TopMusteri);
            this.Controls.Add(this.txtbx_KazancMiktarı);
            this.Controls.Add(this.lbl_OrtKazanc);
            this.Controls.Add(this.lbl_TopMusteri);
            this.Controls.Add(this.lbl_Kazanc);
            this.Controls.Add(this.btn_Anasayfa);
            this.Name = "Frm_İstatistik";
            this.Text = "Frm_İstatistik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Anasayfa;
        private System.Windows.Forms.Label lbl_Kazanc;
        private System.Windows.Forms.Label lbl_TopMusteri;
        private System.Windows.Forms.Label lbl_OrtKazanc;
        private System.Windows.Forms.TextBox txtbx_KazancMiktarı;
        private System.Windows.Forms.TextBox txtbx_TopMusteri;
        private System.Windows.Forms.TextBox txtbx_OrtKazanc;
    }
}