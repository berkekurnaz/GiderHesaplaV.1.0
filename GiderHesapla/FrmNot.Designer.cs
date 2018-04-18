namespace GiderHesapla
{
    partial class FrmNot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNot));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TxtNotIcerik = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNotBaslik = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new DevExpress.XtraEditors.TextEdit();
            this.TxtYil = new System.Windows.Forms.ComboBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.TxtAy = new System.Windows.Forms.ComboBox();
            this.TxtGun = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtListeleYil = new System.Windows.Forms.ComboBox();
            this.TxtListeleAy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAyListele = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnButunListele = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNotBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.TxtNotIcerik);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.TxtNotBaslik);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.TxtId);
            this.groupControl1.Controls.Add(this.TxtYil);
            this.groupControl1.Controls.Add(this.Label9);
            this.groupControl1.Controls.Add(this.TxtAy);
            this.groupControl1.Controls.Add(this.TxtGun);
            this.groupControl1.Controls.Add(this.Label8);
            this.groupControl1.Controls.Add(this.Label7);
            this.groupControl1.Controls.Add(this.Label6);
            this.groupControl1.Location = new System.Drawing.Point(12, 51);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(899, 324);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Not Ekleme";
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.Image")));
            this.BtnSil.Location = new System.Drawing.Point(335, 245);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(130, 50);
            this.BtnSil.TabIndex = 44;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(175, 245);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(130, 50);
            this.BtnGuncelle.TabIndex = 43;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(20, 245);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(130, 50);
            this.BtnKaydet.TabIndex = 42;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtNotIcerik
            // 
            this.TxtNotIcerik.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNotIcerik.Location = new System.Drawing.Point(550, 106);
            this.TxtNotIcerik.Name = "TxtNotIcerik";
            this.TxtNotIcerik.Size = new System.Drawing.Size(259, 203);
            this.TxtNotIcerik.TabIndex = 41;
            this.TxtNotIcerik.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(410, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "NOT İÇERİK:";
            // 
            // TxtNotBaslik
            // 
            this.TxtNotBaslik.EditValue = "";
            this.TxtNotBaslik.Location = new System.Drawing.Point(550, 57);
            this.TxtNotBaslik.Name = "TxtNotBaslik";
            this.TxtNotBaslik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNotBaslik.Properties.Appearance.Options.UseFont = true;
            this.TxtNotBaslik.Size = new System.Drawing.Size(259, 28);
            this.TxtNotBaslik.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(410, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "NOT BAŞLIK:";
            // 
            // TxtId
            // 
            this.TxtId.EditValue = "";
            this.TxtId.Location = new System.Drawing.Point(118, 57);
            this.TxtId.Name = "TxtId";
            this.TxtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtId.Properties.Appearance.Options.UseFont = true;
            this.TxtId.Size = new System.Drawing.Size(191, 28);
            this.TxtId.TabIndex = 29;
            // 
            // TxtYil
            // 
            this.TxtYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtYil.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYil.FormattingEnabled = true;
            this.TxtYil.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020"});
            this.TxtYil.Location = new System.Drawing.Point(118, 177);
            this.TxtYil.Name = "TxtYil";
            this.TxtYil.Size = new System.Drawing.Size(191, 29);
            this.TxtYil.TabIndex = 32;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label9.Location = new System.Drawing.Point(26, 177);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(40, 21);
            this.Label9.TabIndex = 36;
            this.Label9.Text = "YIL:";
            // 
            // TxtAy
            // 
            this.TxtAy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtAy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAy.FormattingEnabled = true;
            this.TxtAy.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.TxtAy.Location = new System.Drawing.Point(118, 137);
            this.TxtAy.Name = "TxtAy";
            this.TxtAy.Size = new System.Drawing.Size(191, 29);
            this.TxtAy.TabIndex = 31;
            // 
            // TxtGun
            // 
            this.TxtGun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtGun.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGun.FormattingEnabled = true;
            this.TxtGun.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.TxtGun.Location = new System.Drawing.Point(118, 97);
            this.TxtGun.Name = "TxtGun";
            this.TxtGun.Size = new System.Drawing.Size(191, 29);
            this.TxtGun.TabIndex = 30;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label8.Location = new System.Drawing.Point(26, 137);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(37, 21);
            this.Label8.TabIndex = 35;
            this.Label8.Text = "AY:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label7.Location = new System.Drawing.Point(26, 97);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(49, 21);
            this.Label7.TabIndex = 34;
            this.Label7.Text = "GÜN:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label6.Location = new System.Drawing.Point(26, 57);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(34, 21);
            this.Label6.TabIndex = 33;
            this.Label6.Text = "ID:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupBox2);
            this.groupControl2.Controls.Add(this.groupBox1);
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 390);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(899, 362);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Notları Listeleme";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtListeleYil);
            this.groupBox2.Controls.Add(this.TxtListeleAy);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BtnAyListele);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(381, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 65);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // TxtListeleYil
            // 
            this.TxtListeleYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtListeleYil.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtListeleYil.FormattingEnabled = true;
            this.TxtListeleYil.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020"});
            this.TxtListeleYil.Location = new System.Drawing.Point(169, 24);
            this.TxtListeleYil.Name = "TxtListeleYil";
            this.TxtListeleYil.Size = new System.Drawing.Size(80, 29);
            this.TxtListeleYil.TabIndex = 45;
            this.TxtListeleYil.SelectedIndexChanged += new System.EventHandler(this.TxtListeleYil_SelectedIndexChanged);
            // 
            // TxtListeleAy
            // 
            this.TxtListeleAy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtListeleAy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtListeleAy.FormattingEnabled = true;
            this.TxtListeleAy.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.TxtListeleAy.Location = new System.Drawing.Point(45, 24);
            this.TxtListeleAy.Name = "TxtListeleAy";
            this.TxtListeleAy.Size = new System.Drawing.Size(80, 29);
            this.TxtListeleAy.TabIndex = 45;
            this.TxtListeleAy.SelectedIndexChanged += new System.EventHandler(this.TxtListeleAy_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(131, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "YIL:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BtnAyListele
            // 
            this.BtnAyListele.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAyListele.Appearance.Options.UseFont = true;
            this.BtnAyListele.Image = ((System.Drawing.Image)(resources.GetObject("BtnAyListele.Image")));
            this.BtnAyListele.Location = new System.Drawing.Point(265, 16);
            this.BtnAyListele.Name = "BtnAyListele";
            this.BtnAyListele.Size = new System.Drawing.Size(242, 43);
            this.BtnAyListele.TabIndex = 46;
            this.BtnAyListele.Text = "SEÇİLEN AYI LİSTELE";
            this.BtnAyListele.Click += new System.EventHandler(this.BtnAyListele_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 21);
            this.label3.TabIndex = 46;
            this.label3.Text = "AY:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnButunListele);
            this.groupBox1.Location = new System.Drawing.Point(5, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // BtnButunListele
            // 
            this.BtnButunListele.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnButunListele.Appearance.Options.UseFont = true;
            this.BtnButunListele.Image = ((System.Drawing.Image)(resources.GetObject("BtnButunListele.Image")));
            this.BtnButunListele.Location = new System.Drawing.Point(27, 16);
            this.BtnButunListele.Name = "BtnButunListele";
            this.BtnButunListele.Size = new System.Drawing.Size(255, 43);
            this.BtnButunListele.TabIndex = 45;
            this.BtnButunListele.Text = "BÜTÜN NOTLARI LİSTELE";
            this.BtnButunListele.Click += new System.EventHandler(this.BtnButunListele_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(5, 96);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(889, 261);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 45);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 45);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 758);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(923, 22);
            this.panel3.TabIndex = 3;
            // 
            // FrmNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 780);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Paneli";
            this.Load += new System.EventHandler(this.FrmNot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNotBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox TxtNotIcerik;
        internal System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit TxtNotBaslik;
        internal System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TxtId;
        internal System.Windows.Forms.ComboBox TxtYil;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ComboBox TxtAy;
        internal System.Windows.Forms.ComboBox TxtGun;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.ComboBox TxtListeleYil;
        internal System.Windows.Forms.ComboBox TxtListeleAy;
        internal System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton BtnAyListele;
        internal System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton BtnButunListele;

    }
}