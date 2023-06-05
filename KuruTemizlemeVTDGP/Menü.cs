using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuruTemizlemeVTDGP
{
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }

        private void btn_Yenisiparis_Click(object sender, EventArgs e)
        {
            Frm_Yeni_Siparis_Olustur frm = new Frm_Yeni_Siparis_Olustur();
            frm.ShowDialog();
        }

        private void btn_SiparısAra_Click(object sender, EventArgs e)
        {
            Frm_Siparis_Ara frm = new Frm_Siparis_Ara();
            frm.ShowDialog();
        }

        private void btn_Mevcut_Click(object sender, EventArgs e)
        {
            Frm_Siparisler frm = new Frm_Siparisler();
            frm.ShowDialog();
        }

        private void btn_İstatistik_Click(object sender, EventArgs e)
        {
            Frm_İstatistik frm = new Frm_İstatistik();
            frm.ShowDialog();
        }

        private void btn_MenuCikis_Click(object sender, EventArgs e)
        {
            Form giris = new Form();
            giris.ShowDialog();
        }
    }
}
