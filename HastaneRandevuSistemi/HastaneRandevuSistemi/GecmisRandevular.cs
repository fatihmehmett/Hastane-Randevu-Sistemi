using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HastaneRandevuSistemi
{
    public partial class GecmisRandevular : Form
    {
        public GecmisRandevular()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=VeriTabaniTez.accdb");


        void Randevularıgoster()
        {
            baglanti.Open();
            OleDbDataAdapter db = new OleDbDataAdapter("select*from Randevular where HastaTc='" + AnaGirisSayfasi.GidenTcBilgi.ToString() + "'", baglanti);
            DataTable tablo = new DataTable();
            db.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void GecmisRandevular_Load(object sender, EventArgs e)
        {
            Randevularıgoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand silis = new OleDbCommand("DELETE FROM Randevular WHERE Kimlik=@Kimlik", baglanti);
            silis.Parameters.AddWithValue("@Kimlik", dataGridView1.CurrentRow.Cells[0].Value);
            silis.ExecuteNonQuery();
            baglanti.Close();
            Randevularıgoster();
        }
    }
}
