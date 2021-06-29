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

namespace Kelime_Ogren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Hstn\Downloads\Compressed\dbSozluk\dbSozluk.accdb");
        Random rast = new Random();
        int sure = 90;
        int kelime = 0;
        public string ad;

        void getir()
        {
            int sayi;
            sayi = rast.Next(1, 2490);
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtIng.Text = dr[1].ToString();
                lblCevap.Text = dr[2].ToString();
                lblCevap.Text = lblCevap.Text.ToLower();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            timer1.Start();
        }

        private void txtTurk_TextChanged(object sender, EventArgs e)
        {
            if (txtTurk.Text == lblCevap.Text)
            {
                kelime++;
                lblKelime.Text = kelime.ToString();
                getir();
                txtTurk.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if (sure == 0)
            {
                txtTurk.Enabled = false;
                txtIng.Enabled = false;
                timer1.Stop();
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into kullanici (ad, dogru) values (@p1, @p2)", baglanti);
                komut.Parameters.AddWithValue("@p1", ad);
                komut.Parameters.AddWithValue("@p2", Convert.ToInt32(lblKelime.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }
    }
}
