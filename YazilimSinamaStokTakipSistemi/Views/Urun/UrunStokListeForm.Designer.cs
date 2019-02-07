namespace YazilimSinamaStokTakipSistemi.Views.Urun
{
    partial class UrunStokListeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunStokListeForm));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barSubItemNavigation = new DevExpress.XtraBars.BarSubItem();
            this.employeesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.customersBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.btn_StokEkleFormAc = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupNavigation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.officeNavigationBar = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.officeNavigationBar1 = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.customersNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grid_Stoklar = new DevExpress.XtraGrid.GridControl();
            this.gridView_Stoklar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.customersLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grid_StoktaBiten = new DevExpress.XtraGrid.GridControl();
            this.gridView_StoktaBiten = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).BeginInit();
            this.officeNavigationBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.customersNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Stoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Stoklar)).BeginInit();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_StoktaBiten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_StoktaBiten)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem,
            this.barSubItemNavigation,
            this.employeesBarButtonItem,
            this.customersBarButtonItem,
            this.btn_StokEkleFormAc});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl.MaxItemId = 47;
            this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1314, 185);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Id = 14;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // barSubItemNavigation
            // 
            this.barSubItemNavigation.Caption = "Navigation";
            this.barSubItemNavigation.Enabled = false;
            this.barSubItemNavigation.Id = 15;
            this.barSubItemNavigation.ImageOptions.ImageUri.Uri = "NavigationBar";
            this.barSubItemNavigation.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.employeesBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.customersBarButtonItem)});
            this.barSubItemNavigation.Name = "barSubItemNavigation";
            this.barSubItemNavigation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSubItemNavigation_ItemClick);
            // 
            // employeesBarButtonItem
            // 
            this.employeesBarButtonItem.Caption = "Stoktaki Ürünler";
            this.employeesBarButtonItem.Id = 44;
            this.employeesBarButtonItem.Name = "employeesBarButtonItem";
            // 
            // customersBarButtonItem
            // 
            this.customersBarButtonItem.Caption = "Stokta Biten Ürünler";
            this.customersBarButtonItem.Id = 45;
            this.customersBarButtonItem.Name = "customersBarButtonItem";
            // 
            // btn_StokEkleFormAc
            // 
            this.btn_StokEkleFormAc.Caption = "Stok Ekle";
            this.btn_StokEkleFormAc.Id = 46;
            this.btn_StokEkleFormAc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_StokEkleFormAc.ImageOptions.Image")));
            this.btn_StokEkleFormAc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_StokEkleFormAc.ImageOptions.LargeImage")));
            this.btn_StokEkleFormAc.Name = "btn_StokEkleFormAc";
            this.btn_StokEkleFormAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_StokEkleFormAc_ItemClick);
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupNavigation,
            this.ribbonPageGroup1});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "Stok İşlemleri";
            // 
            // ribbonPageGroupNavigation
            // 
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.barSubItemNavigation);
            this.ribbonPageGroupNavigation.Name = "ribbonPageGroupNavigation";
            this.ribbonPageGroupNavigation.Text = "Module";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_StokEkleFormAc);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 613);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1314, 28);
            // 
            // officeNavigationBar
            // 
            this.officeNavigationBar.Controls.Add(this.officeNavigationBar1);
            this.officeNavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar.Location = new System.Drawing.Point(0, 562);
            this.officeNavigationBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.officeNavigationBar.Name = "officeNavigationBar";
            this.officeNavigationBar.Size = new System.Drawing.Size(1314, 51);
            this.officeNavigationBar.TabIndex = 4;
            this.officeNavigationBar.Text = "officeNavigationBar";
            // 
            // officeNavigationBar1
            // 
            this.officeNavigationBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar1.Location = new System.Drawing.Point(0, 0);
            this.officeNavigationBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.officeNavigationBar1.Name = "officeNavigationBar1";
            this.officeNavigationBar1.NavigationClient = this.navBarControl;
            this.officeNavigationBar1.Size = new System.Drawing.Size(1314, 51);
            this.officeNavigationBar1.TabIndex = 2;
            this.officeNavigationBar1.Text = "officeNavigationBar1";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.navBarGroup1;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl.Location = new System.Drawing.Point(0, 185);
            this.navBarControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 192;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(192, 377);
            this.navBarControl.TabIndex = 5;
            this.navBarControl.Text = "YanMenu";
            this.navBarControl.ActiveGroupChanged += new DevExpress.XtraNavBar.NavBarGroupEventHandler(this.navBarControl_ActiveGroupChanged);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Stoktaki Ürünler";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Stokta Biten Ürünler";
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Appearance.BackColor = System.Drawing.Color.White;
            this.navigationFrame.Appearance.Options.UseBackColor = true;
            this.navigationFrame.Controls.Add(this.customersNavigationPage);
            this.navigationFrame.Controls.Add(this.navigationPage1);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(192, 185);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.customersNavigationPage,
            this.navigationPage1});
            this.navigationFrame.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.navigationFrame.SelectedPage = this.customersNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(1122, 377);
            this.navigationFrame.TabIndex = 6;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // customersNavigationPage
            // 
            this.customersNavigationPage.Controls.Add(this.grid_Stoklar);
            this.customersNavigationPage.Controls.Add(this.customersLabelControl);
            this.customersNavigationPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersNavigationPage.Name = "customersNavigationPage";
            this.customersNavigationPage.Size = new System.Drawing.Size(1122, 377);
            // 
            // grid_Stoklar
            // 
            this.grid_Stoklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Stoklar.Location = new System.Drawing.Point(0, 0);
            this.grid_Stoklar.MainView = this.gridView_Stoklar;
            this.grid_Stoklar.MenuManager = this.ribbonControl;
            this.grid_Stoklar.Name = "grid_Stoklar";
            this.grid_Stoklar.Size = new System.Drawing.Size(1122, 377);
            this.grid_Stoklar.TabIndex = 2;
            this.grid_Stoklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Stoklar});
            // 
            // gridView_Stoklar
            // 
            this.gridView_Stoklar.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_Stoklar.GridControl = this.grid_Stoklar;
            this.gridView_Stoklar.Name = "gridView_Stoklar";
            this.gridView_Stoklar.OptionsBehavior.Editable = false;
            this.gridView_Stoklar.OptionsBehavior.ReadOnly = true;
            this.gridView_Stoklar.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Stoklar_RowClick);
            // 
            // customersLabelControl
            // 
            this.customersLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.customersLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.customersLabelControl.Appearance.Options.UseFont = true;
            this.customersLabelControl.Appearance.Options.UseForeColor = true;
            this.customersLabelControl.Appearance.Options.UseTextOptions = true;
            this.customersLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customersLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.customersLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.customersLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersLabelControl.Location = new System.Drawing.Point(0, 0);
            this.customersLabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersLabelControl.Name = "customersLabelControl";
            this.customersLabelControl.Size = new System.Drawing.Size(1122, 377);
            this.customersLabelControl.TabIndex = 1;
            this.customersLabelControl.Text = "Stoktaki Ürünler";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Controls.Add(this.grid_StoktaBiten);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1122, 377);
            // 
            // grid_StoktaBiten
            // 
            this.grid_StoktaBiten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_StoktaBiten.Location = new System.Drawing.Point(0, 0);
            this.grid_StoktaBiten.MainView = this.gridView_StoktaBiten;
            this.grid_StoktaBiten.MenuManager = this.ribbonControl;
            this.grid_StoktaBiten.Name = "grid_StoktaBiten";
            this.grid_StoktaBiten.Size = new System.Drawing.Size(1122, 377);
            this.grid_StoktaBiten.TabIndex = 0;
            this.grid_StoktaBiten.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_StoktaBiten});
            // 
            // gridView_StoktaBiten
            // 
            this.gridView_StoktaBiten.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_StoktaBiten.GridControl = this.grid_StoktaBiten;
            this.gridView_StoktaBiten.Name = "gridView_StoktaBiten";
            this.gridView_StoktaBiten.OptionsBehavior.Editable = false;
            this.gridView_StoktaBiten.OptionsBehavior.ReadOnly = true;
            // 
            // UrunStokListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 641);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.navBarControl);
            this.Controls.Add(this.officeNavigationBar);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "UrunStokListeForm";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "UrunStokListeForm";
            this.Load += new System.EventHandler(this.UrunStokListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).EndInit();
            this.officeNavigationBar.ResumeLayout(false);
            this.officeNavigationBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.customersNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Stoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Stoklar)).EndInit();
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_StoktaBiten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_StoktaBiten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.BarSubItem barSubItemNavigation;
        private DevExpress.XtraBars.BarButtonItem employeesBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem customersBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem btn_StokEkleFormAc;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNavigation;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage customersNavigationPage;
        private DevExpress.XtraGrid.GridControl grid_Stoklar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Stoklar;
        private DevExpress.XtraEditors.LabelControl customersLabelControl;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraGrid.GridControl grid_StoktaBiten;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_StoktaBiten;
    }
}