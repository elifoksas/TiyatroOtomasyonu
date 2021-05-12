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
    public partial class frmSatisListele : Form
    {
        public frmSatisListele()
        {
            InitializeComponent();
        }

        tiyatroTableAdapters.SatisBilgileriTableAdapter satislistesi = new tiyatroTableAdapters.SatisBilgileriTableAdapter();
        private void SatisListesi_Load(object sender, EventArgs e)
        {

            grdSatis.DataSource = satislistesi.SatisListesi2();
            int ucrettoplam = 0;
            for (int i = 0; i < grdSatis.Rows.Count; i++)
            {
                ucrettoplam += Convert.ToInt32(grdSatis.Rows[i].Cells["Ucret"].Value);

            }
            lblToplamSatis.Text = "Toplam Satış=" + ucrettoplam + " TL";
        }

        private void frmSatisListele_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            this.Hide();
            anasayfa.ShowDialog();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {

        }
    }
}
