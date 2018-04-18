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
    public partial class FrmGelir : Form
    {
        public FrmGelir()
        {
            InitializeComponent();
        }



        sqlbaglantisi bgl = new sqlbaglantisi();
        void GelirListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select top 10 * From TBL_GELIRLER order by ID desc",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }


        void Temizle()
        {
            TxtId.Text = "";
            TxtAy.Text = DateTime.Now.Month.ToString();
            TxtYil.Text = DateTime.Now.Year.ToString();
            TxtTutar.Text = "";
            TxtNot.Text = "";
        }

        private void FrmGelir_Load(object sender, EventArgs e)
        {
            GelirListele();
            Temizle();

            /*İstatistikler*/

            GelirToplam1();
            GelirToplam2();
            GelirToplam3();
            GelirToplam();
            EnFazlaGelir();
            GelirOrtalamasi();
            GelirSayisi();

            gridView1.Columns["ID"].AppearanceCell.BackColor = Color.Pink;
        }




        /*Kaydet Butonu Tıklama Olayları*/
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
                if (TxtAy.Text == "" || TxtYil.Text == "" || TxtTutar.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alanları Doldurunuz", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult secim = MessageBox.Show(TxtAy.Text + " " + TxtYil.Text + " Tarihli Geliri Kaydetmek İstiyor Musun?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (secim == DialogResult.Yes)
                    {
                        SqlCommand komutKaydet = new SqlCommand("insert into TBL_GELIRLER(AY,YIL,TUTAR,GELIRNOT) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                        komutKaydet.Parameters.AddWithValue("@p1", TxtAy.Text);
                        komutKaydet.Parameters.AddWithValue("@p2", TxtYil.Text);
                        komutKaydet.Parameters.AddWithValue("@p3", TxtTutar.Text);
                        komutKaydet.Parameters.AddWithValue("@p4", TxtNot.Text);
                        komutKaydet.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Gelir Kaydetme Başarılı", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GelirListele();
                        GelirToplam1();
                        GelirToplam2();
                        GelirToplam3();
                        GelirToplam();
                        EnFazlaGelir();
                    }
                    else
                    {
                        GelirListele();
                    }
                }
        }


        /*Güncelle Butonu Tıklama Olayları*/
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show(TxtAy.Text + " " + TxtYil.Text + " Tarihli Geliri Güncellemek İstiyor Musun?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komutGuncelle = new SqlCommand("update TBL_GELIRLER set AY=@P1,YIL=@P2,TUTAR=@P3,GELIRNOT=@P4 where ID=@P5", bgl.baglanti());
                komutGuncelle.Parameters.AddWithValue("@P1", TxtAy.Text);
                komutGuncelle.Parameters.AddWithValue("@P2", TxtYil.Text);
                komutGuncelle.Parameters.AddWithValue("@P3", TxtTutar.Text);
                komutGuncelle.Parameters.AddWithValue("@P4", TxtNot.Text);
                komutGuncelle.Parameters.AddWithValue("@P5", TxtId.Text);
                komutGuncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                GelirListele();
                GelirToplam1();
                GelirToplam2();
                GelirToplam3();
                GelirToplam();
                EnFazlaGelir();
                MessageBox.Show("Gelir Güncelleme Başarılı", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GelirListele();
            }
        }


        /*Sil Butonu Tıklama Olayları*/
        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show(TxtAy.Text + " " + TxtYil.Text + " Tarihli Geliri Silmek İstiyor Musun?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komutSil = new SqlCommand("delete from TBL_GELIRLER where ID=@P1", bgl.baglanti());
                komutSil.Parameters.AddWithValue("@P1", TxtId.Text);
                komutSil.ExecuteNonQuery();
                bgl.baglanti().Close();
                GelirListele();
                GelirToplam1();
                GelirToplam2();
                GelirToplam3();
                GelirToplam();
                EnFazlaGelir();
                MessageBox.Show("Gelir Silme Başarılı", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GelirListele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAy.Text = dr["AY"].ToString();
                TxtYil.Text = dr["YIL"].ToString();
                TxtTutar.Text = dr["TUTAR"].ToString();
                TxtNot.Text = dr["GELIRNOT"].ToString();
            }
        }
    
    
        /*İstatistikler Ekranı Kodları*/

        void GelirToplam1()
        {
            try
            {
                SqlCommand komutGelir1 = new SqlCommand("Select SUM(TUTAR) FROM TBL_GELIRLER WHERE YIL='2018'", bgl.baglanti());
                SqlDataReader dr = komutGelir1.ExecuteReader();
                while (dr.Read())
                {
                    LblGelir1.Text = dr[0].ToString() + " TL";
                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void GelirToplam2()
        {
            try
            {
                SqlCommand komutGelir2 = new SqlCommand("Select SUM(TUTAR) FROM TBL_GELIRLER WHERE YIL='2019'", bgl.baglanti());
                SqlDataReader dr = komutGelir2.ExecuteReader();
                while (dr.Read())
                {
                    LblGelir2.Text = dr[0].ToString()+ " TL";
                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void GelirToplam3()
        {
            try
            {
                SqlCommand komutGelir3 = new SqlCommand("Select SUM(TUTAR) FROM TBL_GELIRLER WHERE YIL='2020'", bgl.baglanti());
                SqlDataReader dr = komutGelir3.ExecuteReader();
                while (dr.Read())
                {
                    LblGelir3.Text = dr[0].ToString() + " TL";
                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void GelirToplam()
        {
            try
            {
                SqlCommand komutGelirToplam = new SqlCommand("Select SUM(TUTAR) FROM TBL_GELIRLER", bgl.baglanti());
                SqlDataReader dr = komutGelirToplam.ExecuteReader();
                while (dr.Read())
                {
                    LblGelirToplam.Text = dr[0].ToString() + " TL";
                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void EnFazlaGelir()
        {
            try
            {
                SqlCommand komutGelirAy = new SqlCommand("SELECT AY,TUTAR FROM TBL_GELIRLER WHERE TUTAR =(SELECT MAX(TUTAR) FROM TBL_GELIRLER)", bgl.baglanti());
                SqlDataReader dr = komutGelirAy.ExecuteReader();
                while (dr.Read())
                {
                    LblAyFazla.Text = dr[0].ToString();
                }
                bgl.baglanti().Close();
                if(LblAyFazla.Text=="01")
                {
                    LblEnFazlaGelirAy.Text = "Ocak";
                }
                else if(LblAyFazla.Text=="02")
                {
                    LblEnFazlaGelirAy.Text = "Şubat";
                }
                else if (LblAyFazla.Text == "03")
                {
                    LblEnFazlaGelirAy.Text = "Mart";
                }
                else if (LblAyFazla.Text == "04")
                {
                    LblEnFazlaGelirAy.Text = "Nisan";
                }
                else if (LblAyFazla.Text == "05")
                {
                    LblEnFazlaGelirAy.Text = "Mayıs";
                }
                else if (LblAyFazla.Text == "06")
                {
                    LblEnFazlaGelirAy.Text = "Haziran";
                }
                else if (LblAyFazla.Text == "07")
                {
                    LblEnFazlaGelirAy.Text = "Temmuz";
                }
                else if (LblAyFazla.Text == "08")
                {
                    LblEnFazlaGelirAy.Text = "Ağustos";
                }
                else if (LblAyFazla.Text == "09")
                {
                    LblEnFazlaGelirAy.Text = "Eylül";
                }
                else if (LblAyFazla.Text == "10")
                {
                    LblEnFazlaGelirAy.Text = "Ekim";
                }
                else if (LblAyFazla.Text == "11")
                {
                    LblEnFazlaGelirAy.Text = "Kasım";
                }
                else if (LblAyFazla.Text == "12")
                {
                    LblEnFazlaGelirAy.Text = "Aralık";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void GelirOrtalamasi()
        {
            try
            {
                SqlCommand komutGelirOrtalama = new SqlCommand("Select AVG(TUTAR) FROM TBL_GELIRLER", bgl.baglanti());
                SqlDataReader dr = komutGelirOrtalama.ExecuteReader();
                while (dr.Read())
                {
                    LblGelirlerinOrtalamasi.Text = dr[0].ToString() + " TL";
                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void GelirSayisi()
        {
            try
            {
                SqlCommand komutGelirSayisi = new SqlCommand("Select COUNT(*) FROM TBL_GELIRLER", bgl.baglanti());
                SqlDataReader dr = komutGelirSayisi.ExecuteReader();
                while (dr.Read())
                {
                    LblGelirSayisi.Text = dr[0].ToString()+" Adet";
                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSecilenAyListele_Click(object sender, EventArgs e)
        {
            if (TxtListeleAy.Text == "" || TxtListeleYil.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand komut = new SqlCommand("Select * From TBL_GELIRLER where AY=@P1 and YIL=@P2", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", TxtListeleAy.Text);
                komut.Parameters.AddWithValue("@P2", TxtListeleYil.Text);
                gridControl1.DataSource = komut.ExecuteReader();
                bgl.baglanti().Close();
            }
        }

        private void BtnButunGelirListele_Click(object sender, EventArgs e)
        {
            GelirListele();
        }

    }
}
