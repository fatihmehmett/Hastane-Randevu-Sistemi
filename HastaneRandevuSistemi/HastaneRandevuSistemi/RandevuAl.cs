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
    public partial class RandevuAl : Form
    {
        public RandevuAl()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=VeriTabaniTez.accdb");
        OleDbCommand komut = new OleDbCommand();


        void Klinikgostercombobox()
        {
            baglanti.Open();
            OleDbCommand giris = new OleDbCommand("select*from Klinikler", baglanti);
            OleDbDataReader oku = giris.ExecuteReader();

            while (oku.Read())
            {
                klinikcombobox.Items.Add(oku["KlinikAdı"]);
            }
            baglanti.Close();
        }
        void Doktorgostercombobox()
        {
            baglanti.Open();
            OleDbCommand giris = new OleDbCommand("select*from Doktorlar", baglanti);
            OleDbDataReader oku = giris.ExecuteReader();

            while (oku.Read())
            {
                doktorcomboBox.Items.Add(oku["DoktorAdıSoyadı"]);
            }
            baglanti.Close();
        }
       /* void Saatkontrol()
        {
            baglanti.Open();
            OleDbCommand giris = new OleDbCommand("select*from Randevular where RandevuTarihi=@RT and RandevuSaati=@RS", baglanti);
            giris.Parameters.AddWithValue("@RT", dateTimePicker1.Text);
            giris.Parameters.AddWithValue("RS", randevusaatcombobox.Text);

            OleDbDataReader oku = giris.ExecuteReader();

            if (oku.Read())
            {
                MessageBox.Show("Bu Tarih Ve Saatte Randevu Zaten Kayıtlı. Lütfen Tekrar Deneyiniz !!!");
                baglanti.Close();

            }
        }*/






        private void RandevuAl_Load(object sender, EventArgs e)
        {


            Klinikgostercombobox();
            Doktorgostercombobox();









            randevutcsiTxtbox.Text = AnaGirisSayfasi.GidenTcBilgi.ToString();


            baglanti.Open();

            OleDbCommand giris = new OleDbCommand("select*from Kisiler where TcNo=@TcNo", baglanti);
            giris.Parameters.AddWithValue("@TcNo", randevutcsiTxtbox.Text);
            OleDbDataReader oku = giris.ExecuteReader();
            
            while (oku.Read())
            {
                randevuadTxtbox.Text = oku["adı"].ToString();
                randevusoyadTxtbox.Text = oku["Soyad"].ToString();
                randevudtarihTxtbox.Text = oku["DogumTarihi"].ToString();
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (klinikcombobox.Text == "")
            {
                MessageBox.Show("Lütfen Klinik Seçiniz !!!");
            }
            else if (doktorcomboBox.Text == "")
            {
                MessageBox.Show("Lütfen Doktor Seçiniz !!!");
            }
            else if (randevusaatcombobox.Text == "")
            {
                MessageBox.Show("Lütfen Randevu Saati Seçiniz !!!");
            }
            else
            {

                baglanti.Open();
                OleDbCommand giris = new OleDbCommand("select*from Randevular where RandevuTarihi=@RT and RandevuSaati=@RS and RandevuDoktoru=@RD", baglanti);
                giris.Parameters.AddWithValue("@RT", dateTimePicker1.Text);
                giris.Parameters.AddWithValue("@RS", randevusaatcombobox.Text);
                giris.Parameters.AddWithValue("@RD", doktorcomboBox.Text);

                OleDbDataReader oku = giris.ExecuteReader();

                if (oku.Read())
                {
                    MessageBox.Show("Bu Tarih Ve Saatte Randevu Zaten Alınmıştır. Lütfen Başka Bir Saate Alınız !!!");
                    baglanti.Close();

                }





                else
                {



                   // baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "INSERT INTO Randevular(HastaTc,HastaAd,HastaSoyad,RandevuKliniği,RandevuDoktoru,RandevuTarihi,RandevuSaati) VALUES('" + randevutcsiTxtbox.Text + "','" + randevuadTxtbox.Text + "','" + randevusoyadTxtbox.Text + "','" + klinikcombobox.Text + "','" + doktorcomboBox.Text + "','" + dateTimePicker1.Text + "','" + randevusaatcombobox.Text + "')";
                    komut.ExecuteNonQuery();
                    MessageBox.Show("RANDEVU KAYDI BAŞARILI !!!!");
                    baglanti.Close();

                }



            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label14.Text = label14.Text.Substring(1) + label14.Text.Substring(0, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GecmisRandevular GecmisRandevular = new GecmisRandevular();
            GecmisRandevular.ShowDialog();
        }
    }
}
