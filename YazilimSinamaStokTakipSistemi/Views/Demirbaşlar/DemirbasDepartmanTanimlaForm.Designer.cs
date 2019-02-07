namespace YazilimSinamaStokTakipSistemi.Views.Demirbaşlar
{
    partial class DemirbasDepartmanTanimlaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemirbasDepartmanTanimlaForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.grid_Demirbas = new DevExpress.XtraGrid.GridControl();
            this.gridView_Demirbas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Adet = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grid_Departman = new DevExpress.XtraGrid.GridControl();
            this.gridView_Departman = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbl_departman = new System.Windows.Forms.Label();
            this.lbl_demirbas = new System.Windows.Forms.Label();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_DepartmanDemirbasKisi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Demirbas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Demirbas)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Departman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Departman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grid_Demirbas);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_Adet);
            this.panel2.Location = new System.Drawing.Point(583, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 564);
            this.panel2.TabIndex = 5;
            // 
            // grid_Demirbas
            // 
            this.grid_Demirbas.Location = new System.Drawing.Point(7, 36);
            this.grid_Demirbas.MainView = this.gridView_Demirbas;
            this.grid_Demirbas.Name = "grid_Demirbas";
            this.grid_Demirbas.Size = new System.Drawing.Size(588, 525);
            this.grid_Demirbas.TabIndex = 6;
            this.grid_Demirbas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Demirbas});
            // 
            // gridView_Demirbas
            // 
            this.gridView_Demirbas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_Demirbas.GridControl = this.grid_Demirbas;
            this.gridView_Demirbas.Name = "gridView_Demirbas";
            this.gridView_Demirbas.OptionsBehavior.Editable = false;
            this.gridView_Demirbas.OptionsBehavior.ReadOnly = true;
            this.gridView_Demirbas.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Demirbas_RowClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Demirbaş Adedi";
            // 
            // txt_Adet
            // 
            this.txt_Adet.Location = new System.Drawing.Point(112, 9);
            this.txt_Adet.Name = "txt_Adet";
            this.txt_Adet.Size = new System.Drawing.Size(100, 23);
            this.txt_Adet.TabIndex = 4;
            this.txt_Adet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Adet_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grid_Departman);
            this.panel3.Location = new System.Drawing.Point(40, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(519, 564);
            this.panel3.TabIndex = 4;
            // 
            // grid_Departman
            // 
            this.grid_Departman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Departman.Location = new System.Drawing.Point(0, 0);
            this.grid_Departman.MainView = this.gridView_Departman;
            this.grid_Departman.Name = "grid_Departman";
            this.grid_Departman.Size = new System.Drawing.Size(519, 564);
            this.grid_Departman.TabIndex = 1;
            this.grid_Departman.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Departman});
            // 
            // gridView_Departman
            // 
            this.gridView_Departman.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_Departman.GridControl = this.grid_Departman;
            this.gridView_Departman.Name = "gridView_Departman";
            this.gridView_Departman.OptionsBehavior.Editable = false;
            this.gridView_Departman.OptionsBehavior.ReadOnly = true;
            this.gridView_Departman.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Departman_RowClick);
            // 
            // lbl_departman
            // 
            this.lbl_departman.AutoSize = true;
            this.lbl_departman.Location = new System.Drawing.Point(275, 87);
            this.lbl_departman.Name = "lbl_departman";
            this.lbl_departman.Size = new System.Drawing.Size(169, 17);
            this.lbl_departman.TabIndex = 8;
            this.lbl_departman.Text = "Seçilen Departman Bilgileri:";
            // 
            // lbl_demirbas
            // 
            this.lbl_demirbas.AutoSize = true;
            this.lbl_demirbas.Location = new System.Drawing.Point(275, 135);
            this.lbl_demirbas.Name = "lbl_demirbas";
            this.lbl_demirbas.Size = new System.Drawing.Size(157, 17);
            this.lbl_demirbas.TabIndex = 9;
            this.lbl_demirbas.Text = "Seçilen Demirbaş Bilgileri:";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_DepartmanDemirbasKisi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1241, 185);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btn_DepartmanDemirbasKisi
            // 
            this.btn_DepartmanDemirbasKisi.Caption = "Departman Demirbaş İlişkinlendir";
            this.btn_DepartmanDemirbasKisi.Id = 1;
            this.btn_DepartmanDemirbasKisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DepartmanDemirbasKisi.ImageOptions.Image")));
            this.btn_DepartmanDemirbasKisi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DepartmanDemirbasKisi.ImageOptions.LargeImage")));
            this.btn_DepartmanDemirbasKisi.Name = "btn_DepartmanDemirbasKisi";
            this.btn_DepartmanDemirbasKisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DepartmanDemirbasKisi_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DepartmanDemirbasKisi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 783);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1241, 33);
            // 
            // DemirbasDepartmanTanimlaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 816);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.lbl_demirbas);
            this.Controls.Add(this.lbl_departman);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "DemirbasDepartmanTanimlaForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "DemirbasDepartmanTanimlaForm";
            this.Load += new System.EventHandler(this.DemirbasDepartmanTanimlaForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Demirbas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Demirbas)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Departman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Departman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl grid_Demirbas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Demirbas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Adet;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl grid_Departman;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Departman;
        private System.Windows.Forms.Label lbl_departman;
        private System.Windows.Forms.Label lbl_demirbas;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btn_DepartmanDemirbasKisi;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
    }
}