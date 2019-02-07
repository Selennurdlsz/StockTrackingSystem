namespace YazilimSinamaStokTakipSistemi.Views.Departmanlar
{
    partial class DepartmanListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmanListele));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_DepartmanTanimla = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.grup_Main = new System.Windows.Forms.GroupBox();
            this.grid_DepartmanListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView_DepartmanListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.grup_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DepartmanListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DepartmanListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_DepartmanTanimla,
            this.barButtonItem4});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(967, 185);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btn_DepartmanTanimla
            // 
            this.btn_DepartmanTanimla.Caption = "Departman Tanımla";
            this.btn_DepartmanTanimla.Id = 1;
            this.btn_DepartmanTanimla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DepartmanTanimla.ImageOptions.Image")));
            this.btn_DepartmanTanimla.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DepartmanTanimla.ImageOptions.LargeImage")));
            this.btn_DepartmanTanimla.Name = "btn_DepartmanTanimla";
            this.btn_DepartmanTanimla.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DepartmanTanimla_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DepartmanTanimla);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 619);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(967, 40);
            // 
            // grup_Main
            // 
            this.grup_Main.Controls.Add(this.grid_DepartmanListesi);
            this.grup_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grup_Main.Location = new System.Drawing.Point(0, 185);
            this.grup_Main.Name = "grup_Main";
            this.grup_Main.Size = new System.Drawing.Size(967, 434);
            this.grup_Main.TabIndex = 6;
            this.grup_Main.TabStop = false;
            // 
            // grid_DepartmanListesi
            // 
            this.grid_DepartmanListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_DepartmanListesi.Location = new System.Drawing.Point(3, 19);
            this.grid_DepartmanListesi.MainView = this.gridView_DepartmanListesi;
            this.grid_DepartmanListesi.Name = "grid_DepartmanListesi";
            this.grid_DepartmanListesi.Size = new System.Drawing.Size(961, 412);
            this.grid_DepartmanListesi.TabIndex = 1;
            this.grid_DepartmanListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DepartmanListesi});
            // 
            // gridView_DepartmanListesi
            // 
            this.gridView_DepartmanListesi.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_DepartmanListesi.GridControl = this.grid_DepartmanListesi;
            this.gridView_DepartmanListesi.Name = "gridView_DepartmanListesi";
            this.gridView_DepartmanListesi.OptionsBehavior.Editable = false;
            this.gridView_DepartmanListesi.OptionsBehavior.ReadOnly = true;
            this.gridView_DepartmanListesi.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_DepartmanListesi_RowClick);
            // 
            // DepartmanListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 659);
            this.Controls.Add(this.grup_Main);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "DepartmanListele";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "DepartmanListele";
            this.Load += new System.EventHandler(this.DepartmanListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.grup_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_DepartmanListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DepartmanListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btn_DepartmanTanimla;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        public System.Windows.Forms.GroupBox grup_Main;
        private DevExpress.XtraGrid.GridControl grid_DepartmanListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DepartmanListesi;
    }
}