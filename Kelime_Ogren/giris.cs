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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Hstn\Downloads\Compressed\dbSozluk\dbSozluk.accdb");

        private void btnGiris_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from giris where kullaniciadi=@p1 and sifre=@p2", baglanti);
            
            komut.Parameters.AddWithValue("@p1", txtAdmin.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            OleDbDataReader dr = komut.ExecuteReader();
            
            if (dr.Read())
            {
                Form1 fr = new Form1();
                fr.ad = txtAdmin.Text;
                fr.Show();
            }
            
            else
            {
                MessageBox.Show("Hatalı giriş");
            }
            baglanti.Close();

            

        }

        private void giris_Load(object sender, EventArgs e)
        {

        }
    }
}
