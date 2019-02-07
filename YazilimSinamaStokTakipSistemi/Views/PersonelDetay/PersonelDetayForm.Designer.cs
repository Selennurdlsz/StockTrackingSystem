namespace YazilimSinamaStokTakipSistemi.Views.PersonelDetay
{
    partial class PersonelDetayForm
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
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barSubItemNavigation = new DevExpress.XtraBars.BarSubItem();
            this.employeesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.customersBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupNavigation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.officeNavigationBar = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.officeNavigationBar1 = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.employeesNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.customersNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.employeesNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_AdSoyad = new System.Windows.Forms.Label();
            this.employeesLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.customersNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grid_personeldemirbas = new DevExpress.XtraGrid.GridControl();
            this.gridView_personelDemirbas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.customersLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grid_PersonelDepartman = new DevExpress.XtraGrid.GridControl();
            this.gridView_personelDepartman = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).BeginInit();
            this.officeNavigationBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.employeesNavigationPage.SuspendLayout();
            this.customersNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_personeldemirbas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_personelDemirbas)).BeginInit();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_PersonelDepartman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_personelDepartman)).BeginInit();
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
            this.customersBarButtonItem});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl.MaxItemId = 46;
            this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1113, 185);
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
            this.employeesBarButtonItem.Caption = "Employees";
            this.employeesBarButtonItem.Id = 44;
            this.employeesBarButtonItem.Name = "employeesBarButtonItem";
            // 
            // customersBarButtonItem
            // 
            this.customersBarButtonItem.Caption = "Customers";
            this.customersBarButtonItem.Id = 45;
            this.customersBarButtonItem.Name = "customersBarButtonItem";
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupNavigation,
            this.ribbonPageGroup});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "View";
            // 
            // ribbonPageGroupNavigation
            // 
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.barSubItemNavigation);
            this.ribbonPageGroupNavigation.Name = "ribbonPageGroupNavigation";
            this.ribbonPageGroupNavigation.Text = "Module";
            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.AllowTextClipping = false;
            this.ribbonPageGroup.ItemLinks.Add(this.skinRibbonGalleryBarItem);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.ShowCaptionButton = false;
            this.ribbonPageGroup.Text = "Appearance";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 593);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1113, 28);
            // 
            // officeNavigationBar
            // 
            this.officeNavigationBar.Controls.Add(this.officeNavigationBar1);
            this.officeNavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar.Location = new System.Drawing.Point(0, 542);
            this.officeNavigationBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.officeNavigationBar.Name = "officeNavigationBar";
            this.officeNavigationBar.Size = new System.Drawing.Size(1113, 51);
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
            this.officeNavigationBar1.Size = new System.Drawing.Size(1113, 51);
            this.officeNavigationBar1.TabIndex = 2;
            this.officeNavigationBar1.Text = "officeNavigationBar1";
            this.officeNavigationBar1.Click += new System.EventHandler(this.PersonelDetayForm_Load);
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.employeesNavBarGroup;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.employeesNavBarGroup,
            this.customersNavBarGroup,
            this.navBarGroup1});
            this.navBarControl.Location = new System.Drawing.Point(0, 185);
            this.navBarControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 253;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(253, 357);
            this.navBarControl.TabIndex = 5;
            this.navBarControl.Text = "navBarControl";
            this.navBarControl.ActiveGroupChanged += new DevExpress.XtraNavBar.NavBarGroupEventHandler(this.navBarControl_ActiveGroupChanged);
            // 
            // employeesNavBarGroup
            // 
            this.employeesNavBarGroup.Caption = "Personel Detayı";
            this.employeesNavBarGroup.Expanded = true;
            this.employeesNavBarGroup.Name = "employeesNavBarGroup";
            // 
            // customersNavBarGroup
            // 
            this.customersNavBarGroup.Caption = "Personel Demirbaşları";
            this.customersNavBarGroup.Name = "customersNavBarGroup";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Personel Sorumluluğundaki Departmanlar";
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Appearance.BackColor = System.Drawing.Color.White;
            this.navigationFrame.Appearance.Options.UseBackColor = true;
            this.navigationFrame.Controls.Add(this.employeesNavigationPage);
            this.navigationFrame.Controls.Add(this.customersNavigationPage);
            this.navigationFrame.Controls.Add(this.navigationPage1);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(253, 185);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.employeesNavigationPage,
            this.customersNavigationPage,
            this.navigationPage1});
            this.navigationFrame.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.navigationFrame.SelectedPage = this.employeesNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(860, 357);
            this.navigationFrame.TabIndex = 6;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // employeesNavigationPage
            // 
            this.employeesNavigationPage.Controls.Add(this.lbl_Rol);
            this.employeesNavigationPage.Controls.Add(this.lbl_KullaniciAdi);
            this.employeesNavigationPage.Controls.Add(this.lbl_AdSoyad);
            this.employeesNavigationPage.Controls.Add(this.employeesLabelControl);
            this.employeesNavigationPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeesNavigationPage.Name = "employeesNavigationPage";
            this.employeesNavigationPage.Size = new System.Drawing.Size(860, 357);
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Location = new System.Drawing.Point(324, 221);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(42, 17);
            this.lbl_Rol.TabIndex = 1;
            this.lbl_Rol.Text = "label1";
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(324, 178);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(42, 17);
            this.lbl_KullaniciAdi.TabIndex = 1;
            this.lbl_KullaniciAdi.Text = "label1";
            // 
            // lbl_AdSoyad
            // 
            this.lbl_AdSoyad.AutoSize = true;
            this.lbl_AdSoyad.Location = new System.Drawing.Point(324, 130);
            this.lbl_AdSoyad.Name = "lbl_AdSoyad";
            this.lbl_AdSoyad.Size = new System.Drawing.Size(42, 17);
            this.lbl_AdSoyad.TabIndex = 1;
            this.lbl_AdSoyad.Text = "label1";
            // 
            // employeesLabelControl
            // 
            this.employeesLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.employeesLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.employeesLabelControl.Appearance.Options.UseFont = true;
            this.employeesLabelControl.Appearance.Options.UseForeColor = true;
            this.employeesLabelControl.Appearance.Options.UseTextOptions = true;
            this.employeesLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.employeesLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.employeesLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.employeesLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesLabelControl.Location = new System.Drawing.Point(0, 0);
            this.employeesLabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeesLabelControl.Name = "employeesLabelControl";
            this.employeesLabelControl.Size = new System.Drawing.Size(860, 357);
            this.employeesLabelControl.TabIndex = 0;
            // 
            // customersNavigationPage
            // 
            this.customersNavigationPage.Controls.Add(this.grid_personeldemirbas);
            this.customersNavigationPage.Controls.Add(this.customersLabelControl);
            this.customersNavigationPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersNavigationPage.Name = "customersNavigationPage";
            this.customersNavigationPage.Size = new System.Drawing.Size(860, 357);
            // 
            // grid_personeldemirbas
            // 
            this.grid_personeldemirbas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_personeldemirbas.Location = new System.Drawing.Point(0, 0);
            this.grid_personeldemirbas.MainView = this.gridView_personelDemirbas;
            this.grid_personeldemirbas.MenuManager = this.ribbonControl;
            this.grid_personeldemirbas.Name = "grid_personeldemirbas";
            this.grid_personeldemirbas.Size = new System.Drawing.Size(860, 357);
            this.grid_personeldemirbas.TabIndex = 2;
            this.grid_personeldemirbas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_personelDemirbas});
            // 
            // gridView_personelDemirbas
            // 
            this.gridView_personelDemirbas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_personelDemirbas.GridControl = this.grid_personeldemirbas;
            this.gridView_personelDemirbas.Name = "gridView_personelDemirbas";
            this.gridView_personelDemirbas.OptionsBehavior.Editable = false;
            this.gridView_personelDemirbas.OptionsBehavior.ReadOnly = true;
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
            this.customersLabelControl.Size = new System.Drawing.Size(860, 357);
            this.customersLabelControl.TabIndex = 1;
            this.customersLabelControl.Text = "Customers";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Controls.Add(this.grid_PersonelDepartman);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(860, 357);
            // 
            // grid_PersonelDepartman
            // 
            this.grid_PersonelDepartman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_PersonelDepartman.Location = new System.Drawing.Point(0, 0);
            this.grid_PersonelDepartman.MainView = this.gridView_personelDepartman;
            this.grid_PersonelDepartman.MenuManager = this.ribbonControl;
            this.grid_PersonelDepartman.Name = "grid_PersonelDepartman";
            this.grid_PersonelDepartman.Size = new System.Drawing.Size(860, 357);
            this.grid_PersonelDepartman.TabIndex = 0;
            this.grid_PersonelDepartman.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_personelDepartman});
            // 
            // gridView_personelDepartman
            // 
            this.gridView_personelDepartman.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_personelDepartman.GridControl = this.grid_PersonelDepartman;
            this.gridView_personelDepartman.Name = "gridView_personelDepartman";
            this.gridView_personelDepartman.OptionsBehavior.Editable = false;
            this.gridView_personelDepartman.OptionsBehavior.ReadOnly = true;
            this.gridView_personelDepartman.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_personelDepartman_RowClick);
            // 
            // PersonelDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 621);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.navBarControl);
            this.Controls.Add(this.officeNavigationBar);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "PersonelDetayForm";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "PersonelDetayForm";
            this.Load += new System.EventHandler(this.PersonelDetayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).EndInit();
            this.officeNavigationBar.ResumeLayout(false);
            this.officeNavigationBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.employeesNavigationPage.ResumeLayout(false);
            this.employeesNavigationPage.PerformLayout();
            this.customersNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_personeldemirbas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_personelDemirbas)).EndInit();
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_PersonelDepartman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_personelDepartman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.BarSubItem barSubItemNavigation;
        private DevExpress.XtraBars.BarButtonItem employeesBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem customersBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNavigation;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup employeesNavBarGroup;
        private DevExpress.XtraNavBar.NavBarGroup customersNavBarGroup;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage employeesNavigationPage;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.Label lbl_AdSoyad;
        private DevExpress.XtraEditors.LabelControl employeesLabelControl;
        private DevExpress.XtraBars.Navigation.NavigationPage customersNavigationPage;
        private DevExpress.XtraGrid.GridControl grid_personeldemirbas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_personelDemirbas;
        private DevExpress.XtraEditors.LabelControl customersLabelControl;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraGrid.GridControl grid_PersonelDepartman;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_personelDepartman;
    }
}