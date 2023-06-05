namespace KuruTemizlemeVTDGP
{
    partial class Frm_Siparisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Siparisler));
            this.AnaSayfa = new System.Windows.Forms.Button();
            this.grpbx_Siparisbilgi = new System.Windows.Forms.GroupBox();
            this.btn_S_İptal = new System.Windows.Forms.Button();
            this.btn_SGuncelle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtbx_MusteriTel = new System.Windows.Forms.TextBox();
            this.txtbx_SiparisNo = new System.Windows.Forms.TextBox();
            this.lbl_Ucret = new System.Windows.Forms.Label();
            this.lbl_SiparisDurmu = new System.Windows.Forms.Label();
            this.lbl_MusteriTel = new System.Windows.Forms.Label();
            this.lbl_Siparisno = new System.Windows.Forms.Label();
            this.btnVeriGöster = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpbx_Siparisbilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AnaSayfa
            // 
            resources.ApplyResources(this.AnaSayfa, "AnaSayfa");
            this.AnaSayfa.Name = "AnaSayfa";
            this.AnaSayfa.UseVisualStyleBackColor = true;
            this.AnaSayfa.Click += new System.EventHandler(this.AnaSayfa_Click);
            // 
            // grpbx_Siparisbilgi
            // 
            resources.ApplyResources(this.grpbx_Siparisbilgi, "grpbx_Siparisbilgi");
            this.grpbx_Siparisbilgi.Controls.Add(this.btn_S_İptal);
            this.grpbx_Siparisbilgi.Controls.Add(this.btn_SGuncelle);
            this.grpbx_Siparisbilgi.Controls.Add(this.textBox1);
            this.grpbx_Siparisbilgi.Controls.Add(this.comboBox1);
            this.grpbx_Siparisbilgi.Controls.Add(this.txtbx_MusteriTel);
            this.grpbx_Siparisbilgi.Controls.Add(this.txtbx_SiparisNo);
            this.grpbx_Siparisbilgi.Controls.Add(this.lbl_Ucret);
            this.grpbx_Siparisbilgi.Controls.Add(this.lbl_SiparisDurmu);
            this.grpbx_Siparisbilgi.Controls.Add(this.lbl_MusteriTel);
            this.grpbx_Siparisbilgi.Controls.Add(this.lbl_Siparisno);
            this.grpbx_Siparisbilgi.Name = "grpbx_Siparisbilgi";
            this.grpbx_Siparisbilgi.TabStop = false;
            // 
            // btn_S_İptal
            // 
            resources.ApplyResources(this.btn_S_İptal, "btn_S_İptal");
            this.btn_S_İptal.Name = "btn_S_İptal";
            this.btn_S_İptal.UseVisualStyleBackColor = true;
            // 
            // btn_SGuncelle
            // 
            resources.ApplyResources(this.btn_SGuncelle, "btn_SGuncelle");
            this.btn_SGuncelle.Name = "btn_SGuncelle";
            this.btn_SGuncelle.UseVisualStyleBackColor = true;
            this.btn_SGuncelle.Click += new System.EventHandler(this.btn_SGuncelle_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3")});
            this.comboBox1.Name = "comboBox1";
            // 
            // txtbx_MusteriTel
            // 
            resources.ApplyResources(this.txtbx_MusteriTel, "txtbx_MusteriTel");
            this.txtbx_MusteriTel.Name = "txtbx_MusteriTel";
            // 
            // txtbx_SiparisNo
            // 
            resources.ApplyResources(this.txtbx_SiparisNo, "txtbx_SiparisNo");
            this.txtbx_SiparisNo.Name = "txtbx_SiparisNo";
            this.txtbx_SiparisNo.TextChanged += new System.EventHandler(this.txtbx_SiparisNo_TextChanged);
            // 
            // lbl_Ucret
            // 
            resources.ApplyResources(this.lbl_Ucret, "lbl_Ucret");
            this.lbl_Ucret.Name = "lbl_Ucret";
            // 
            // lbl_SiparisDurmu
            // 
            resources.ApplyResources(this.lbl_SiparisDurmu, "lbl_SiparisDurmu");
            this.lbl_SiparisDurmu.Name = "lbl_SiparisDurmu";
            // 
            // lbl_MusteriTel
            // 
            resources.ApplyResources(this.lbl_MusteriTel, "lbl_MusteriTel");
            this.lbl_MusteriTel.Name = "lbl_MusteriTel";
            // 
            // lbl_Siparisno
            // 
            resources.ApplyResources(this.lbl_Siparisno, "lbl_Siparisno");
            this.lbl_Siparisno.Name = "lbl_Siparisno";
            // 
            // btnVeriGöster
            // 
            resources.ApplyResources(this.btnVeriGöster, "btnVeriGöster");
            this.btnVeriGöster.Name = "btnVeriGöster";
            this.btnVeriGöster.UseVisualStyleBackColor = true;
            this.btnVeriGöster.Click += new System.EventHandler(this.btnVeriGöster_Click_1);
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Frm_Siparisler
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVeriGöster);
            this.Controls.Add(this.grpbx_Siparisbilgi);
            this.Controls.Add(this.AnaSayfa);
            this.Name = "Frm_Siparisler";
            this.grpbx_Siparisbilgi.ResumeLayout(false);
            this.grpbx_Siparisbilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AnaSayfa;
        private System.Windows.Forms.GroupBox grpbx_Siparisbilgi;
        private System.Windows.Forms.Button btn_S_İptal;
        private System.Windows.Forms.Button btn_SGuncelle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtbx_MusteriTel;
        private System.Windows.Forms.TextBox txtbx_SiparisNo;
        private System.Windows.Forms.Label lbl_Ucret;
        private System.Windows.Forms.Label lbl_SiparisDurmu;
        private System.Windows.Forms.Label lbl_MusteriTel;
        private System.Windows.Forms.Label lbl_Siparisno;
        private System.Windows.Forms.Button btnVeriGöster;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}