namespace YazilimSinamaStokTakipSistemi.Views.Departmanlar
{
    partial class DepartmanDuzenleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmanDuzenleForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DepartmanListele = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Ekle = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DepartmanSil = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.grup_Main = new System.Windows.Forms.GroupBox();
            this.grid_Kisiler = new DevExpress.XtraGrid.GridControl();
            this.gridView_Kisiler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_DepartmanDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.txt_DepartmanAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Departman = new System.Windows.Forms.ComboBox();
            this.cmb_Sirket = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.grup_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Kisiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Kisiler)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.btn_DepartmanListele,
            this.btn_Ekle,
            this.barButtonItem4,
            this.btn_DepartmanSil});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1085, 185);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btn_DepartmanListele
            // 
            this.btn_DepartmanListele.Caption = "Departmanları Listele";
            this.btn_DepartmanListele.Id = 2;
            this.btn_DepartmanListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DepartmanListele.ImageOptions.Image")));
            this.btn_DepartmanListele.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DepartmanListele.ImageOptions.LargeImage")));
            this.btn_DepartmanListele.Name = "btn_DepartmanListele";
            this.btn_DepartmanListele.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DepartmanListele_ItemClick);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Caption = "Departman Ekle";
            this.btn_Ekle.Id = 3;
            this.btn_Ekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.ImageOptions.Image")));
            this.btn_Ekle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.ImageOptions.LargeImage")));
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Ekle_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btn_DepartmanSil
            // 
            this.btn_DepartmanSil.Caption = "Departmanı Sil";
            this.btn_DepartmanSil.Id = 6;
            this.btn_DepartmanSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DepartmanSil.ImageOptions.Image")));
            this.btn_DepartmanSil.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DepartmanSil.ImageOptions.LargeImage")));
            this.btn_DepartmanSil.Name = "btn_DepartmanSil";
            this.btn_DepartmanSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DepartmanSil_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Departman İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Ekle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DepartmanListele);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DepartmanSil);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 760);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1085, 28);
            // 
            // grup_Main
            // 
            this.grup_Main.Controls.Add(this.cmb_Departman);
            this.grup_Main.Controls.Add(this.cmb_Sirket);
            this.grup_Main.Controls.Add(this.label3);
            this.grup_Main.Controls.Add(this.label2);
            this.grup_Main.Controls.Add(this.grid_Kisiler);
            this.grup_Main.Controls.Add(this.btn_DepartmanDuzenle);
            this.grup_Main.Controls.Add(this.txt_DepartmanAdi);
            this.grup_Main.Controls.Add(this.label1);
            this.grup_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grup_Main.Location = new System.Drawing.Point(0, 185);
            this.grup_Main.Name = "grup_Main";
            this.grup_Main.Size = new System.Drawing.Size(1085, 575);
            this.grup_Main.TabIndex = 6;
            this.grup_Main.TabStop = false;
            this.grup_Main.Text = "Departman Ekle";
            // 
            // grid_Kisiler
            // 
            this.grid_Kisiler.Location = new System.Drawing.Point(549, 22);
            this.grid_Kisiler.MainView = this.gridView_Kisiler;
            this.grid_Kisiler.MenuManager = this.ribbonControl1;
            this.grid_Kisiler.Name = "grid_Kisiler";
            this.grid_Kisiler.Size = new System.Drawing.Size(524, 500);
            this.grid_Kisiler.TabIndex = 11;
            this.grid_Kisiler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Kisiler});
            // 
            // gridView_Kisiler
            // 
            this.gridView_Kisiler.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_Kisiler.GridControl = this.grid_Kisiler;
            this.gridView_Kisiler.Name = "gridView_Kisiler";
            this.gridView_Kisiler.OptionsBehavior.Editable = false;
            this.gridView_Kisiler.OptionsBehavior.ReadOnly = true;
            this.gridView_Kisiler.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Kisiler_RowClick);
            // 
            // btn_DepartmanDuzenle
            // 
            this.btn_DepartmanDuzenle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_DepartmanDuzenle.Location = new System.Drawing.Point(70, 193);
            this.btn_DepartmanDuzenle.Name = "btn_DepartmanDuzenle";
            this.btn_DepartmanDuzenle.Size = new System.Drawing.Size(181, 40);
            this.btn_DepartmanDuzenle.TabIndex = 10;
            this.btn_DepartmanDuzenle.Text = "Departmanı Düzenle";
            this.btn_DepartmanDuzenle.Click += new System.EventHandler(this.btn_DepartmanDuzenle_Click);
            // 
            // txt_DepartmanAdi
            // 
            this.txt_DepartmanAdi.Location = new System.Drawing.Point(138, 44);
            this.txt_DepartmanAdi.Name = "txt_DepartmanAdi";
            this.txt_DepartmanAdi.Size = new System.Drawing.Size(181, 23);
            this.txt_DepartmanAdi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Departman Adı:";
            // 
            // cmb_Departman
            // 
            this.cmb_Departman.FormattingEnabled = true;
            this.cmb_Departman.Location = new System.Drawing.Point(138, 137);
            this.cmb_Departman.Name = "cmb_Departman";
            this.cmb_Departman.Size = new System.Drawing.Size(181, 24);
            this.cmb_Departman.TabIndex = 14;
            // 
            // cmb_Sirket
            // 
            this.cmb_Sirket.FormattingEnabled = true;
            this.cmb_Sirket.Location = new System.Drawing.Point(138, 93);
            this.cmb_Sirket.Name = "cmb_Sirket";
            this.cmb_Sirket.Size = new System.Drawing.Size(181, 24);
            this.cmb_Sirket.TabIndex = 15;
            this.cmb_Sirket.SelectedIndexChanged += new System.EventHandler(this.cmb_Sirket_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Departman:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sirket:";
            // 
            // DepartmanDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 788);
            this.Controls.Add(this.grup_Main);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "DepartmanDuzenleForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "DepartmanDuzenleForm";
            this.Load += new System.EventHandler(this.DepartmanDuzenleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.grup_Main.ResumeLayout(false);
            this.grup_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Kisiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Kisiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btn_DepartmanListele;
        private DevExpress.XtraBars.BarButtonItem btn_Ekle;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btn_DepartmanSil;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        public System.Windows.Forms.GroupBox grup_Main;
        private DevExpress.XtraGrid.GridControl grid_Kisiler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Kisiler;
        private DevExpress.XtraEditors.SimpleButton btn_DepartmanDuzenle;
        private System.Windows.Forms.TextBox txt_DepartmanAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Departman;
        private System.Windows.Forms.ComboBox cmb_Sirket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}