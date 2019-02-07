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
using YazilimSinamaStokTakipSistemi.Views.PersonelDetay;

namespace YazilimSinamaStokTakipSistemi.Views.Personeller
{
    public partial class PersonelListeForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PersonelListeForm()
        {
            InitializeComponent();
        }

        private void PersonelListeForm_Load(object sender, EventArgs e)
        {
            var result = PersonelController.KullanicilariListele();
            DataTable dtKullancilar = new DataTable("personller");
            dtKullancilar.Columns.Add("Ad", typeof(string));
            dtKullancilar.Columns.Add("Soyad", typeof(string));
            dtKullancilar.Columns.Add("PersonelId", typeof(int));
            foreach (var item in result)
            {
                dtKullancilar.Rows.Add(item.Ad, item.Soyad, item.PersonelId);
            }
            grid_Personel.DataSource = dtKullancilar;
            gridView_Personel.Columns["PersonelId"].Visible = false;
        }

        private void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
        }

        private void barSubItemNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            navBarControl.ActiveGroup = navBarControl.Groups[barItemIndex];
        }

        private void gridView_Personel_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int kisiId = Convert.ToInt32(gridView_Personel.GetRowCellValue(gridView_Personel.FocusedRowHandle, "PersonelId"));
            string kisiAdi = gridView_Personel.GetRowCellValue(gridView_Personel.FocusedRowHandle, "Ad") + " " + gridView_Personel.GetRowCellValue(gridView_Personel.FocusedRowHandle, "Soyad");
            DialogResult sonuc = MessageBox.Show(kisiAdi + " Detaylarına Bakmak İster Misiniz?", "Öneri ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                PersonelDetayForm pdForm = new PersonelDetayForm(kisiId);
                this.Close();
                pdForm.Show();
            }
        }
    }
}