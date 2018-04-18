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
    public partial class FrmNot : Form
    {
        public FrmNot()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();



        /*Kaydet Butonu Olayları*/
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtGun.Text == "" || TxtAy.Text == "" || TxtYil.Text == "" || TxtNotBaslik.Text == "" || TxtNotIcerik.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alanları Doldurunuz", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult secim = MessageBox.Show(TxtGun.Text + " " + TxtAy.Text + " " + TxtYil.Text + " Tarihli Notu Kaydetmek İstiyor Musun?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (secim == DialogResult.Yes)
                    {
                        SqlCommand komutKaydet = new SqlCommand("insert into TBL_NOTLAR(GUN,AY,YIL,NOTBASLIK,NOTICERIK) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                        komutKaydet.Parameters.AddWithValue("@p1", TxtGun.Text);
                        komutKaydet.Parameters.AddWithValue("@p2", TxtAy.Text);
                        komutKaydet.Parameters.AddWithValue("@p3", TxtYil.Text);
                        komutKaydet.Parameters.AddWithValue("@p4", TxtNotBaslik.Text);
                        komutKaydet.Parameters.AddWithValue("@p5", TxtNotIcerik.Text);
                        komutKaydet.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Not Kaydetme Başarılı", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NotListele();
                    }
                    else
                    {
                        NotListele();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Not Kaydetme Başarısız", "Uyarı Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /*Güncelle Butonu Olayları*/
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show(TxtGun.Text + " " + TxtAy.Text + " " + TxtYil.Text + " Tarihli Notu Güncellemek İstiyor Musun?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komutGuncelle = new SqlCommand("update TBL_NOTLAR set GUN=@P1,AY=@P2,YIL=@P3,NOTBASLIK=@P4,NOTICERIK=@P5 where ID=@P6", bgl.baglanti());
                komutGuncelle.Parameters.AddWithValue("@P1", TxtGun.Text);
                komutGuncelle.Parameters.AddWithValue("@P2", TxtAy.Text);
                komutGuncelle.Parameters.AddWithValue("@P3", TxtYil.Text);
                komutGuncelle.Parameters.AddWithValue("@P4", TxtNotBaslik.Text);
                komutGuncelle.Parameters.AddWithValue("@P5", TxtNotIcerik.Text);
                komutGuncelle.Parameters.AddWithValue("@P6", TxtId.Text);
                komutGuncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                NotListele();
                MessageBox.Show("Not Güncelleme Başarılı", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                NotListele();
            }
        }


        /*Silme Butonu Olayları*/
        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show(TxtGun.Text + " " + TxtAy.Text + " " + TxtYil.Text + " Tarihli Notu Silmek İstiyor Musun?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komutSil = new SqlCommand("delete from TBL_NOTLAR where ID=@P1", bgl.baglanti());
                komutSil.Parameters.AddWithValue("@P1", TxtId.Text);
                komutSil.ExecuteNonQuery();
                bgl.baglanti().Close();
                NotListele();
                MessageBox.Show("Not Silme Başarılı", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                NotListele();
            }
        }



        void NotListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_NOTLAR order by ID DESC", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void Temizle()
        {
            TxtId.Text = "";
            TxtGun.Text = DateTime.Now.Day.ToString();
            TxtAy.Text = DateTime.Now.Month.ToString();
            TxtYil.Text = DateTime.Now.Year.ToString();
            TxtNotBaslik.Text = "";
            TxtNotIcerik.Text = "";
        }

        private void FrmNot_Load(object sender, EventArgs e)
        {
            NotListele();
            Temizle();

            gridView1.Columns["ID"].AppearanceCell.BackColor = Color.Pink;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtGun.Text = dr["GUN"].ToString();
                TxtAy.Text = dr["AY"].ToString();
                TxtNotBaslik.Text = dr["NOTBASLIK"].ToString();
                TxtNotIcerik.Text = dr["NOTICERIK"].ToString();
            }
        }

        private void BtnAyListele_Click(object sender, EventArgs e)
        {
            if (TxtListeleAy.Text == "" || TxtListeleYil.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand komut = new SqlCommand("Select * From TBL_NOTLAR where AY=@P1 and YIL=@P2", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1",TxtListeleAy.Text);
                komut.Parameters.AddWithValue("@P2", TxtListeleYil.Text);
                gridControl1.DataSource = komut.ExecuteReader();
                bgl.baglanti().Close();
            }
        }

        private void BtnButunListele_Click(object sender, EventArgs e)
        {
            NotListele();
        }

        private void TxtListeleAy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtListeleYil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmNotDetay fr = new FrmNotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.id = dr["ID"].ToString();
                fr.gun = dr["GUN"].ToString();
                fr.ay = dr["AY"].ToString();
                fr.yil = dr["YIL"].ToString();
                fr.baslik = dr["NOTBASLIK"].ToString();
                fr.icerik = dr["NOTICERIK"].ToString();
            }
            fr.Show();
        }
    }
}
