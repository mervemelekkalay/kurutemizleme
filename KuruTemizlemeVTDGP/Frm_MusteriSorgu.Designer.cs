namespace KuruTemizlemeVTDGP
{
    partial class Frm_MusteriSorgu
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
            this.lbl_SiparisNo = new System.Windows.Forms.Label();
            this.txtbx_SiparisNoSorgu = new System.Windows.Forms.TextBox();
            this.btn_AnaSayfa = new System.Windows.Forms.Button();
            this.btn_Cıkıs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_SiparisNo
            // 
            this.lbl_SiparisNo.AutoSize = true;
            this.lbl_SiparisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SiparisNo.Location = new System.Drawing.Point(211, 138);
            this.lbl_SiparisNo.Name = "lbl_SiparisNo";
            this.lbl_SiparisNo.Size = new System.Drawing.Size(108, 25);
            this.lbl_SiparisNo.TabIndex = 0;
            this.lbl_SiparisNo.Text = "Sipariş No:";
            this.lbl_SiparisNo.Click += new System.EventHandler(this.lbl_SiparisNo_Click);
            // 
            // txtbx_SiparisNoSorgu
            // 
            this.txtbx_SiparisNoSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbx_SiparisNoSorgu.Location = new System.Drawing.Point(325, 139);
            this.txtbx_SiparisNoSorgu.Name = "txtbx_SiparisNoSorgu";
            this.txtbx_SiparisNoSorgu.Size = new System.Drawing.Size(139, 27);
            this.txtbx_SiparisNoSorgu.TabIndex = 1;
            // 
            // btn_AnaSayfa
            // 
            this.btn_AnaSayfa.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AnaSayfa.Location = new System.Drawing.Point(24, 42);
            this.btn_AnaSayfa.Name = "btn_AnaSayfa";
            this.btn_AnaSayfa.Size = new System.Drawing.Size(113, 38);
            this.btn_AnaSayfa.TabIndex = 2;
            this.btn_AnaSayfa.Text = "Ana Sayfa";
            this.btn_AnaSayfa.UseVisualStyleBackColor = true;
            // 
            // btn_Cıkıs
            // 
            this.btn_Cıkıs.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cıkıs.Location = new System.Drawing.Point(657, 42);
            this.btn_Cıkıs.Name = "btn_Cıkıs";
            this.btn_Cıkıs.Size = new System.Drawing.Size(96, 38);
            this.btn_Cıkıs.TabIndex = 3;
            this.btn_Cıkıs.Text = "Çıkış";
            this.btn_Cıkıs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(802, 86);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(490, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sorgula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_MusteriSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Cıkıs);
            this.Controls.Add(this.btn_AnaSayfa);
            this.Controls.Add(this.txtbx_SiparisNoSorgu);
            this.Controls.Add(this.lbl_SiparisNo);
            this.Name = "Frm_MusteriSorgu";
            this.Text = "Frm_MusteriSorgu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SiparisNo;
        private System.Windows.Forms.TextBox txtbx_SiparisNoSorgu;
        private System.Windows.Forms.Button btn_AnaSayfa;
        private System.Windows.Forms.Button btn_Cıkıs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}