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
    public partial class frmSalonEkle : Form
    {
        public frmSalonEkle()
        {
            InitializeComponent();
        }                   
        private void frmSalonEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            this.Hide();
            anasayfa.ShowDialog();
        }

        tiyatroTableAdapters.SalonBilgileriTableAdapter salon = new tiyatroTableAdapters.SalonBilgileriTableAdapter();

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
             try
            {
                salon.SalonEkle(txtSalonAdi.Text);
                MessageBox.Show("Salon Eklendi","Kayıt");
            }
            catch (SqlException)
            {

                MessageBox.Show("Aynı Salon Daha Önce Eklendi!", "UYARI");

            }
            txtSalonAdi.Text = "";
        }

        
    }
}
