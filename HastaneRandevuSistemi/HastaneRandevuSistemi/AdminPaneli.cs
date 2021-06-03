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
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=VeriTabaniTez.accdb");
        OleDbCommand komut = new OleDbCommand();


        void Klinikgoster()
        {
            baglanti.Open();
            OleDbCommand giris = new OleDbCommand("select*from Klinikler", baglanti);
            OleDbDataReader oku = giris.ExecuteReader();

            while (oku.Read())
            {
                KlinikListBox.Items.Add(oku["KlinikAdı"]);
            }
            baglanti.Close();
        }
        void Kliniksil()
        {
            baglanti.Open();
            // komut.Connection = baglanti;
            //komut.CommandText = "DELETE from Klinikler where KlinikAdı=@KlinikAdı";
            //komut.Parameters.AddWithValue("@KlinikAdı", KlinikListBox.SelectedItem.ToString());
            komut = new OleDbCommand("DELETE from Klinikler where KlinikAdı='" + KlinikListBox.SelectedItem.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Klinik Silindi");
        }
        void Doktorgoster()
        {
            baglanti.Open();
            OleDbCommand giris = new OleDbCommand("select*from Doktorlar", baglanti);
            OleDbDataReader oku = giris.ExecuteReader();

            while (oku.Read())
            {
                DoktorlarListBox.Items.Add(oku["DoktorAdıSoyadı"]);
            }
            baglanti.Close();
        }
        void Doktorsil()
        {
            baglanti.Open();
            // komut.Connection = baglanti;
            //komut.CommandText = "DELETE from Doktorlar where DoktorAdı=@DoktorAdı";
            //komut.Parameters.AddWithValue("@DoktorAdı", DoktorlarListBox.SelectedItem.ToString());
            komut = new OleDbCommand("DELETE from Doktorlar where DoktorAdıSoyadı='" + DoktorlarListBox.SelectedItem.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Doktor Silindi");
        }


        void Kisilerigoster()
        {
            baglanti.Open();
            OleDbDataAdapter db = new OleDbDataAdapter("select*from Kisiler", baglanti);
            DataTable tablo = new DataTable();
            db.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }


        void Randevularıgosterr()
        {
            baglanti.Open();
            OleDbDataAdapter db = new OleDbDataAdapter("select*from Randevular", baglanti);
            DataTable tablo = new DataTable();
            db.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();
        }









        private void KlinikEkleButon_Click(object sender, EventArgs e)
        {
            if (KlinikTxtBox.Text == "")
            {
                MessageBox.Show("Eklemek İstediğiniz Klinik Adını Yazınız !!!");

            }

            else
            {


                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO Klinikler(KlinikAdı) VALUES('" + KlinikTxtBox.Text + "')";
                komut.ExecuteNonQuery();
                MessageBox.Show("KAYIT BAŞARILI !!!!");
                baglanti.Close();

                KlinikListBox.Items.Clear();
                Klinikgoster();
                KlinikTxtBox.Text = "";

            }










        }

        private void KlinikSilButon_Click(object sender, EventArgs e)
        {
            try
            {
                KlinikListBox.SelectedItem.ToString();

                Kliniksil();
                KlinikListBox.Items.Clear();
                Klinikgoster();
            }
            catch(Exception)
            {
                MessageBox.Show("Klinik Seçimi Yapın!");
            }
            /*int secim = KlinikListBox.SelectedIndex;
            if (secim != -1)
            {
                
                Kliniksil();
                //KlinikListBox.Items.RemoveAt(secim);
                KlinikListBox.Items.Clear();
                Klinikgoster();

            }
            else
            {
                MessageBox.Show("Klinik Seçimi Yapın!");
            }*/
        }

        private void DoktorEkleButon_Click(object sender, EventArgs e)
        {
            if (DoktorTxtBox.Text == "")
            {
                MessageBox.Show("Eklemek İstediğiniz Doktor Adını Yazınız !!!");

            }

            else
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO Doktorlar(DoktorAdıSoyadı,DoktorSifre) VALUES('" + DoktorTxtBox.Text + "','"+"11111"+"')";
                komut.ExecuteNonQuery();
                MessageBox.Show("KAYIT BAŞARILI !!!!");
                baglanti.Close();

                DoktorlarListBox.Items.Clear();
                Doktorgoster();
                DoktorTxtBox.Text = "";







                //DoktorlarListBox.Items.Add(DoktorTxtBox.Text);
                //DoktorTxtBox.Clear();
            }
        }

        private void DoktorSilButon_Click(object sender, EventArgs e)
        {
            try
            {
                DoktorlarListBox.SelectedItem.ToString();

                Doktorsil();
                DoktorlarListBox.Items.Clear();
                Doktorgoster();
            }
            catch (Exception)
            {
                MessageBox.Show("Doktor Seçimi Yapın!");
            }

            /*int secim = DoktorlarListBox.SelectedIndex;
            if (secim != -1)
            {
                Doktorsil();
                DoktorlarListBox.Items.RemoveAt(secim);
            }
            else
            {
                MessageBox.Show("Doktor Seçimi Yapın!");
            }*/
        }

        private void AdminPaneli_Load(object sender, EventArgs e)
        {
            KlinikListBox.Items.Clear();
            Klinikgoster();
            DoktorlarListBox.Items.Clear();
            Doktorgoster();
            Kisilerigoster();
            Randevularıgosterr();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uyekayit Uyekayit = new Uyekayit();
            Uyekayit.ShowDialog();
            Kisilerigoster();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand silis = new OleDbCommand("DELETE FROM Kisiler WHERE Kimlik=@Kimlik", baglanti);
            silis.Parameters.AddWithValue("@Kimlik",dataGridView1.CurrentRow.Cells[0].Value);
            silis.ExecuteNonQuery();
            baglanti.Close();
            Kisilerigoster();
        }

        private void RandevuSilButon_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand silis = new OleDbCommand("DELETE FROM Randevular WHERE Kimlik=@Kimlik", baglanti);
            silis.Parameters.AddWithValue("@Kimlik", dataGridView2.CurrentRow.Cells[0].Value);
            silis.ExecuteNonQuery();
            baglanti.Close();
            Randevularıgosterr();
        }
    }
}
