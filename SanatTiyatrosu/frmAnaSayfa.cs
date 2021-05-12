using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanatTiyatrosu
{
    public partial class frmAnaSayfa : Form
    {
        frmSeansEkle SeansEkle = new frmSeansEkle();
        frmSalonEkle SalonEkle = new frmSalonEkle();
        frmOyunEkle OyunEkle = new frmOyunEkle();
        frmSeansListele SeansListele = new frmSeansListele();
        frmKoltukSec BiletSat = new frmKoltukSec();
        frmSatisListele SatisListele = new frmSatisListele();
            
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            SalonEkle.Show();
            this.Hide();
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            SeansEkle.Show();
            this.Hide();
        }

        private void btnOyunEkle_Click(object sender, EventArgs e)
        {
            OyunEkle.Show();
            this.Hide();
        }

        private void btnSeansListele_Click(object sender, EventArgs e)
        {
            SeansListele.Show();
            this.Hide();
        }

        private void btnBiletSat_Click(object sender, EventArgs e)
        {
            BiletSat.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 giris = new Form1();
            giris.Show();
            this.Hide();
        }

     
        

        private void frmAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btnSatislar_Click_1(object sender, EventArgs e)
        {
            SatisListele.Show();
            this.Hide();
        }
    }
}
