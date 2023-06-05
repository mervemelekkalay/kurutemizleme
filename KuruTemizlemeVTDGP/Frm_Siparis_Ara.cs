using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace KuruTemizlemeVTDGP
{
    public partial class Frm_Siparis_Ara : Form
    {
        public Frm_Siparis_Ara()
        {
            InitializeComponent();
        }

      
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\merve melek\source\repos\KuruTemizlemeVTDGP\Database.mdf;Integrated Security=True");
        private void txt_SiparisNo_TextChanged(object sender, EventArgs e)
        {
            try {
                DataTable dt = new DataTable();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from SiparisBilgileri where siparisno='" + Convert.ToInt32(txt_SiparisNo.Text) + "'", baglanti);
                adtr.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch { }
        }

        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
            Menü menu = new Menü();
            menu.ShowDialog();

        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from SiparisBilgileri where siparisno='" + Convert.ToInt32(txt_SiparisNo.Text) + "'", baglanti);
                adtr.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch { }
        }
    }
  
}
