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
    public partial class frmKoltukSec : Form
    {

        public frmKoltukSec()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ARA3T9F\\SQLEXPRESS;initial catalog=proje;Integrated Security=TRUE");
        int sayac = 0;
        private void frmKoltukSec_Load(object sender, EventArgs e)
        {
            BosKoltuklar();          
            OyunVeSalonGetir(cmbOyunAdi, "select*from OyunBilgileri", "OyunAdi");
            OyunVeSalonGetir(cmbSalon, "select*from SalonBilgileri", "SalonAdi");
         
        }

      
        private void OyunVeSalonGetir(ComboBox combo,string sql1,string sql2)
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

        private void YenidenRenklendirme()
        {
            foreach (Control item in pnlKoltuk.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }
        private void ComboDoluKoltuklar()
        {
            cmbKoltukIptal.Items.Clear();
            cmbKoltukIptal.Text = "";
            foreach (Control item in pnlKoltuk.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor==Color.Red)
                    {
                        cmbKoltukIptal.Items.Add(item.Text);
                    }
                }
            }
        }
        private void VeritabaniDoluKoltuklar()
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("Select*from SatisBilgileri where OyunAdi='"+cmbOyunAdi.SelectedItem+"'and SalonAdi='"+cmbSalon.SelectedItem+"'",conn);
            SqlDataReader read = komut.ExecuteReader();
            
            while (read.Read())
            {
                foreach (Control item in pnlKoltuk.Controls)
                {
                    if (item is Button)
                    {
                        if (read["KoltukNo"].ToString()==item.Text)
                        {
                            item.BackColor = Color.Red;
                        }
                        
                    }
                }
            }
            conn.Close();
        }
        private void BosKoltuklar()
        {
            sayac = 1;
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(50, 50);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(j * 60 + 30, i * 60 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (i == 4)
                    {
                        continue;
                    }
                    sayac++;
                    this.pnlKoltuk.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor==Color.White)
            {
                txtKoltukNo.Text = b.Text;
            }
        }

        tiyatroTableAdapters.SatisBilgileriTableAdapter satis = new tiyatroTableAdapters.SatisBilgileriTableAdapter();
        private void btnBiletSat_Click(object sender, EventArgs e)
        {

            if (txtKoltukNo.Text != "")
            {
                try
                {
                    satis.SatisYap(txtAd.Text, txtSoyad.Text, cmbOyunAdi.Text, cmbSalon.Text, txtKoltukNo.Text,  cmbUcret.Text, cmbTarih.Text,cmbSeans.Text);
                    MessageBox.Show("Satış Yapıldı.");
                    txtAd.Text = "";
                    txtSoyad.Text = "";
                    cmbOyunAdi.Text = "";
                    cmbSalon.Text = "";
                    cmbTarih.Text = "";
                    cmbSeans.Text = "";
                    txtKoltukNo.Text = "";
                    cmbUcret.Text = "";
                   /* cmbSeans.Items.Clear();
                    cmbTarih.Items.Clear();
                    cmbSalon.Items.Clear();*/
                    YenidenRenklendirme();
                    VeritabaniDoluKoltuklar();
                    ComboDoluKoltuklar();

                }
                catch (Exception hata)
                {
                    MessageBox.Show("HATA OLUŞTU" + hata.Message, "UYARI");
                }
            }
            else
            {
                MessageBox.Show("Koltuk Seçimi Yapmadınız.", "UYARI");
            }
        }

        private void OyunTarihiGetir()
        {
           
            cmbTarih.Text = "";
            cmbTarih.Items.Clear();
           
            conn.Open();
            SqlCommand komut = new SqlCommand("Select*from SeansBilgileri where OyunAdi='" + cmbOyunAdi.SelectedItem + "'and SalonAdi='" + cmbSalon.SelectedItem + "'", conn);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbTarih.Items.Add(read["Tarih"].ToString());
            }
            conn.Close();
        }
        private void OyunSeansiGetir()
        {
            
            conn.Open();
            SqlCommand komut = new SqlCommand("Select*from SeansBilgileri where OyunAdi='" + cmbOyunAdi.SelectedItem + "'and SalonAdi='" + cmbSalon.SelectedItem +"'", conn);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbSeans.Items.Add(read["Seans"].ToString());
            }
            conn.Close();
        }
        private void frmKoltukSec_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            this.Hide();
            anasayfa.ShowDialog();
        }

        private void cmbOyunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            YenidenRenklendirme();
            ComboDoluKoltuklar();
            
        }

        private void cmbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            OyunTarihiGetir();
        }

        private void cmbSeans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            OyunSeansiGetir();
        }

        private void cmbSeans_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            YenidenRenklendirme();
            VeritabaniDoluKoltuklar();
            ComboDoluKoltuklar();

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (cmbKoltukIptal.Text!="")
            {
                try
                {
                    satis.SatisIptal(cmbOyunAdi.Text, cmbSalon.Text, cmbTarih.Text, cmbSeans.Text, cmbKoltukIptal.Text);
                    YenidenRenklendirme();
                    VeritabaniDoluKoltuklar();
                    ComboDoluKoltuklar();
                    MessageBox.Show("Bilet İptal Edildi.");
                }
                catch (Exception hata)
                {

                    MessageBox.Show("HATA OLUŞTU" + hata.Message, "UYARI");
                }
                
            }
            else
            {
                MessageBox.Show("Koltuk seçimi yapmadınız!", "UYARI");
            }
            

        }
    }
}
