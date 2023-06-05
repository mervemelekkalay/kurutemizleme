namespace KuruTemizlemeVTDGP
{
    partial class Frm_Siparis_Ara
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
            this.buttonAnasayfa = new System.Windows.Forms.Button();
            this.lbl_SiparisNo = new System.Windows.Forms.Label();
            this.txt_SiparisNo = new System.Windows.Forms.TextBox();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAnasayfa
            // 
            this.buttonAnasayfa.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnasayfa.Location = new System.Drawing.Point(34, 32);
            this.buttonAnasayfa.Name = "buttonAnasayfa";
            this.buttonAnasayfa.Size = new System.Drawing.Size(125, 60);
            this.buttonAnasayfa.TabIndex = 0;
            this.buttonAnasayfa.Text = "Ana Sayfa";
            this.buttonAnasayfa.UseVisualStyleBackColor = true;
            this.buttonAnasayfa.Click += new System.EventHandler(this.buttonAnasayfa_Click);
            // 
            // lbl_SiparisNo
            // 
            this.lbl_SiparisNo.AutoSize = true;
            this.lbl_SiparisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SiparisNo.Location = new System.Drawing.Point(253, 54);
            this.lbl_SiparisNo.Name = "lbl_SiparisNo";
            this.lbl_SiparisNo.Size = new System.Drawing.Size(92, 20);
            this.lbl_SiparisNo.TabIndex = 1;
            this.lbl_SiparisNo.Text = "Sipariş No:";
            // 
            // txt_SiparisNo
            // 
            this.txt_SiparisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_SiparisNo.Location = new System.Drawing.Point(351, 51);
            this.txt_SiparisNo.Name = "txt_SiparisNo";
            this.txt_SiparisNo.Size = new System.Drawing.Size(131, 27);
            this.txt_SiparisNo.TabIndex = 2;
            this.txt_SiparisNo.TextChanged += new System.EventHandler(this.txt_SiparisNo_TextChanged);
            // 
            // btn_Ara
            // 
            this.btn_Ara.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ara.Location = new System.Drawing.Point(555, 41);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(92, 47);
            this.btn_Ara.TabIndex = 3;
            this.btn_Ara.Text = "ARA";
            this.btn_Ara.UseVisualStyleBackColor = true;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(717, 190);
            this.dataGridView1.TabIndex = 4;
            // 
            // Frm_Siparis_Ara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Ara);
            this.Controls.Add(this.txt_SiparisNo);
            this.Controls.Add(this.lbl_SiparisNo);
            this.Controls.Add(this.buttonAnasayfa);
            this.Name = "Frm_Siparis_Ara";
            this.Text = "Frm_Siparis_Ara";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnasayfa;
        private System.Windows.Forms.Label lbl_SiparisNo;
        private System.Windows.Forms.TextBox txt_SiparisNo;
        private System.Windows.Forms.Button btn_Ara;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}