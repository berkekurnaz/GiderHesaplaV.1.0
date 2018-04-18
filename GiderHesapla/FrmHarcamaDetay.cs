using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderHesapla
{
    public partial class FrmHarcamaDetay : Form
    {
        public FrmHarcamaDetay()
        {
            InitializeComponent();
        }

        public string id, gun, ay, yil, harcama, arac, tutar, detay;

        private void FrmHarcamaDetay_Load(object sender, EventArgs e)
        {

            TxtGun.Text = gun;
            TxtAy.Text = ay;
            TxtYil.Text = yil;
            TxtCesid.Text = harcama;
            TxtArac.Text = arac;
            TxtTutar.Text = tutar + " TL"; 
            TxtDetay.Text = detay;

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
