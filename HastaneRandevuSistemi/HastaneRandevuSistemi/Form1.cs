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
    public partial class AnaGirisSayfasi : Form
    {
        public AnaGirisSayfasi()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=VeriTabaniTez.accdb");
        public static string GidenTcBilgi = "";

        private void UyeKayitButon_Click(object sender, EventArgs e)
        {
            Uyekayit Uyekayit = new Uyekayit();
            Uyekayit.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tarihlabel.Text= DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void DoktorGirisAnaButon_Click(object sender, EventArgs e)
        {
            DoktorGiris doktorgiris = new DoktorGiris();
            doktorgiris.ShowDialog();
        }

        private void GirisButon_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand giris = new OleDbCommand("select*from Kisiler where TcNo=@TcNo and Parola=@Parola",baglanti);
            giris.Parameters.AddWithValue("@TcNo",tcTxtbox.Text);
            giris.Parameters.AddWithValue("@Parola", sifreTxtbox.Text);
            OleDbDataReader oku = giris.ExecuteReader();

            if (oku.Read())
            {
                GidenTcBilgi = tcTxtbox.Text;
                RandevuAl RandevuAl = new RandevuAl();
                RandevuAl.ShowDialog();
                baglanti.Close();


                tcTxtbox.Text = "";
                sifreTxtbox.Text = "";
                
                
            }
            else
            {
                baglanti.Close();
                MessageBox.Show("Tc No veya şifre hatalı");
            }
            
        }

        private void AdminGirisButon_Click(object sender, EventArgs e)
        {
            if (tcTxtbox.Text == "admin" && sifreTxtbox.Text == "123456")
            {
                AdminPaneli AdminPaneli = new AdminPaneli();
                AdminPaneli.ShowDialog();
            }
            else
                MessageBox.Show("Admin giriş bilgilerinizi kontrol edip tekrar deneyiniz!!!");
            
            
            
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
           
        }
    }
}
