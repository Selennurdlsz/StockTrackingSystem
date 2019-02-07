namespace YazilimSinamaStokTakipSistemi.Views.Demirbaşlar
{
    partial class DepartmanZimmetGetirForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmanZimmetGetirForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonPDF = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonExcel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.grid_DepartmanDemirbaslari = new DevExpress.XtraGrid.GridControl();
            this.gridView_DepartmanDemirbaslari = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbl_DepartmanAdi = new System.Windows.Forms.Label();
            this.lbl_DepartmanSorumlu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DepartmanDemirbaslari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DepartmanDemirbaslari)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonPDF,
            this.barButtonExcel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1031, 179);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonPDF
            // 
            this.barButtonPDF.Caption = "Pdf Dökümü Al";
            this.barButtonPDF.Id = 1;
            this.barButtonPDF.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonPDF.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonPDF.Name = "barButtonPDF";
            this.barButtonPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPDF_ItemClick);
            // 
            // barButtonExcel
            // 
            this.barButtonExcel.Caption = "Excel Dökümü Al";
            this.barButtonExcel.Id = 2;
            this.barButtonExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonExcel.Name = "barButtonExcel";
            this.barButtonExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonExcel_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Döküm İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonPDF);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonExcel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 559);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1031, 35);
            // 
            // grid_DepartmanDemirbaslari
            // 
            this.grid_DepartmanDemirbaslari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_DepartmanDemirbaslari.Location = new System.Drawing.Point(0, 179);
            this.grid_DepartmanDemirbaslari.MainView = this.gridView_DepartmanDemirbaslari;
            this.grid_DepartmanDemirbaslari.MenuManager = this.ribbonControl1;
            this.grid_DepartmanDemirbaslari.Name = "grid_DepartmanDemirbaslari";
            this.grid_DepartmanDemirbaslari.Size = new System.Drawing.Size(1031, 380);
            this.grid_DepartmanDemirbaslari.TabIndex = 4;
            this.grid_DepartmanDemirbaslari.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DepartmanDemirbaslari});
            // 
            // gridView_DepartmanDemirbaslari
            // 
            this.gridView_DepartmanDemirbaslari.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_DepartmanDemirbaslari.GridControl = this.grid_DepartmanDemirbaslari;
            this.gridView_DepartmanDemirbaslari.Name = "gridView_DepartmanDemirbaslari";
            this.gridView_DepartmanDemirbaslari.OptionsBehavior.Editable = false;
            this.gridView_DepartmanDemirbaslari.OptionsBehavior.ReadOnly = true;
            this.gridView_DepartmanDemirbaslari.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_DepartmanDemirbaslari_RowClick);
            this.gridView_DepartmanDemirbaslari.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_DepartmanDemirbaslari_CustomDrawRowIndicator);
            // 
            // lbl_DepartmanAdi
            // 
            this.lbl_DepartmanAdi.AutoSize = true;
            this.lbl_DepartmanAdi.Location = new System.Drawing.Point(478, 77);
            this.lbl_DepartmanAdi.Name = "lbl_DepartmanAdi";
            this.lbl_DepartmanAdi.Size = new System.Drawing.Size(104, 17);
            this.lbl_DepartmanAdi.TabIndex = 5;
            this.lbl_DepartmanAdi.Text = "Departman Adı:";
            // 
            // lbl_DepartmanSorumlu
            // 
            this.lbl_DepartmanSorumlu.AutoSize = true;
            this.lbl_DepartmanSorumlu.Location = new System.Drawing.Point(478, 121);
            this.lbl_DepartmanSorumlu.Name = "lbl_DepartmanSorumlu";
            this.lbl_DepartmanSorumlu.Size = new System.Drawing.Size(155, 17);
            this.lbl_DepartmanSorumlu.TabIndex = 6;
            this.lbl_DepartmanSorumlu.Text = "Departman Sorumlusu: ";
            // 
            // DepartmanZimmetGetirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 594);
            this.Controls.Add(this.lbl_DepartmanSorumlu);
            this.Controls.Add(this.lbl_DepartmanAdi);
            this.Controls.Add(this.grid_DepartmanDemirbaslari);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "DepartmanZimmetGetirForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "DepartmanZimmetGetirForm";
            this.Load += new System.EventHandler(this.DepartmanZimmetGetirForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DepartmanDemirbaslari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DepartmanDemirbaslari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonPDF;
        private DevExpress.XtraBars.BarButtonItem barButtonExcel;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraGrid.GridControl grid_DepartmanDemirbaslari;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DepartmanDemirbaslari;
        private System.Windows.Forms.Label lbl_DepartmanAdi;
        private System.Windows.Forms.Label lbl_DepartmanSorumlu;
    }
}