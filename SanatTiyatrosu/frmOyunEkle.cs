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

namespace SanatTiyatrosu
{
    public partial class frmOyunEkle : Form
    {
        public frmOyunEkle()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ARA3T9F\\SQLEXPRESS;initial catalog=proje;Integrated Security=TRUE");
        tiyatroTableAdapters.OyunBilgileriTableAdapter oyun = new tiyatroTableAdapters.OyunBilgileriTableAdapter();

        public object OyunBilgileriTableAdapter { get; private set; }
      

        private void btnOyunuEkle_Click(object sender, EventArgs e)
        {
            oyun.OyunEkle(txtOyunAdi.Text, txtYonetmen.Text, cmbOyunTuru.Text, cmbSalon.Text,txtSure.Text, txtPerde.Text, dtpTarih.Text);

            txtOyunAdi.Text = "";
            txtYonetmen.Text = "";
            cmbSalon.Text = "";            
            txtSure.Text = "";
            txtPerde.Text = "";
            dtpTarih.Text = "";
            cmbOyunTuru.Text = "";
        }
       
        private void SalonGetir(ComboBox combo, string sql1, string sql2)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand(sql1, conn);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read[sql2].ToString());
            }
            conn.Close();
        }
        private void frmOyunEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            this.Hide();
            anasayfa.ShowDialog();
            
        }

        private void frmOyunEkle_Load(object sender, EventArgs e)
        {
            SalonGetir(cmbSalon, "Select*from SalonBilgileri", "SalonAdi");
        }

        private void cmbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
