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
    public partial class DoktorGiris : Form
    {
        public DoktorGiris()
        {
            InitializeComponent();
        }
        public static string GidenDoktorAdı = "";
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=VeriTabaniTez.accdb");




        private void DoktorGirisbuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand giris = new OleDbCommand("select*from Doktorlar where DoktorAdıSoyadı=@DrAdSoyad and DoktorSifre=@Sifre", baglanti);
            giris.Parameters.AddWithValue("@DrAdSoyad", DoktorAdTxtbox.Text);
            giris.Parameters.AddWithValue("@Sifre", DoktorSifreTxtbox.Text);
            OleDbDataReader oku = giris.ExecuteReader();

            if (oku.Read())
            {
                GidenDoktorAdı = DoktorAdTxtbox.Text;
                DoktorBilgi DoktorBilgi = new DoktorBilgi();
                DoktorBilgi.ShowDialog();
                baglanti.Close();

            }
            else
            {
                baglanti.Close();
                MessageBox.Show("Doktor İsim Soyisim Veya Şifre Hatalı !!!");
            }



        }
    }
}
