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
    public partial class DoktorBilgi : Form
    {
        public DoktorBilgi()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=VeriTabaniTez.accdb");


        void Randevularıgoster()
        {
            baglanti.Open();
            OleDbDataAdapter db = new OleDbDataAdapter("select*from Randevular where RandevuDoktoru='"+DoktorGiris.GidenDoktorAdı.ToString()+"'", baglanti);
            DataTable tablo = new DataTable();
            db.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }


        private void DoktorBilgi_Load(object sender, EventArgs e)
        {
            label2.Text = DoktorGiris.GidenDoktorAdı.ToString();
            Randevularıgoster();
        }
    }
}
