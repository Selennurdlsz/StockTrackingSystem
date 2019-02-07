namespace YazilimSinamaStokTakipSistemi.Views.Urun
{
    partial class UrunDetayiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunDetayiForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_UrunEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btn_urunListesi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_AktifYap = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtSatinAlinilanKurum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtToptanFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.txt_urunAdet = new System.Windows.Forms.TextBox();
            this.txt_UrunBirimFiyat = new System.Windows.Forms.TextBox();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            this.btn_UrunSil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_UrunDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_FiyatGizli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btn_UrunEkle,
            this.btn_urunListesi,
            this.btn_AktifYap});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1124, 185);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_UrunEkle
            // 
            this.btn_UrunEkle.Caption = "Ürün Ekle";
            this.btn_UrunEkle.Id = 1;
            this.btn_UrunEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_UrunEkle.ImageOptions.Image")));
            this.btn_UrunEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_UrunEkle.ImageOptions.LargeImage")));
            this.btn_UrunEkle.Name = "btn_UrunEkle";
            this.btn_UrunEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_AktifYap_ItemClick);
            // 
            // btn_urunListesi
            // 
            this.btn_urunListesi.Caption = "Ürünleri Listele";
            this.btn_urunListesi.Id = 2;
            this.btn_urunListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_urunListesi.ImageOptions.Image")));
            this.btn_urunListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_urunListesi.ImageOptions.LargeImage")));
            this.btn_urunListesi.Name = "btn_urunListesi";
            this.btn_urunListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_urunListesi_ItemClick);
            // 
            // btn_AktifYap
            // 
            this.btn_AktifYap.Caption = "Güncellemeyi Aktif Et";
            this.btn_AktifYap.Id = 3;
            this.btn_AktifYap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_AktifYap.ImageOptions.Image")));
            this.btn_AktifYap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_AktifYap.ImageOptions.LargeImage")));
            this.btn_AktifYap.Name = "btn_AktifYap";
            this.btn_AktifYap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_AktifYap_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ürün İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_UrunEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_urunListesi);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_AktifYap);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Ürün İşlemleri";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 767);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1124, 28);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtSatinAlinilanKurum);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txtToptanFiyat);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.calendarControl1);
            this.groupControl1.Controls.Add(this.txt_urunAdet);
            this.groupControl1.Controls.Add(this.txt_UrunBirimFiyat);
            this.groupControl1.Controls.Add(this.txt_UrunAdi);
            this.groupControl1.Controls.Add(this.btn_UrunSil);
            this.groupControl1.Controls.Add(this.btn_UrunDuzenle);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(243, 183);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(577, 567);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Detay";
            // 
            // txtSatinAlinilanKurum
            // 
            this.txtSatinAlinilanKurum.Location = new System.Drawing.Point(221, 207);
            this.txtSatinAlinilanKurum.Name = "txtSatinAlinilanKurum";
            this.txtSatinAlinilanKurum.Size = new System.Drawing.Size(280, 23);
            this.txtSatinAlinilanKurum.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Satin Alinilan Kurum";
            // 
            // txtToptanFiyat
            // 
            this.txtToptanFiyat.Location = new System.Drawing.Point(221, 134);
            this.txtToptanFiyat.Name = "txtToptanFiyat";
            this.txtToptanFiyat.Size = new System.Drawing.Size(280, 23);
            this.txtToptanFiyat.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ürün Toptan Fiyat";
            // 
            // calendarControl1
            // 
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.Enabled = false;
            this.calendarControl1.Location = new System.Drawing.Point(221, 236);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(260, 261);
            this.calendarControl1.TabIndex = 18;
            // 
            // txt_urunAdet
            // 
            this.txt_urunAdet.Enabled = false;
            this.txt_urunAdet.Location = new System.Drawing.Point(221, 169);
            this.txt_urunAdet.Name = "txt_urunAdet";
            this.txt_urunAdet.Size = new System.Drawing.Size(280, 23);
            this.txt_urunAdet.TabIndex = 9;
            this.txt_urunAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_urunAdet_KeyPress);
            // 
            // txt_UrunBirimFiyat
            // 
            this.txt_UrunBirimFiyat.Enabled = false;
            this.txt_UrunBirimFiyat.Location = new System.Drawing.Point(221, 89);
            this.txt_UrunBirimFiyat.Name = "txt_UrunBirimFiyat";
            this.txt_UrunBirimFiyat.Size = new System.Drawing.Size(280, 23);
            this.txt_UrunBirimFiyat.TabIndex = 9;
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Enabled = false;
            this.txt_UrunAdi.Location = new System.Drawing.Point(221, 41);
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(280, 23);
            this.txt_UrunAdi.TabIndex = 9;
            // 
            // btn_UrunSil
            // 
            this.btn_UrunSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_UrunSil.Location = new System.Drawing.Point(379, 524);
            this.btn_UrunSil.Name = "btn_UrunSil";
            this.btn_UrunSil.Size = new System.Drawing.Size(102, 38);
            this.btn_UrunSil.TabIndex = 16;
            this.btn_UrunSil.Text = "Ürünü Sil";
            this.btn_UrunSil.Click += new System.EventHandler(this.btn_UrunSil_Click);
            // 
            // btn_UrunDuzenle
            // 
            this.btn_UrunDuzenle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_UrunDuzenle.Enabled = false;
            this.btn_UrunDuzenle.Location = new System.Drawing.Point(204, 524);
            this.btn_UrunDuzenle.Name = "btn_UrunDuzenle";
            this.btn_UrunDuzenle.Size = new System.Drawing.Size(102, 38);
            this.btn_UrunDuzenle.TabIndex = 16;
            this.btn_UrunDuzenle.Text = "Ürünü Güncelle";
            this.btn_UrunDuzenle.Click += new System.EventHandler(this.btn_UrunDuzenle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Satın Alınma Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alınan Ürün Adedi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ürün Birim Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ürün Adı";
            // 
            // lbl_FiyatGizli
            // 
            this.lbl_FiyatGizli.AutoSize = true;
            this.lbl_FiyatGizli.Location = new System.Drawing.Point(975, 96);
            this.lbl_FiyatGizli.Name = "lbl_FiyatGizli";
            this.lbl_FiyatGizli.Size = new System.Drawing.Size(0, 17);
            this.lbl_FiyatGizli.TabIndex = 11;
            this.lbl_FiyatGizli.Visible = false;
            // 
            // UrunDetayiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 795);
            this.Controls.Add(this.lbl_FiyatGizli);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "UrunDetayiForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "UrunDetayiForm";
            this.Load += new System.EventHandler(this.UrunDetayiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btn_UrunEkle;
        private DevExpress.XtraBars.BarButtonItem btn_urunListesi;
        private DevExpress.XtraBars.BarButtonItem btn_AktifYap;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private System.Windows.Forms.TextBox txt_urunAdet;
        private System.Windows.Forms.TextBox txt_UrunBirimFiyat;
        private System.Windows.Forms.TextBox txt_UrunAdi;
        private DevExpress.XtraEditors.SimpleButton btn_UrunSil;
        private DevExpress.XtraEditors.SimpleButton btn_UrunDuzenle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_FiyatGizli;
        private System.Windows.Forms.TextBox txtToptanFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSatinAlinilanKurum;
        private System.Windows.Forms.Label label6;
    }
}