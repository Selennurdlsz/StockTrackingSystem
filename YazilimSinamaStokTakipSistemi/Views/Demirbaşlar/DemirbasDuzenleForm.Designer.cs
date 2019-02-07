namespace YazilimSinamaStokTakipSistemi.Views.Demirbaşlar
{
    partial class DemirbasDuzenleForm
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.grp_Demirbas = new DevExpress.XtraEditors.GroupControl();
            this.btn_DemirbasEkle = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_Departments = new System.Windows.Forms.ComboBox();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Adet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbl_DemirbasAciklama = new System.Windows.Forms.Label();
            this.lbl_SeciliUrun = new System.Windows.Forms.Label();
            this.lbl_DemirbasAdet = new System.Windows.Forms.Label();
            this.lbl_DemirbasKod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Sirket = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_Demirbas)).BeginInit();
            this.grp_Demirbas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Size = new System.Drawing.Size(1139, 69);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 599);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1139, 28);
            // 
            // grp_Demirbas
            // 
            this.grp_Demirbas.Controls.Add(this.cmb_Sirket);
            this.grp_Demirbas.Controls.Add(this.label1);
            this.grp_Demirbas.Controls.Add(this.btn_DemirbasEkle);
            this.grp_Demirbas.Controls.Add(this.cmb_Departments);
            this.grp_Demirbas.Controls.Add(this.txt_Aciklama);
            this.grp_Demirbas.Controls.Add(this.label4);
            this.grp_Demirbas.Controls.Add(this.txt_Adet);
            this.grp_Demirbas.Controls.Add(this.label3);
            this.grp_Demirbas.Controls.Add(this.label2);
            this.grp_Demirbas.Location = new System.Drawing.Point(12, 82);
            this.grp_Demirbas.Name = "grp_Demirbas";
            this.grp_Demirbas.Size = new System.Drawing.Size(635, 484);
            this.grp_Demirbas.TabIndex = 6;
            this.grp_Demirbas.Text = "Demirbaş Düzenle";
            // 
            // btn_DemirbasEkle
            // 
            this.btn_DemirbasEkle.Location = new System.Drawing.Point(295, 418);
            this.btn_DemirbasEkle.Name = "btn_DemirbasEkle";
            this.btn_DemirbasEkle.Size = new System.Drawing.Size(148, 44);
            this.btn_DemirbasEkle.TabIndex = 6;
            this.btn_DemirbasEkle.Text = "Demirbaşı Güncelle";
            this.btn_DemirbasEkle.Click += new System.EventHandler(this.btn_DemirbasEkle_Click);
            // 
            // cmb_Departments
            // 
            this.cmb_Departments.DisplayMember = "DepartmentId";
            this.cmb_Departments.FormattingEnabled = true;
            this.cmb_Departments.Location = new System.Drawing.Point(190, 141);
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
            // txt_Adet
            // 
            this.txt_Adet.Location = new System.Drawing.Point(190, 206);
            this.txt_Adet.Name = "txt_Adet";
            this.txt_Adet.Size = new System.Drawing.Size(148, 23);
            this.txt_Adet.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Demirbaş Adedi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Departman";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbl_DemirbasAciklama);
            this.groupControl1.Controls.Add(this.lbl_SeciliUrun);
            this.groupControl1.Controls.Add(this.lbl_DemirbasAdet);
            this.groupControl1.Controls.Add(this.lbl_DemirbasKod);
            this.groupControl1.Location = new System.Drawing.Point(668, 82);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(435, 484);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Düzenlenen Demirbaş";
            // 
            // lbl_DemirbasAciklama
            // 
            this.lbl_DemirbasAciklama.AutoSize = true;
            this.lbl_DemirbasAciklama.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbl_DemirbasAciklama.Location = new System.Drawing.Point(28, 156);
            this.lbl_DemirbasAciklama.Name = "lbl_DemirbasAciklama";
            this.lbl_DemirbasAciklama.Size = new System.Drawing.Size(155, 17);
            this.lbl_DemirbasAciklama.TabIndex = 3;
            this.lbl_DemirbasAciklama.Text = "Demirbaş Açıklaması: ";
            // 
            // lbl_SeciliUrun
            // 
            this.lbl_SeciliUrun.AutoSize = true;
            this.lbl_SeciliUrun.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbl_SeciliUrun.Location = new System.Drawing.Point(28, 123);
            this.lbl_SeciliUrun.Name = "lbl_SeciliUrun";
            this.lbl_SeciliUrun.Size = new System.Drawing.Size(102, 17);
            this.lbl_SeciliUrun.TabIndex = 3;
            this.lbl_SeciliUrun.Text = "Seçilen Ürün: ";
            // 
            // lbl_DemirbasAdet
            // 
            this.lbl_DemirbasAdet.AutoSize = true;
            this.lbl_DemirbasAdet.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbl_DemirbasAdet.Location = new System.Drawing.Point(28, 90);
            this.lbl_DemirbasAdet.Name = "lbl_DemirbasAdet";
            this.lbl_DemirbasAdet.Size = new System.Drawing.Size(124, 17);
            this.lbl_DemirbasAdet.TabIndex = 3;
            this.lbl_DemirbasAdet.Text = "Demirbaş Adedi: ";
            // 
            // lbl_DemirbasKod
            // 
            this.lbl_DemirbasKod.AutoSize = true;
            this.lbl_DemirbasKod.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbl_DemirbasKod.Location = new System.Drawing.Point(28, 57);
            this.lbl_DemirbasKod.Name = "lbl_DemirbasKod";
            this.lbl_DemirbasKod.Size = new System.Drawing.Size(122, 17);
            this.lbl_DemirbasKod.TabIndex = 3;
            this.lbl_DemirbasKod.Text = "Demirbaş Kodu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sirket";
            // 
            // cmb_Sirket
            // 
            this.cmb_Sirket.DisplayMember = "SirketId";
            this.cmb_Sirket.FormattingEnabled = true;
            this.cmb_Sirket.Location = new System.Drawing.Point(190, 87);
            this.cmb_Sirket.Name = "cmb_Sirket";
            this.cmb_Sirket.Size = new System.Drawing.Size(148, 24);
            this.cmb_Sirket.TabIndex = 8;
            this.cmb_Sirket.ValueMember = "SirketId";
            this.cmb_Sirket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Sirket_KeyDown);
            // 
            // DemirbasDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 627);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grp_Demirbas);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "DemirbasDuzenleForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "DemirbasDuzenleForm";
            this.Load += new System.EventHandler(this.DemirbasDuzenleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_Demirbas)).EndInit();
            this.grp_Demirbas.ResumeLayout(false);
            this.grp_Demirbas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraEditors.GroupControl grp_Demirbas;
        private DevExpress.XtraEditors.SimpleButton btn_DemirbasEkle;
        private System.Windows.Forms.ComboBox cmb_Departments;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Adet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label lbl_DemirbasAciklama;
        private System.Windows.Forms.Label lbl_SeciliUrun;
        private System.Windows.Forms.Label lbl_DemirbasAdet;
        private System.Windows.Forms.Label lbl_DemirbasKod;
        private System.Windows.Forms.ComboBox cmb_Sirket;
        private System.Windows.Forms.Label label1;
    }
}