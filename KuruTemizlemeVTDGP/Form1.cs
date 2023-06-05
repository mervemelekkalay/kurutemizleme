using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KuruTemizlemeVTDGP
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\merve melek\source\repos\KuruTemizlemeVTDGP\Database.mdf;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string loginquery = "select * from AdminGiris where KullaniciAdi = '" + txtbxKullAdi.Text + "' and Sifre = '" + txtbxSifre.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(loginquery, baglanti);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                baglanti.Close();

                if (dt.Rows.Count > 0)
                {
                    Menü fr = new Menü();
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş");
                }

            }
            catch { }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbxKullAdi.Clear(); txtbxSifre.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_MusteriSorgu MusteriSorgu = new Frm_MusteriSorgu();
            MusteriSorgu.ShowDialog();
        }
    }
}
