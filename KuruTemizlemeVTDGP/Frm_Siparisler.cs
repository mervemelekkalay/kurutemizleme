using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;



namespace KuruTemizlemeVTDGP
{
    public partial class Frm_Siparisler : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader read;

        public Frm_Siparisler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\merve melek\source\repos\KuruTemizlemeVTDGP\Database.mdf;Integrated Security=True");
        //static SqlDataReader dr;
        private void verilerigöster()
        {
            baglanti.Open();
            string query = "select * from SiparisBilgileri";
            /* SqlCommand komut = new SqlCommand("select * from SiparisBilgileri", baglanti);
             SqlDataReader oku = cmd.ExecuteReader();*/
            SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            
        }

        private void btnVeriGöster_Click_1(object sender, EventArgs e)
        {
            verilerigöster();
        }

        private void AnaSayfa_Click(object sender, EventArgs e)
        {
            Menü menu = new Menü();
            menu.ShowDialog();
        }
       
        private void btn_SGuncelle_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update SiparisBilgileri where siparisno siparisno set  iletisim=@a2, siparisdurum=@a6, ucret=@a7",baglanti);
          
            komut.Parameters.AddWithValue("@a2", txtbx_MusteriTel.Text);
           
            komut.Parameters.AddWithValue("@a6", comboBox1.Text);
            komut.Parameters.AddWithValue("@a7", textBox1.Text);
            
            
           //dr = komutgun.ExecuteNonQuery();
            //dr.read();

            //komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("bilgiler güncellendi..");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.SelectionChanged += DataGridView_SelectionChanged;
            //int seçilialan  = dataGridView1.SelectedCells[0].RowIndex;
            txtbx_SiparisNo.Text = dataGridView1.CurrentRow.Cells["siparisno"].Value.ToString();
        }

       
        private void txtbx_SiparisNo_TextChanged(object sender, EventArgs e)
        {
          /* baglanti.Open();
            SqlCommand komut = new SqlCommand(" SELECT * FROM SipairsiBilgileri where siparisno =(" + txtbx_SiparisNo.Text + ")", baglanti);
            SqlDataReader read = komut.ExecuteReader();

           
            {
                while (read.Read())
                {
                    txtbx_MusteriTel.Text = read["iletisim"].ToString();
                    textBox1.Text = read["ucret"].ToString();
                }
            }

            /*SqlCommand komut = new SqlCommand( "select * from SipairsiBilgileri where = 'siparisno'"+txtbx_SiparisNo.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            if (read != null)

            while(read.Read())
            {
             txtbx_MusteriTel.Text = read["iletisim"].ToString();
             textBox1.Text = read["ucret"].ToString();
            }
           */


            
             
        }

       
    }

    }