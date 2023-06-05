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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Data.Sql;
using System.Data.SqlClient;

namespace KuruTemizlemeVTDGP
{
    public partial class Frm_MusteriSorgu : Form
    {
        public Frm_MusteriSorgu()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\merve melek\source\repos\KuruTemizlemeVTDGP\Database.mdf;Integrated Security=True");

        private void lbl_SiparisNo_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select siparisdurum from SiparisBilgileri where siparisno = '" + txtbx_SiparisNoSorgu.Text + "'", baglanti);
                if (cmd.ExecuteScalar() != null) label1.Text = "Siparis No " + txtbx_SiparisNoSorgu.Text+" :" + cmd.ExecuteScalar().ToString();
                else label1.Text = "Bilgi Bulunmamaktadir";
                baglanti.Close();
            }
            catch (Exception ex) {
            }
        }
    }
}
