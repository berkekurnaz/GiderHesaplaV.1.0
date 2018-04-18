namespace GiderHesapla
{
    partial class FrmRaporlama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaporlama));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TBL_GIDERLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DboGiderHesaplaDataSet = new GiderHesapla.DboGiderHesaplaDataSet();
            this.TBL_GELIRLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DboGiderHesaplaDataSet1 = new GiderHesapla.DboGiderHesaplaDataSet1();
            this.TBL_NOTLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DboGiderHesaplaDataSet2 = new GiderHesapla.DboGiderHesaplaDataSet2();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TBL_GIDERLERTableAdapter = new GiderHesapla.DboGiderHesaplaDataSetTableAdapters.TBL_GIDERLERTableAdapter();
            this.TBL_GELIRLERTableAdapter = new GiderHesapla.DboGiderHesaplaDataSet1TableAdapters.TBL_GELIRLERTableAdapter();
            this.TBL_NOTLARTableAdapter = new GiderHesapla.DboGiderHesaplaDataSet2TableAdapters.TBL_NOTLARTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_GIDERLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboGiderHesaplaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_GELIRLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboGiderHesaplaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_NOTLARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboGiderHesaplaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBL_GIDERLERBindingSource
            // 
            this.TBL_GIDERLERBindingSource.DataMember = "TBL_GIDERLER";
            this.TBL_GIDERLERBindingSource.DataSource = this.DboGiderHesaplaDataSet;
            // 
            // DboGiderHesaplaDataSet
            // 
            this.DboGiderHesaplaDataSet.DataSetName = "DboGiderHesaplaDataSet";
            this.DboGiderHesaplaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBL_GELIRLERBindingSource
            // 
            this.TBL_GELIRLERBindingSource.DataMember = "TBL_GELIRLER";
            this.TBL_GELIRLERBindingSource.DataSource = this.DboGiderHesaplaDataSet1;
            // 
            // DboGiderHesaplaDataSet1
            // 
            this.DboGiderHesaplaDataSet1.DataSetName = "DboGiderHesaplaDataSet1";
            this.DboGiderHesaplaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBL_NOTLARBindingSource
            // 
            this.TBL_NOTLARBindingSource.DataMember = "TBL_NOTLAR";
            this.TBL_NOTLARBindingSource.DataSource = this.DboGiderHesaplaDataSet2;
            // 
            // DboGiderHesaplaDataSet2
            // 
            this.DboGiderHesaplaDataSet2.DataSetName = "DboGiderHesaplaDataSet2";
            this.DboGiderHesaplaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1139, 755);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.reportViewer1);
            this.xtraTabPage1.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1132, 705);
            this.xtraTabPage1.Text = "GİDERLER";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.TBL_GIDERLERBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GiderHesapla.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1132, 705);
            this.reportViewer1.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.reportViewer2);
            this.xtraTabPage2.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1132, 705);
            this.xtraTabPage2.Text = "GELİRLER";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.TBL_GELIRLERBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "GiderHesapla.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(1132, 705);
            this.reportViewer2.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.reportViewer3);
            this.xtraTabPage3.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage3.Image")));
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1132, 705);
            this.xtraTabPage3.Text = "NOTLAR";
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.TBL_NOTLARBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "GiderHesapla.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(1132, 705);
            this.reportViewer3.TabIndex = 0;
            // 
            // TBL_GIDERLERTableAdapter
            // 
            this.TBL_GIDERLERTableAdapter.ClearBeforeFill = true;
            // 
            // TBL_GELIRLERTableAdapter
            // 
            this.TBL_GELIRLERTableAdapter.ClearBeforeFill = true;
            // 
            // TBL_NOTLARTableAdapter
            // 
            this.TBL_NOTLARTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1139, 755);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRaporlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlama Ekranı";
            this.Load += new System.EventHandler(this.Raporlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBL_GIDERLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboGiderHesaplaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_GELIRLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboGiderHesaplaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_NOTLARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboGiderHesaplaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.BindingSource TBL_GIDERLERBindingSource;
        private DboGiderHesaplaDataSet DboGiderHesaplaDataSet;
        private DboGiderHesaplaDataSetTableAdapters.TBL_GIDERLERTableAdapter TBL_GIDERLERTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource TBL_GELIRLERBindingSource;
        private DboGiderHesaplaDataSet1 DboGiderHesaplaDataSet1;
        private DboGiderHesaplaDataSet1TableAdapters.TBL_GELIRLERTableAdapter TBL_GELIRLERTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource TBL_NOTLARBindingSource;
        private DboGiderHesaplaDataSet2 DboGiderHesaplaDataSet2;
        private DboGiderHesaplaDataSet2TableAdapters.TBL_NOTLARTableAdapter TBL_NOTLARTableAdapter;
    }
}