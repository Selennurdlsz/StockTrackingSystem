namespace YazilimSinamaStokTakipSistemi.Views.Departmanlar
{
    partial class DepartmanSorumluListeleForm
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
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.grid_DepartmanYetkilileri = new DevExpress.XtraGrid.GridControl();
            this.gridView_DepartmanYetkilileri = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DepartmanYetkilileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DepartmanYetkilileri)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(907, 69);
            this.ribbon.StatusBar = this.ribbonStatusBar1;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 575);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbon;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(907, 40);
            // 
            // grid_DepartmanYetkilileri
            // 
            this.grid_DepartmanYetkilileri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_DepartmanYetkilileri.Location = new System.Drawing.Point(0, 69);
            this.grid_DepartmanYetkilileri.MainView = this.gridView_DepartmanYetkilileri;
            this.grid_DepartmanYetkilileri.MenuManager = this.ribbon;
            this.grid_DepartmanYetkilileri.Name = "grid_DepartmanYetkilileri";
            this.grid_DepartmanYetkilileri.Size = new System.Drawing.Size(907, 506);
            this.grid_DepartmanYetkilileri.TabIndex = 5;
            this.grid_DepartmanYetkilileri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DepartmanYetkilileri});
            // 
            // gridView_DepartmanYetkilileri
            // 
            this.gridView_DepartmanYetkilileri.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_DepartmanYetkilileri.GridControl = this.grid_DepartmanYetkilileri;
            this.gridView_DepartmanYetkilileri.Name = "gridView_DepartmanYetkilileri";
            this.gridView_DepartmanYetkilileri.OptionsBehavior.Editable = false;
            this.gridView_DepartmanYetkilileri.OptionsBehavior.ReadOnly = true;
            this.gridView_DepartmanYetkilileri.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_DepartmanYetkilileri_RowClick);
            // 
            // DepartmanSorumluListeleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 615);
            this.Controls.Add(this.grid_DepartmanYetkilileri);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbon);
            this.Name = "DepartmanSorumluListeleForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "DepartmanSorumluListeleForm";
            this.Load += new System.EventHandler(this.DepartmanSorumluListeleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DepartmanYetkilileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DepartmanYetkilileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraGrid.GridControl grid_DepartmanYetkilileri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DepartmanYetkilileri;
    }
}