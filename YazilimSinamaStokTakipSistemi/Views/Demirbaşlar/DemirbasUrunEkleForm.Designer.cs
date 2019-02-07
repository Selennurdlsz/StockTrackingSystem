namespace YazilimSinamaStokTakipSistemi.Views.Demirbaşlar
{
    partial class DemirbasUrunEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemirbasUrunEkleForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_DemirbasListe = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DepartmanDemirbasAta = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grp_UrunList = new DevExpress.XtraEditors.GroupControl();
            this.grid_Urunler = new DevExpress.XtraGrid.GridControl();
            this.gridView_Urun = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grp_Demirbas = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DemirbasEkle = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_Departments = new System.Windows.Forms.ComboBox();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_UrunAdi = new System.Windows.Forms.Label();
            this.txt_Adet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Sirket = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_UrunList)).BeginInit();
            this.grp_UrunList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Urunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Urun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_Demirbas)).BeginInit();
            this.grp_Demirbas.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btn_DemirbasListe,
            this.btn_DepartmanDemirbasAta});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1410, 185);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_DemirbasListe
            // 
            this.btn_DemirbasListe.Caption = "Demirbaşları Listele";
            this.btn_DemirbasListe.Id = 1;
            this.btn_DemirbasListe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DemirbasListe.ImageOptions.Image")));
            this.btn_DemirbasListe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DemirbasListe.ImageOptions.LargeImage")));
            this.btn_DemirbasListe.Name = "btn_DemirbasListe";
            this.btn_DemirbasListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DemirbasListe_ItemClick);
            // 
            // btn_DepartmanDemirbasAta
            // 
            this.btn_DepartmanDemirbasAta.Caption = "Departmana Demirbaş Ata";
            this.btn_DepartmanDemirbasAta.Id = 2;
            this.btn_DepartmanDemirbasAta.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_OdaDemirbasAta.ImageOptions.Image")));
            this.btn_DepartmanDemirbasAta.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_OdaDemirbasAta.ImageOptions.LargeImage")));
            this.btn_DepartmanDemirbasAta.Name = "btn_DepartmanDemirbasAta";
            this.btn_DepartmanDemirbasAta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_OdaDemirbasAta_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Demirbaş";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DemirbasListe);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DepartmanDemirbasAta);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 710);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1410, 28);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grp_UrunList);
            this.groupControl1.Controls.Add(this.grp_Demirbas);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 185);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1410, 525);
            this.groupControl1.TabIndex = 6;
            // 
            // grp_UrunList
            // 
            this.grp_UrunList.Controls.Add(this.grid_Urunler);
            this.grp_UrunList.Location = new System.Drawing.Point(691, 26);
            this.grp_UrunList.Name = "grp_UrunList";
            this.grp_UrunList.Size = new System.Drawing.Size(658, 475);
            this.grp_UrunList.TabIndex = 3;
            this.grp_UrunList.Text = "Ürünler";
            // 
            // grid_Urunler
            // 
            this.grid_Urunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Urunler.Location = new System.Drawing.Point(2, 26);
            this.grid_Urunler.MainView = this.gridView_Urun;
            this.grid_Urunler.MenuManager = this.ribbon;
            this.grid_Urunler.Name = "grid_Urunler";
            this.grid_Urunler.Size = new System.Drawing.Size(654, 447);
            this.grid_Urunler.TabIndex = 0;
            this.grid_Urunler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Urun});
            // 
            // gridView_Urun
            // 
            this.gridView_Urun.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_Urun.GridControl = this.grid_Urunler;
            this.gridView_Urun.Name = "gridView_Urun";
            this.gridView_Urun.OptionsBehavior.Editable = false;
            this.gridView_Urun.OptionsBehavior.ReadOnly = true;
            this.gridView_Urun.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Urun_RowClick);
            // 
            // grp_Demirbas
            // 
            this.grp_Demirbas.Controls.Add(this.cmb_Sirket);
            this.grp_Demirbas.Controls.Add(this.label5);
            this.grp_Demirbas.Controls.Add(this.label1);
            this.grp_Demirbas.Controls.Add(this.btn_DemirbasEkle);
            this.grp_Demirbas.Controls.Add(this.cmb_Departments);
            this.grp_Demirbas.Controls.Add(this.txt_Aciklama);
            this.grp_Demirbas.Controls.Add(this.label4);
            this.grp_Demirbas.Controls.Add(this.lbl_UrunAdi);
            this.grp_Demirbas.Controls.Add(this.txt_Adet);
            this.grp_Demirbas.Controls.Add(this.label6);
            this.grp_Demirbas.Controls.Add(this.label3);
            this.grp_Demirbas.Controls.Add(this.label2);
            this.grp_Demirbas.Location = new System.Drawing.Point(17, 25);
            this.grp_Demirbas.Name = "grp_Demirbas";
            this.grp_Demirbas.Size = new System.Drawing.Size(658, 475);
            this.grp_Demirbas.TabIndex = 4;
            this.grp_Demirbas.Text = "Demirbaş Ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(160, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 7;
            // 
            // btn_DemirbasEkle
            // 
            this.btn_DemirbasEkle.Location = new System.Drawing.Point(295, 418);
            this.btn_DemirbasEkle.Name = "btn_DemirbasEkle";
            this.btn_DemirbasEkle.Size = new System.Drawing.Size(148, 44);
            this.btn_DemirbasEkle.TabIndex = 6;
            this.btn_DemirbasEkle.Text = "Demirbaşı Ekle";
            this.btn_DemirbasEkle.Click += new System.EventHandler(this.btn_DemirbasEkle_Click);
            // 
            // cmb_Departments
            // 
            this.cmb_Departments.DisplayMember = "DepartmentId";
            this.cmb_Departments.FormattingEnabled = true;
            this.cmb_Departments.Location = new System.Drawing.Point(155, 96);
            this.cmb_Departments.Name = "cmb_Departments";
            this.cmb_Departments.Size = new System.Drawing.Size(148, 24);
            this.cmb_Departments.TabIndex = 5;
            this.cmb_Departments.ValueMember = "DepartmentId";
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(155, 249);
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(472, 145);
            this.txt_Aciklama.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Demirbaş Açıklaması";
            // 
            // lbl_UrunAdi
            // 
            this.lbl_UrunAdi.AutoSize = true;
            this.lbl_UrunAdi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_UrunAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_UrunAdi.Location = new System.Drawing.Point(160, 219);
            this.lbl_UrunAdi.Name = "lbl_UrunAdi";
            this.lbl_UrunAdi.Size = new System.Drawing.Size(0, 21);
            this.lbl_UrunAdi.TabIndex = 3;
            // 
            // txt_Adet
            // 
            this.txt_Adet.Location = new System.Drawing.Point(155, 180);
            this.txt_Adet.Name = "txt_Adet";
            this.txt_Adet.Size = new System.Drawing.Size(148, 23);
            this.txt_Adet.TabIndex = 4;
            this.txt_Adet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Adet_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Seçilen Ürün";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Demirbaş Adedi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Departman";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sirket";
            // 
            // cmb_Sirket
            // 
            this.cmb_Sirket.DisplayMember = "SirketId";
            this.cmb_Sirket.FormattingEnabled = true;
            this.cmb_Sirket.Location = new System.Drawing.Point(155, 143);
            this.cmb_Sirket.Name = "cmb_Sirket";
            this.cmb_Sirket.Size = new System.Drawing.Size(148, 24);
            this.cmb_Sirket.TabIndex = 9;
            this.cmb_Sirket.ValueMember = "SirketId";
            this.cmb_Sirket.SelectedIndexChanged += new System.EventHandler(this.cmb_Sirket_SelectedIndexChanged);
            this.cmb_Sirket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Sirket_KeyDown);
            // 
            // DemirbasUrunEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 738);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "DemirbasUrunEkleForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "DemirbasUrunEkleForm";
            this.Load += new System.EventHandler(this.DemirbasUrunEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grp_UrunList)).EndInit();
            this.grp_UrunList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Urunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Urun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_Demirbas)).EndInit();
            this.grp_Demirbas.ResumeLayout(false);
            this.grp_Demirbas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btn_DemirbasListe;
        private DevExpress.XtraBars.BarButtonItem btn_DepartmanDemirbasAta;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl grp_UrunList;
        private DevExpress.XtraGrid.GridControl grid_Urunler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Urun;
        private DevExpress.XtraEditors.GroupControl grp_Demirbas;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_DemirbasEkle;
        private System.Windows.Forms.ComboBox cmb_Departments;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_UrunAdi;
        private System.Windows.Forms.TextBox txt_Adet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.ComboBox cmb_Sirket;
        private System.Windows.Forms.Label label5;
    }
}