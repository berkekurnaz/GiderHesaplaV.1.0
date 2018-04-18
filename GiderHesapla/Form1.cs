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
using System.Data.SQLite;

namespace GiderHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*Not Paneli Butonu Tıklama Olayları*/
        private void BtnNotPaneli_Click(object sender, EventArgs e)
        {
            FrmNot frNot = new FrmNot();
            frNot.Show();
        }

        /*Gelirler Butonu Tıklama Olayları*/
        private void BtnGelirler_Click(object sender, EventArgs e)
        {
            FrmGelir frGelir = new FrmGelir();
            frGelir.Show();
        }

        /*Raporlama Butonu Tıklama Olayları*/
        private void BtnRaporlama_Click(object sender, EventArgs e)
        {
            FrmRaporlama frRapor = new FrmRaporlama();
            frRapor.Show();
        }

        /*Ayarlar Butonu Tıklama Olayları*/
        private void BtnAyarlar_Click(object sender, EventArgs e)
        {
            FrmAyarlar frAyarlar = new FrmAyarlar();
            frAyarlar.Show();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        void GiderListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select top 10 * From TBL_GIDERLER order by ID desc", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void Temizle()
        {
            TxtId.Text = "";
            TxtGun.Text = DateTime.Now.Day.ToString();
            TxtAy.Text = DateTime.Now.Month.ToString();
            TxtYil.Text = DateTime.Now.Year.ToString();
            TxtHarcama.SelectedItem = null;
            TxtArac.SelectedItem = null;
            TxtTutar.Text = "";
            TxtDetay.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GiderListele();
            Temizle();

            gridView1.Columns["ID"].AppearanceCell.BackColor = Color.Pink;

            gridView1.OptionsView.ShowAutoFilterRow = true;

            /*Toplam Yapılan Harcama*/
            ToplamYapılanHarcama();

            /*En Cok Harcama Yapılan Alan*/
            EnCokHarcamaYapilanAlan();

            /*En Cok Harcama Yapılan Arac*/
            EnCokHarcamaYapilanArac();

            /*Kullanici Adi Label'e Yazdirma*/
            KullaniciAdiGetir();
        }

        /*Kaydet Butonu Olayları*/
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtGun.Text=="" || TxtAy.Text=="" || TxtYil.Text=="" || TxtHarcama.Text=="" || TxtArac.Text=="")
                {
                    MessageBox.Show("Lütfen Boş Alanları Doldurunuz", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult secim = MessageBox.Show(TxtGun.Text + " " + TxtAy.Text + " " + TxtYil.Text + " Tarihli Gideri Kaydetmek İstiyor Musun?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (secim == DialogResult.Yes)
                    {
                        SqlCommand komutKaydet = new SqlCommand("insert into TBL_GIDERLER(GUN,AY,YIL,HARCAMA,ARAC,TUTAR,DETAY) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                        komutKaydet.Parameters.AddWithValue("@p1", TxtGun.Text);
                        komutKaydet.Parameters.AddWithValue("@p2", TxtAy.Text);
                        komutKaydet.Parameters.AddWithValue("@p3", TxtYil.Text);
                        komutKaydet.Parameters.AddWithValue("@p4", TxtHarcama.Text);
                        komutKaydet.Parameters.AddWithValue("@p5", TxtArac.Text);
                        komutKaydet.Parameters.AddWithValue("@p6", TxtTutar.Text);
                        komutKaydet.Parameters.AddWithValue("@p7", TxtDetay.Text);
                        komutKaydet.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Gider Kaydetme Başarılı", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GiderListele();
                    }
                    else
                    {
                        GiderListele();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Gider Kaydetme Başarısız", "Uyarı Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*Guncelle Butonu Olayları*/
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show(TxtGun.Text + " " + TxtAy.Text + " " + TxtYil.Text + " Tarihli Gideri Güncellemek İstiyor Musun?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komutGuncelle = new SqlCommand("update TBL_GIDERLER set GUN=@P1,AY=@P2,YIL=@P3,HARCAMA=@P4,ARAC=@P5,TUTAR=@P6,DETAY=@P7 where ID=@P8", bgl.baglanti());
                komutGuncelle.Parameters.AddWithValue("@P1", TxtGun.Text);
                komutGuncelle.Parameters.AddWithValue("@P2", TxtAy.Text);
                komutGuncelle.Parameters.AddWithValue("@P3", TxtYil.Text);
                komutGuncelle.Parameters.AddWithValue("@P4", TxtHarcama.Text);
                komutGuncelle.Parameters.AddWithValue("@P5", TxtArac.Text);
                komutGuncelle.Parameters.AddWithValue("@P6", TxtTutar.Text);
                komutGuncelle.Parameters.AddWithValue("@P7", TxtDetay.Text);
                komutGuncelle.Parameters.AddWithValue("@P8", TxtId.Text);
                komutGuncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                GiderListele();
                MessageBox.Show("Gider Güncelleme Başarılı", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GiderListele();
            }
        }

        /*Sil Butonu Olayları*/
        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show(TxtGun.Text + " " + TxtAy.Text + " " + TxtYil.Text + " Tarihli Gideri Silmek İstiyor Musun?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komutSil = new SqlCommand("delete from TBL_GIDERLER where ID=@P1", bgl.baglanti());
                komutSil.Parameters.AddWithValue("@P1", TxtId.Text);
                komutSil.ExecuteNonQuery();
                bgl.baglanti().Close();
                GiderListele();
                MessageBox.Show("Gider Silme Başarılı", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);     
            }
            else
            {
                GiderListele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtGun.Text = dr["GUN"].ToString();
                TxtAy.Text = dr["AY"].ToString();
                TxtYil.Text = dr["YIL"].ToString();
                TxtHarcama.Text = dr["HARCAMA"].ToString();
                TxtArac.Text = dr["ARAC"].ToString();
                TxtTutar.Text = dr["TUTAR"].ToString();
                TxtDetay.Text = dr["DETAY"].ToString();
            }

        }

        /*Listele Butonu Tıklama Olayları*/
        private void BtnListele_Click(object sender, EventArgs e)
        {
            if(TxtListeleGun.Text=="" || TxtListeleAy.Text=="" || TxtListeleYil.Text=="")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);     
            }
            else
            {
                SqlCommand komut = new SqlCommand("select * from TBL_GIDERLER where GUN=@p1 and AY=@p2 and YIL=@p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtListeleGun.Text);
                komut.Parameters.AddWithValue("@p2", TxtListeleAy.Text);
                komut.Parameters.AddWithValue("@p3", TxtListeleYil.Text);
                gridControl1.DataSource = komut.ExecuteReader();
                bgl.baglanti().Close();
            }

            /*Secili Gün Icin Toplam Harcama*/
            GunIcinToplamHarcama();

            /*Secili Ay Icin Toplam Harcama*/
            AyIcinToplamHarcama();

            /*Secili Yil Icin Toplam Harcama*/
            YilIcinToplamHarcama();

            /*Secili Ay Icin Toplam Gelir*/
            AyIcinToplamGelir();

            /*Secili Ay Icin Net Durum*/
            AyIcinNetDurum();

            /*En Cok Harcama Yapılan Alan*/
            EnCokHarcamaYapilanAlan();

            /*En Cok Harcama Yapılan Arac*/
            EnCokHarcamaYapilanArac();

            /*Kullanici Adi Label'e Yazdirma*/
            KullaniciAdiGetir();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GiderListele();
        }



        /*İstatistikler Ekranı İçin Kodlar*/
        void GunIcinToplamHarcama()
        {
            SqlCommand komutGun = new SqlCommand("Select SUM(TUTAR) FROM TBL_GIDERLER where GUN=@p1",bgl.baglanti());
            komutGun.Parameters.AddWithValue("@p1", TxtListeleGun.Text);
            SqlDataReader dr = komutGun.ExecuteReader();
            while(dr.Read())
            {
                LblGunToplam.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        void AyIcinToplamHarcama()
        {
            try
            {
                SqlCommand komutAy = new SqlCommand("Select SUM(TUTAR) FROM TBL_GIDERLER where AY=@p1", bgl.baglanti());
                komutAy.Parameters.AddWithValue("@p1", TxtListeleAy.Text);
                SqlDataReader dr = komutAy.ExecuteReader();
                while (dr.Read())
                {
                    LblAyToplam.Text = dr[0].ToString();
                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);     
            }
        }

        void YilIcinToplamHarcama()
        {
            try
            {
                SqlCommand komutYil = new SqlCommand("Select SUM(TUTAR) FROM TBL_GIDERLER where YIL=@p1", bgl.baglanti());
                komutYil.Parameters.AddWithValue("@p1", TxtListeleYil.Text);
                SqlDataReader dr = komutYil.ExecuteReader();
                while (dr.Read())
                {
                    LblYilToplam.Text = dr[0].ToString();
                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
        }

        void AyIcinToplamGelir()
        {
            try
            {
                SqlCommand komutGelir = new SqlCommand("Select SUM(TUTAR) From TBL_GELIRLER where AY=@p1", bgl.baglanti());
                komutGelir.Parameters.AddWithValue("@p1", TxtListeleAy.Text);
                SqlDataReader dr = komutGelir.ExecuteReader();
                while (dr.Read())
                {
                    LblAyGelir.Text = dr[0].ToString();
                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);     
            }
        }

        void AyIcinNetDurum()
        {
            int gelir, gider;
            int netDurum;
            if(LblAyToplam.Text == "" || LblAyGelir.Text == "")
            {
                MessageBox.Show("Seçili Aya Ait Bilgi Girilmemiş...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                gelir = Convert.ToInt32(LblAyGelir.Text);
                gider = Convert.ToInt32(LblAyToplam.Text);
                netDurum = gelir - gider;
                LblAyNetDurum.Text = Convert.ToString(netDurum); 
            }
        }

        void ToplamYapılanHarcama()
        {
            try
            {
                SqlCommand komutGelir = new SqlCommand("Select SUM(TUTAR) From TBL_GIDERLER", bgl.baglanti());
                SqlDataReader dr = komutGelir.ExecuteReader();
                while (dr.Read())
                {
                    LblToplamHarcama.Text = dr[0].ToString() + " TL";
                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void EnCokHarcamaYapilanAlan()
        {
            try
            {
                SqlCommand komutEnCokHarcama = new SqlCommand("Select MAX(HARCAMA) From TBL_GIDERLER", bgl.baglanti());
                SqlDataReader dr = komutEnCokHarcama.ExecuteReader();
                while (dr.Read())
                {
                    LblEnCokHarcama.Text = dr[0].ToString();
                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void EnCokHarcamaYapilanArac()
        {
            try
            {
                SqlCommand komutEnCokArac = new SqlCommand("Select MAX(ARAC) From TBL_GIDERLER", bgl.baglanti());
                SqlDataReader dr = komutEnCokArac.ExecuteReader();
                while (dr.Read())
                {
                    LblEnCokArac.Text = dr[0].ToString();
                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void KullaniciAdiGetir()
        {
            try
            {
                SqlCommand komutKullaniciAdi = new SqlCommand("Select KULLANICI From TBL_KULLANICI", bgl.baglanti());
                SqlDataReader dr = komutKullaniciAdi.ExecuteReader();
                while (dr.Read())
                {
                    LblKullaniciAdi.Text = dr[0].ToString();
                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTarih.Text = DateTime.Now.ToString();
            LblGunSayisal.Text = DateTime.Now.DayOfWeek.ToString();
            if(LblGunSayisal.Text == "Monday")
            {
                LblGun.Text = "Pazartesi";
            }
            else if(LblGunSayisal.Text=="Tuesday")
            {
                LblGun.Text = "Salı";
            }
            else if (LblGunSayisal.Text == "Wednesday")
            {
                LblGun.Text = "Çarşamba";
            }
            else if (LblGunSayisal.Text == "Thursday")
            {
                LblGun.Text = "Perşembe";
            }
            else if (LblGunSayisal.Text == "Friday")
            {
                LblGun.Text = "Cuma";
            }
            else if (LblGunSayisal.Text == "Saturday")
            {
                LblGun.Text = "Cumartesi";
            }
            else if (LblGunSayisal.Text == "Sunday")
            {
                LblGun.Text = "Pazar";
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmHarcamaDetay fr = new FrmHarcamaDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.id = dr["ID"].ToString();
                fr.gun = dr["GUN"].ToString();
                fr.ay = dr["AY"].ToString();
                fr.yil = dr["YIL"].ToString();
                fr.harcama = dr["HARCAMA"].ToString();
                fr.arac = dr["ARAC"].ToString();
                fr.tutar = dr["TUTAR"].ToString();
                fr.detay = dr["DETAY"].ToString();
            }
            fr.Show();
        }

    }
}