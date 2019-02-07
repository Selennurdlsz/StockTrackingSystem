namespace YazilimSinamaStokTakipSistemi.Views.Departmanlar
{
    partial class DepartmanKisiYetkilendirForm
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Yetkilendir = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_PersonelBilgi = new System.Windows.Forms.Label();
            this.lbl_DepartmanAdi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grid_personelListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView_personelListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grid_DepartmanListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView_DepartmanListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_personelListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_personelListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DepartmanListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DepartmanListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Size = new System.Drawing.Size(1245, 62);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 671);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1245, 35);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btn_Yetkilendir);
            this.groupControl3.Controls.Add(this.lbl_PersonelBilgi);
            this.groupControl3.Controls.Add(this.lbl_DepartmanAdi);
            this.groupControl3.Controls.Add(this.label5);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Location = new System.Drawing.Point(927, 113);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(306, 527);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Yetkili Atama";
            // 
            // btn_Yetkilendir
            // 
            this.btn_Yetkilendir.Location = new System.Drawing.Point(61, 294);
            this.btn_Yetkilendir.Name = "btn_Yetkilendir";
            this.btn_Yetkilendir.Size = new System.Drawing.Size(172, 42);
            this.btn_Yetkilendir.TabIndex = 1;
            this.btn_Yetkilendir.Text = "Kişiyi Yetkilendir";
            this.btn_Yetkilendir.Click += new System.EventHandler(this.btn_Yetkilendir_Click);
            // 
            // lbl_PersonelBilgi
            // 
            this.lbl_PersonelBilgi.AutoSize = true;
            this.lbl_PersonelBilgi.Location = new System.Drawing.Point(191, 241);
            this.lbl_PersonelBilgi.Name = "lbl_PersonelBilgi";
            this.lbl_PersonelBilgi.Size = new System.Drawing.Size(13, 17);
            this.lbl_PersonelBilgi.TabIndex = 0;
            this.lbl_PersonelBilgi.Text = "-";
            // 
            // lbl_DepartmanAdi
            // 
            this.lbl_DepartmanAdi.AutoSize = true;
            this.lbl_DepartmanAdi.Location = new System.Drawing.Point(191, 200);
            this.lbl_DepartmanAdi.Name = "lbl_DepartmanAdi";
            this.lbl_DepartmanAdi.Size = new System.Drawing.Size(13, 17);
            this.lbl_DepartmanAdi.TabIndex = 0;
            this.lbl_DepartmanAdi.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Personel Bilgi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Departman Adı:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.grid_personelListesi);
            this.groupControl2.Location = new System.Drawing.Point(468, 113);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(440, 527);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Personel Listesi";
            // 
            // grid_personelListesi
            // 
            this.grid_personelListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_personelListesi.Location = new System.Drawing.Point(2, 25);
            this.grid_personelListesi.MainView = this.gridView_personelListesi;
            this.grid_personelListesi.MenuManager = this.ribbon;
            this.grid_personelListesi.Name = "grid_personelListesi";
            this.grid_personelListesi.Size = new System.Drawing.Size(436, 500);
            this.grid_personelListesi.TabIndex = 0;
            this.grid_personelListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_personelListesi});
            // 
            // gridView_personelListesi
            // 
            this.gridView_personelListesi.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_personelListesi.GridControl = this.grid_personelListesi;
            this.gridView_personelListesi.Name = "gridView_personelListesi";
            this.gridView_personelListesi.OptionsBehavior.Editable = false;
            this.gridView_personelListesi.OptionsBehavior.ReadOnly = true;
            this.gridView_personelListesi.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_personelListesi_RowClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grid_DepartmanListesi);
            this.groupControl1.Location = new System.Drawing.Point(12, 113);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(430, 527);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Departman Listesi";
            // 
            // grid_DepartmanListesi
            // 
            this.grid_DepartmanListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_DepartmanListesi.Location = new System.Drawing.Point(2, 26);
            this.grid_DepartmanListesi.MainView = this.gridView_DepartmanListesi;
            this.grid_DepartmanListesi.MenuManager = this.ribbon;
            this.grid_DepartmanListesi.Name = "grid_DepartmanListesi";
            this.grid_DepartmanListesi.Size = new System.Drawing.Size(426, 499);
            this.grid_DepartmanListesi.TabIndex = 0;
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
            // DepartmanKisiYetkilendirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 706);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "DepartmanKisiYetkilendirForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "DepartmanKisiYetkilendirForm";
            this.Load += new System.EventHandler(this.DepartmanKisiYetkilendirForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_personelListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_personelListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_DepartmanListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DepartmanListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Yetkilendir;
        private System.Windows.Forms.Label lbl_PersonelBilgi;
        private System.Windows.Forms.Label lbl_DepartmanAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grid_personelListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_personelListesi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grid_DepartmanListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DepartmanListesi;
    }
}