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
    public partial class FrmRaporlama : Form
    {
        public FrmRaporlama()
        {
            InitializeComponent();
        }

        private void Raporlama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DboGiderHesaplaDataSet2.TBL_NOTLAR' table. You can move, or remove it, as needed.
            this.TBL_NOTLARTableAdapter.Fill(this.DboGiderHesaplaDataSet2.TBL_NOTLAR);
            // TODO: This line of code loads data into the 'DboGiderHesaplaDataSet1.TBL_GELIRLER' table. You can move, or remove it, as needed.
            this.TBL_GELIRLERTableAdapter.Fill(this.DboGiderHesaplaDataSet1.TBL_GELIRLER);
            // TODO: This line of code loads data into the 'DboGiderHesaplaDataSet.TBL_GIDERLER' table. You can move, or remove it, as needed.
            this.TBL_GIDERLERTableAdapter.Fill(this.DboGiderHesaplaDataSet.TBL_GIDERLER);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }
    }
}
