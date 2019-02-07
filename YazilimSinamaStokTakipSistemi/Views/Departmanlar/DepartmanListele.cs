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
using YazilimSinamaStokTakipSistemi.Views.Demirbaşlar;
using YazilimSinamaStokTakipSistemi.Views.Raporlar;

namespace YazilimSinamaStokTakipSistemi.Views.Departmanlar
{
    public partial class DepartmanListele : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DepartmanListele()
        {
            InitializeComponent();
        }

        private int departmanId;

        private void btn_DepartmanTanimla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DepartmanEkleForm adForm = new DepartmanEkleForm();
            this.Close();
            adForm.Show();
        }

        private void DepartmanListele_Load(object sender, EventArgs e)
        {
            if (LoginForm._session == eRoller.SatisSorumlusu.ToString())
            {
                btn_DepartmanTanimla.Enabled = false;
            }
            var result = DepartmanController.TumDepartmanlariGetir();
            var departmanListesi = DepartmanController.TumDepartmanlariGetir();
            DataTable dtBitenStokList = new DataTable("departmanListesi");
            dtBitenStokList.Columns.Add("DepartmanId", typeof(int));
            dtBitenStokList.Columns.Add("DepartmanAdi", typeof(string));
            dtBitenStokList.Columns.Add("SirketAdi", typeof(string));
            foreach (var item in departmanListesi)
            {
                dtBitenStokList.Rows.Add(item.Departman.DepartmanId, item.Departman.DepartmanAdi/*,item.Departman.Sirketler.SirketAdi*/);
            }
            grid_DepartmanListesi.DataSource = dtBitenStokList;
           // gridView_DepartmanListesi.Columns["departmanId"].Visible = false;
        }

        private void gridView_DepartmanListesi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string departmanAdi = gridView_DepartmanListesi.GetRowCellValue(gridView_DepartmanListesi.FocusedRowHandle, "departmanAdi").ToString();
            departmanId = Convert.ToInt32(gridView_DepartmanListesi.GetRowCellValue(gridView_DepartmanListesi.FocusedRowHandle, "departmanId"));
            DialogResult sonuc = MessageBox.Show(departmanAdi + " İsimli Departman Detaylarına Bakmak İçin Evet \n Departman Demirbaş Listesini Görmek İçin Hayır'ı Seçin !", "Öneri ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                DepartmanDuzenleForm erForm = new DepartmanDuzenleForm(departmanId);
                this.Close();
                erForm.Show();
            }
            else if (sonuc == DialogResult.No)
            {
                DepartmanZimmetGetirForm ozGetirForm = new DepartmanZimmetGetirForm(departmanId);
                this.Close();
                ozGetirForm.Show();
            }
        }
    }
}