namespace YazilimSinamaStokTakipSistemi.Views.Personeller
{
    partial class PersonelEkle
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
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_PersonelSoyadi = new System.Windows.Forms.TextBox();
            this.txt_PersonelAdi = new System.Windows.Forms.TextBox();
            this.btn_PersonelEkle = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(721, 185);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Personel Ekle";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 630);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(721, 28);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Silver;
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.Teal;
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.txt_PersonelSoyadi);
            this.groupControl1.Controls.Add(this.txt_PersonelAdi);
            this.groupControl1.Controls.Add(this.btn_PersonelEkle);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(74, 216);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(579, 291);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Personel Ekle";
            // 
            // txt_PersonelSoyadi
            // 
            this.txt_PersonelSoyadi.Location = new System.Drawing.Point(209, 143);
            this.txt_PersonelSoyadi.Name = "txt_PersonelSoyadi";
            this.txt_PersonelSoyadi.Size = new System.Drawing.Size(280, 23);
            this.txt_PersonelSoyadi.TabIndex = 9;
            // 
            // txt_PersonelAdi
            // 
            this.txt_PersonelAdi.Location = new System.Drawing.Point(209, 64);
            this.txt_PersonelAdi.Name = "txt_PersonelAdi";
            this.txt_PersonelAdi.Size = new System.Drawing.Size(280, 23);
            this.txt_PersonelAdi.TabIndex = 9;
            // 
            // btn_PersonelEkle
            // 
            this.btn_PersonelEkle.Location = new System.Drawing.Point(209, 218);
            this.btn_PersonelEkle.Name = "btn_PersonelEkle";
            this.btn_PersonelEkle.Size = new System.Drawing.Size(102, 38);
            this.btn_PersonelEkle.TabIndex = 16;
            this.btn_PersonelEkle.Text = "Personel Ekle";
            this.btn_PersonelEkle.Click += new System.EventHandler(this.btn_PersonelEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Personel Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Personel Adı";
            // 
            // PersonelEkle
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 658);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "PersonelEkle";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "PersonelEkle";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txt_PersonelSoyadi;
        private System.Windows.Forms.TextBox txt_PersonelAdi;
        private DevExpress.XtraEditors.SimpleButton btn_PersonelEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}