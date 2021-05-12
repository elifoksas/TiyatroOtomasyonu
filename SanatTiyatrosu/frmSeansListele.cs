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
    public partial class frmSeansListele : Form
    {
        public frmSeansListele()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ARA3T9F\\SQLEXPRESS;initial catalog=proje;Integrated Security=TRUE");
        DataTable tablo = new DataTable();
         private void SeansListesi(string sql)
        {
            conn.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, conn);
            adtr.Fill(tablo);
            grdSeans.DataSource = tablo;
            conn.Close();

        }
        private void frmSeansListele_Load(object sender, EventArgs e)
        {
            tablo.Clear();
                        
        }

        private void frmSeansListele_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            this.Hide();
            anasayfa.ShowDialog();
        }
       
        private void btnListele_Click(object sender, EventArgs e)
        {

            tablo.Clear();
            SeansListesi("select*from SeansBilgileri");
        }
    }
}
