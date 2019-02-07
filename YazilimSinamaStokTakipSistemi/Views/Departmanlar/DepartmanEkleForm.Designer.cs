namespace YazilimSinamaStokTakipSistemi.Views.Departmanlar
{
    partial class DepartmanEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmanEkleForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.grup_Main = new System.Windows.Forms.GroupBox();
            this.btn_DepartmanEkle = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_Departman = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DepartmanAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Sirket = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.grup_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(634, 185);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Departman Kisi Yetkinlendir";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Departman Ekleme";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 555);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(634, 28);
            // 
            // grup_Main
            // 
            this.grup_Main.BackColor = System.Drawing.Color.LightSeaGreen;
            this.grup_Main.Controls.Add(this.cmb_Sirket);
            this.grup_Main.Controls.Add(this.label2);
            this.grup_Main.Controls.Add(this.btn_DepartmanEkle);
            this.grup_Main.Controls.Add(this.cmb_Departman);
            this.grup_Main.Controls.Add(this.label3);
            this.grup_Main.Controls.Add(this.txt_DepartmanAdi);
            this.grup_Main.Controls.Add(this.label1);
            this.grup_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grup_Main.Location = new System.Drawing.Point(0, 185);
            this.grup_Main.Name = "grup_Main";
            this.grup_Main.Size = new System.Drawing.Size(634, 370);
            this.grup_Main.TabIndex = 10;
            this.grup_Main.TabStop = false;
            this.grup_Main.Text = "Departman Ekle";
            // 
            // btn_DepartmanEkle
            // 
            this.btn_DepartmanEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_DepartmanEkle.Location = new System.Drawing.Point(264, 251);
            this.btn_DepartmanEkle.Name = "btn_DepartmanEkle";
            this.btn_DepartmanEkle.Size = new System.Drawing.Size(181, 40);
            this.btn_DepartmanEkle.TabIndex = 10;
            this.btn_DepartmanEkle.Text = "Departman Ekle";
            this.btn_DepartmanEkle.Click += new System.EventHandler(this.btn_DepartmanEkle_Click);
            // 
            // cmb_Departman
            // 
            this.cmb_Departman.FormattingEnabled = true;
            this.cmb_Departman.Location = new System.Drawing.Point(264, 171);
            this.cmb_Departman.Name = "cmb_Departman";
            this.cmb_Departman.Size = new System.Drawing.Size(181, 24);
            this.cmb_Departman.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Departman ıd:";
            // 
            // txt_DepartmanAdi
            // 
            this.txt_DepartmanAdi.Location = new System.Drawing.Point(264, 82);
            this.txt_DepartmanAdi.Name = "txt_DepartmanAdi";
            this.txt_DepartmanAdi.Size = new System.Drawing.Size(181, 23);
            this.txt_DepartmanAdi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Departman Adı:";
            // 
            // cmb_Sirket
            // 
            this.cmb_Sirket.FormattingEnabled = true;
            this.cmb_Sirket.Location = new System.Drawing.Point(264, 128);
            this.cmb_Sirket.Name = "cmb_Sirket";
            this.cmb_Sirket.Size = new System.Drawing.Size(181, 24);
            this.cmb_Sirket.TabIndex = 12;
            this.cmb_Sirket.SelectedIndexChanged += new System.EventHandler(this.cmb_Sirket_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sirket:";
            // 
            // DepartmanEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 583);
            this.Controls.Add(this.grup_Main);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "DepartmanEkleForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "DepartmanEkleForm";
            this.Load += new System.EventHandler(this.DepartmanEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.grup_Main.ResumeLayout(false);
            this.grup_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        public System.Windows.Forms.GroupBox grup_Main;
        private DevExpress.XtraEditors.SimpleButton btn_DepartmanEkle;
        private System.Windows.Forms.TextBox txt_DepartmanAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Departman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Sirket;
        private System.Windows.Forms.Label label2;
    }
}