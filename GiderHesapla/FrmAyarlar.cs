using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GiderHesapla
{
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        /*Sql Baglanti Sinifimiz*/
        sqlbaglantisi bgl = new sqlbaglantisi();

        /*Veritabaninda Kullanici Ismimizi TxtKullanici'ye Tasidik*/
        void KullaniciGetir()
        {
            SqlCommand komut = new SqlCommand("Select KULLANICI From TBL_KULLANICI", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                TxtKullanici.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            KullaniciGetir();
        }

        /*Kullanici Ismini Degistirmek Icin Kodlar*/
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Kullanıcı Adını Değiştirmek İstiyor Musun?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update TBL_KULLANICI set KULLANICI=@P1 where ID=1",bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", TxtKullanici.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kullanıcı Adını Başarıyla Değiştirildi...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KullaniciGetir();
            }
            else
            {
                KullaniciGetir();
            }
        }

        /*Tarayıcıda Video Linkleri Açmak*/
        private void LblVideo1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }

        private void LblVideo2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }

        private void LblVideo3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }

        private void LblVideo4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }

        private void LblVideo5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }

        private void LblVideo6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }

        private void LblVideo7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }

        private void LblVideo8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }
    }
}
