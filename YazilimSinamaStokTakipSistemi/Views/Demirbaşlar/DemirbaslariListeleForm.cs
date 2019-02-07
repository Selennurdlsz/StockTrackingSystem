using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using YazilimSinamaStokTakipSistemi.Controller;
using YazilimSinamaStokTakipSistemi.Model;

namespace YazilimSinamaStokTakipSistemi.Views.Demirbaşlar
{
    public partial class DemirbaslariListeleForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DemirbaslariListeleForm()
        {
            InitializeComponent();
          
        }

        public static int _fixtureId { get; set; }

        private void btn_Duzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DemirbasDuzenleForm ddf = new DemirbasDuzenleForm(_fixtureId);
            ddf.ShowDialog();
        }

        private void btn_Sil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DialogResult sonuc = MessageBox.Show(lbl_SeciliUrun.Text + " İsimli Demirbaş Silinecektir !", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (sonuc == DialogResult.Yes)
                {
                    DemirbasController.DemirbasSil(_fixtureId);
                    Tools.DemirbaslariGrideDoldur(grid_Demirbaslar, gridView_Demirbaslar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DemirbaslariListeleForm_Load(object sender, EventArgs e)
        {
            if (LoginForm._session == eRoller.DepartmanYetkilisi.ToString())
            {
                btn_Sil.Enabled = btn_Duzenle.Enabled = false;
            }
            Tools.DemirbaslariGrideDoldur(grid_Demirbaslar, gridView_Demirbaslar);
            lbl_Toplam.Text += gridView_Demirbaslar.RowCount.ToString() + " Adet";
        }

        private void gridView_Demirbaslar_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string secilenUrun = gridView_Demirbaslar.GetRowCellValue(gridView_Demirbaslar.FocusedRowHandle, "DemirbasAdi").ToString();
            _fixtureId = int.Parse(gridView_Demirbaslar.GetRowCellValue(gridView_Demirbaslar.FocusedRowHandle, "DemirbasNo").ToString());
            lbl_SeciliUrun.Text = secilenUrun.Length >= 20 ? "Seçilen Ürün: " + secilenUrun.Substring(0, 19) + "..." : "Seçilen Ürün: " + secilenUrun;
        }
    }
}