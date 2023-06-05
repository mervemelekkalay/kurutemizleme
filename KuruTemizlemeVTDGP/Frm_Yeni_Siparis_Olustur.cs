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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace KuruTemizlemeVTDGP
{
    public partial class Frm_Yeni_Siparis_Olustur : Form
    {
        public Frm_Yeni_Siparis_Olustur()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\merve melek\source\repos\KuruTemizlemeVTDGP\Database.mdf;Integrated Security=True");



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_MusteriOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into musteri (Ad,Soyad,Telefon,Adres) values ('" + txtbxMusteriAd.Text + "','" + txtbxMusteriSoyad.Text + "','" + txtbxMTel.Text + "','" + txtbxMAdres.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Basarılı eklendi!");
            }
            catch { }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menü frmmenü = new Menü();
            frmmenü.Show();
        }

        private void btn_SiparisOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string urunler = "";
                for (int i = 0; i < listBox1.Items.Count; i++) {
                    if (i == listBox1.Items.Count - 1) urunler += listBox1.Items[i].ToString();
                    else urunler += listBox1.Items[i].ToString() + ", ";
                }
                SqlCommand komut = new SqlCommand("insert into SiparisBilgileri values ('"+txtbxSTel.Text+"','"+urunler+"','"+dateTimePicker1.Value+"','"+dateTimePicker2.Value+"','"+"Kabul Edildi"+"','"+txbxUcret.Text+"', '"+txtbxSAdres.Text+"') ", baglanti); ;
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Sipariş Oluşturuldu");
                string query = "select Max(siparisno) from SiparisBilgileri";
                SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Siparis Numaraniz: " + dt.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }  
        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            txtbxSAdres.Clear();
            txtbxSTel.Clear();
            txbxUcret.Clear();

        }
        private int toplamFiyat=0;
        private void secGomlek_Click(object sender, EventArgs e)
        {
            int gomlekFiyat = 100;
            listBox1.Items.Add("Gömlek 100tl");
            toplamFiyat += gomlekFiyat;
            txbxUcret.Text = toplamFiyat.ToString();
        }

        private void secTakım_Click(object sender, EventArgs e)
        {
            int takimFiyat = 300;
            listBox1.Items.Add("Takım 300tl");
            toplamFiyat += takimFiyat;
            txbxUcret.Text = toplamFiyat.ToString();
        }

        private void secKaban_Click(object sender, EventArgs e)
        {
            int kabanFiyat = 450;
            listBox1.Items.Add("Kaban 450tl");
            toplamFiyat += kabanFiyat;
            txbxUcret.Text = toplamFiyat.ToString();

        }

        private void secEtek_Click(object sender, EventArgs e)
        {
            int etekFiyat = 100;
            listBox1.Items.Add("Etek 100tl");
            toplamFiyat += etekFiyat;
            txbxUcret.Text = toplamFiyat.ToString();

        }

        private void secBluz_Click(object sender, EventArgs e)
        {
            int bluzFiyat = 80;
            listBox1.Items.Add("Bluz 80 tl");
            toplamFiyat += bluzFiyat;
            txbxUcret.Text = toplamFiyat.ToString();
        }

        private void secTrenckot_Click(object sender, EventArgs e)
        {
            int trenckotFiyat = 200;
            listBox1.Items.Add("Trenkot 200tl");
            toplamFiyat += trenckotFiyat;
            txbxUcret.Text = toplamFiyat.ToString();
        }

       

        }


       
    }
    

        
    

