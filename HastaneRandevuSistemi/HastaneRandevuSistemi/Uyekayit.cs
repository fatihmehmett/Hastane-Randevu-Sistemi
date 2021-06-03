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
    public partial class Uyekayit : Form
    {
        public Uyekayit()
        {
            InitializeComponent();
        }
        
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=VeriTabaniTez.accdb");
        OleDbCommand komut = new OleDbCommand();

        private void TemizleButon_Click(object sender, EventArgs e)
        {
            AdTxtbox.Text = "";
            SoyadTxtbox.Text = "";
            TcTxtbox.Text = "";
            DogumTxtbox.Text = "";
            TelTxtbox.Text = "";
            EpostaTxtBox.Text = "";
            HesTxtbox.Text = "";
            ParolaTxtbox.Text = "";
            ParolatekrarTxtbox.Text = "";
        }

        private void ParolatekrarTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KayitolButon_Click(object sender, EventArgs e)
        {
            if (AdTxtbox.Text == "" ||
            SoyadTxtbox.Text == "" ||
            TcTxtbox.Text == "" ||
            DogumTxtbox.Text == "" ||
            TelTxtbox.Text == "" ||
            EpostaTxtBox.Text == "" ||
            HesTxtbox.Text == "" ||
            ParolaTxtbox.Text == "" ||
            ParolatekrarTxtbox.Text == "") { MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUNUZ!!!!"); }


            else
            {

                baglanti.Open();
                OleDbCommand giris = new OleDbCommand("select*from Kisiler where TcNo=@TcNo", baglanti);
                giris.Parameters.AddWithValue("@TcNo", TcTxtbox.Text);
                
                OleDbDataReader oku = giris.ExecuteReader();

                if (oku.Read())
                {
                    MessageBox.Show("Girilen TC Numarası Zaten Kayıtlı !!!");
                    baglanti.Close();

                }





                else
                {









                    if (ParolaTxtbox.Text == ParolatekrarTxtbox.Text)
                    {
                       // baglanti.Open();
                        komut.Connection = baglanti;
                        komut.CommandText = "INSERT INTO Kisiler(adı,Soyad,TcNo,DogumTarihi,Numara,Eposta,HesKodu,Parola) VALUES('" + AdTxtbox.Text + "','" + SoyadTxtbox.Text + "','" + TcTxtbox.Text + "','" + DogumTxtbox.Text + "','" + TelTxtbox.Text + "','" + EpostaTxtBox.Text + "','" + HesTxtbox.Text + "','" + ParolaTxtbox.Text + "')";
                        komut.ExecuteNonQuery();
                        MessageBox.Show("KAYIT BAŞARILI !!!!");
                        baglanti.Close();
                        AdTxtbox.Text = "";
                        SoyadTxtbox.Text = "";
                        TcTxtbox.Text = "";
                        DogumTxtbox.Text = "";
                        TelTxtbox.Text = "";
                        EpostaTxtBox.Text = "";
                        HesTxtbox.Text = "";
                        ParolaTxtbox.Text = "";
                        ParolatekrarTxtbox.Text = "";



                    }

                    else
                    {
                        MessageBox.Show("Şifre ve Şifre Tekrar Aynı Olmalıdır!!!!!!");
                    }
                    
                }
                baglanti.Close();
            }




        }
    }
}
