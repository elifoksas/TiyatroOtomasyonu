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
    public partial class frmSeansEkle : Form
    {
        public frmSeansEkle()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ARA3T9F\\SQLEXPRESS;initial catalog=proje;Integrated Security=TRUE");
        tiyatroTableAdapters.SeansBilgileriTableAdapter oyunseans = new tiyatroTableAdapters.SeansBilgileriTableAdapter();

        private void frmSeansEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            this.Hide();
            anasayfa.ShowDialog();
        }

       
        private void btnEkle_Click(object sender, EventArgs e)
        {
            oyunseans.SeansEkleme(cmbOyun.Text, cmbSalon.Text, dateTarih.Text, timeSeans.Text);
            MessageBox.Show("Seans Eklendi.", "Kayıt");

            cmbOyun.Text = "";
            cmbSalon.Text = "";
            dateTarih.Text = DateTime.Now.ToShortTimeString();
        }

        private void OyunveSalonGoster(ComboBox combo,string sql,string sql2)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand(sql, conn);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()==true)
            {
                combo.Items.Add(read[sql2].ToString());
            }
            conn.Close();
        }

        private void frmSeansEkle_Load(object sender, EventArgs e)
        {
            
            OyunveSalonGoster(cmbOyun, "select*from OyunBilgileri", "OyunAdi");
            OyunveSalonGoster(cmbSalon, "select*from SalonBilgileri", "SalonAdi");
        }

       
    }
}
