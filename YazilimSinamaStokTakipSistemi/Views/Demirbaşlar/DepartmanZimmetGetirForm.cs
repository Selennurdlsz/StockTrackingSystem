using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraExport;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.ReportGeneration;
using DevExpress.XtraReports.UI;
using YazilimSinamaStokTakipSistemi.Controller;
using YazilimSinamaStokTakipSistemi.Views.Personeller;
using YazilimSinamaStokTakipSistemi.Views.Departmanlar;
using DevExpress.XtraSpreadsheet;
using Binding = System.Windows.Forms.Binding;

namespace YazilimSinamaStokTakipSistemi.Views.Demirbaşlar
{
    public partial class DepartmanZimmetGetirForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _departmanId;
        public DepartmanZimmetGetirForm(int departmanId)
        {
            if (departmanId == 0) return;
            this._departmanId = departmanId;
            InitializeComponent();
        }

        private void gridView_DepartmanDemirbaslari_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int demirbasDepartmanNo = Convert.ToInt32(gridView_DepartmanDemirbaslari.GetRowCellValue(gridView_DepartmanDemirbaslari.FocusedRowHandle, "DemirbasDepartmanId").ToString());
            string demirbasAdi = gridView_DepartmanDemirbaslari.GetRowCellValue(gridView_DepartmanDemirbaslari.FocusedRowHandle, "DemirbasAdi").ToString();
            DialogResult sonuc = MessageBox.Show(demirbasAdi + " Demirbaşı Silinsin Mi?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                DepartmanPersonelController.departmanDemirbasSil(demirbasDepartmanNo);
                GetValue();
            }
        }

        private void DepartmanZimmetGetirForm_Load(object sender, EventArgs e)
        {
            var departmanAdi = DepartmanController.DepartmanDetayiGetir(_departmanId);
            var personelAdi = DepartmanPersonelController.DepartmanSorumlulariListele().FirstOrDefault(x => x.Departman.DepartmanId == _departmanId);
            lbl_DepartmanAdi.Text = "Departman Adı: " + departmanAdi.Departman.DepartmanAdi;
            lbl_DepartmanSorumlu.Text = "Departman Sorumlusu: " + personelAdi.Personel.Ad + " " + personelAdi.Personel.Soyad;
            GetValue();
        }

        private void GetValue()
        {
            var result = DepartmanController.DepartmanDemirbaslariList(_departmanId);
            grid_DepartmanDemirbaslari.DataSource = result;

            gridView_DepartmanDemirbaslari.Columns["DemirbasDepartmanId"].Visible = false;
            gridView_DepartmanDemirbaslari.IndicatorWidth = 30;
        }

        private void barButtonPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DokumAl("pdf");
        }

        private void DokumAl(string belgeTip)
        {
            /**Gelen Oda Zimmetlerini PDF veya Excel formatında dökümünün alınmasını sağlayan kod*/
            string[] sorumluAdi = lbl_DepartmanSorumlu.Text.Split(':');
            string[] departmanBilgi = lbl_DepartmanAdi.Text.Split(':');
            DataTable dtZimmet = new DataTable();
            dtZimmet.Columns.Add("SiraNo", typeof(int));
            dtZimmet.Columns.Add("DemirbasKodu", typeof(string));
            dtZimmet.Columns.Add("DemirbasAdi", typeof(string));
            dtZimmet.Columns.Add("Adet", typeof(int));
            dtZimmet.Columns.Add("ZimmetSahibi", typeof(string));
            GridControl grid = new GridControl();
            GridView view = new GridView();

            grid.ViewCollection.Add(view);
            grid.MainView = view;
            view.GridControl = grid;
            GridColumn siraNo = view.Columns.Add();
            GridColumn demirbasKod = view.Columns.Add();
            GridColumn demirbasAdi = view.Columns.Add();
            GridColumn demirbasAdet = view.Columns.Add();
            GridColumn sorumlu = view.Columns.Add();
            int siraSayac = 1;
            for (int i = 0; i < gridView_DepartmanDemirbaslari.DataRowCount; i++)
            {

                dtZimmet.Rows.Add(siraSayac++,
                    gridView_DepartmanDemirbaslari.GetRowCellValue(i, "DemirbasKodu")
                        .ToString(),
                    gridView_DepartmanDemirbaslari.GetRowCellValue(i, "DemirbasAdi")
                        .ToString(),
                    gridView_DepartmanDemirbaslari.GetRowCellValue(i, "Adet")
                        .ToString(), sorumluAdi[1]);
            }

            sorumlu.Caption = "ZimmetSahibi";
            sorumlu.FieldName = "ZimmetSahibi";
            sorumlu.VisibleIndex = 0;
            sorumlu.Visible = true;

            demirbasAdet.Caption = "Adet";
            demirbasAdet.FieldName = "Adet";
            demirbasAdet.VisibleIndex = 0;
            demirbasAdet.Visible = true;

            demirbasAdi.Caption = "DemirbasAdi";
            demirbasAdi.FieldName = "DemirbasAdi";
            demirbasAdi.VisibleIndex = 0;
            demirbasAdi.Visible = true;

            demirbasKod.Caption = "DemirbasKodu";
            demirbasKod.FieldName = "DemirbasKodu";
            demirbasKod.VisibleIndex = 0;
            demirbasKod.Visible = true;

            siraNo.Caption = "SiraNo";
            siraNo.FieldName = "SiraNo";
            siraNo.VisibleIndex = 0;
            siraNo.Visible = true;

            grid.BindingContext = this.BindingContext;
            grid.DataSource = dtZimmet;
            if (belgeTip == "pdf")
            {
                grid.ExportToPdf("D:\\" + departmanBilgi[1] + "." + belgeTip);
            }
            else
            {
                grid.ExportToXlsx("D:\\" + departmanBilgi[1] + "." + belgeTip);
            }
            MessageBox.Show("Yerel Disk D üzerine Oda Zimmet Raporu Oluşturuldu !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView_DepartmanDemirbaslari_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = e.RowHandle.ToString();
        }

        private void barButtonExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DokumAl("xlsx");
        }
    }
}