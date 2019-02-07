using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using YazilimSinamaStokTakipSistemi.Controller;
using YazilimSinamaStokTakipSistemi.Views.Demirbaşlar;

namespace YazilimSinamaStokTakipSistemi.Views.Departmanlar
{
    public partial class DepartmanSorumluListeleForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DepartmanSorumluListeleForm()
        {
            InitializeComponent();
        }

        public static string departmanAdi { get; set; }
        public static string departmanSorumlusu { get; set; }

        private void gridView_DepartmanYetkilileri_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            departmanAdi = gridView_DepartmanYetkilileri.GetRowCellValue(gridView_DepartmanYetkilileri.FocusedRowHandle, "DepartmanAdi")
                .ToString();
            departmanSorumlusu = gridView_DepartmanYetkilileri.GetRowCellValue(gridView_DepartmanYetkilileri.FocusedRowHandle, "AdSoyad")
                .ToString();
            int odaId = Convert.ToInt32(gridView_DepartmanYetkilileri.GetRowCellValue(gridView_DepartmanYetkilileri.FocusedRowHandle, "DepartmanId").ToString());
            DepartmanZimmetGetirForm ozgForm = new DepartmanZimmetGetirForm(odaId);
            ozgForm.ShowDialog();
        }

        private void DepartmanSorumluListeleForm_Load(object sender, EventArgs e)
        {
            var result = DepartmanPersonelController.DepartmanSorumlulariListele();
            DataTable dt = new DataTable("departmanSorumlulari");
            dt.Columns.Add("AdSoyad", typeof(string));
            dt.Columns.Add("PersonelId", typeof(int));
            dt.Columns.Add("DepartmanAdi", typeof(string));
            dt.Columns.Add("DepartmanId", typeof(int));
            foreach (var item in result)
            {
                dt.Rows.Add(item.Personel.Ad + " " + item.Personel.Soyad, item.Personel.PersonelId, item.Departman.DepartmanAdi, item.Departman.DepartmanId);
            }
            grid_DepartmanYetkilileri.DataSource = dt;
            gridView_DepartmanYetkilileri.Columns["DepartmanId"].Visible = false;
            gridView_DepartmanYetkilileri.Columns["PersonelId"].Visible = false;
        }

        /*private void btn_DepartmanTanimla_ItemClick(object sender, ItemClickEventArgs e)
        {
        }*/
    }
}