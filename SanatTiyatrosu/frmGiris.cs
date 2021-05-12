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


namespace SanatTiyatrosu
{
    public partial class Form1 : Form
    {
        frmAnaSayfa frmAnasayfa=new frmAnaSayfa();

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ARA3T9F\\SQLEXPRESS;initial catalog=proje;Integrated Security=TRUE");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string k_adi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            bool kayitli_mi = false;
            conn.Open();
           
            SqlCommand cmd = new SqlCommand("Select * from Giris",conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (k_adi == dr["KullaniciAdi"].ToString() && sifre == dr["Sifre"].ToString())
                {
                    kayitli_mi = true;
                    break;
                }
                else kayitli_mi = false;

            }
            conn.Close();
            if (kayitli_mi == true)
            {
                frmAnasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
