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
using YazilimSinamaStokTakipSistemi.Views.Demirbaşlar;

namespace YazilimSinamaStokTakipSistemi.Views.PersonelDetay
{
    public partial class PersonelDetayForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int kisiId;
        public PersonelDetayForm(int kisiId)
        {
            if (kisiId == 0) return;
            this.kisiId = kisiId;
            InitializeComponent();
        }

        private void PersonelDetayForm_Load(object sender, EventArgs e)
        {
            var result = PersonelController.PersonelGetir(kisiId);
            lbl_AdSoyad.Text = "Ad Soyad: " + result.Personel.Ad + " " + result.Personel.Soyad;
            lbl_KullaniciAdi.Text = "Kullanıcı Adı: " + result.Kullanici.KullaniciAdi;
            lbl_Rol.Text = "Kullanıcı Türü: " + result.Rol.RolAdi;


            var result2 = PersonelController.KullaniciSorumluDepartmanlar(kisiId);
            DataTable dt = new DataTable();
            dt.Columns.Add("DepartmanId", typeof(int));
            dt.Columns.Add("DepartmanAdi", typeof(string));
            dt.Columns.Add("AdSoyad", typeof(string));
            foreach (var item in result2)
            {
                dt.Rows.Add(item.Departman.DepartmanId, item.Departman.DepartmanAdi, item.Personel.Ad + " " + item.Personel.Soyad);
            }
            grid_PersonelDepartman.DataSource = dt;
            gridView_personelDepartman.Columns["DepartmanId"].Visible = false;

            var result1 = PersonelController.KullaniciZimmetleri(kisiId);
            DataTable dtDemirbas = new DataTable();
            dtDemirbas.Columns.Add("DemirbasKodu", typeof(string));
            dtDemirbas.Columns.Add("DemirbasAdi", typeof(string));
            foreach (var item in result1)
            {
                dtDemirbas.Rows.Add(item.Demirbas.DemirbasKodu, item.Demirbas.DemirbasAdi);
            }
            grid_personeldemirbas.DataSource = dtDemirbas;
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

        public static string DepartmanAdi { get; set; }
        public static string SorumluAdi { get; set; }

        private void gridView_personelDepartman_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DepartmanAdi = gridView_personelDepartman.GetRowCellValue(gridView_personelDepartman.FocusedRowHandle, "DepartmanAdi").ToString();
            SorumluAdi = gridView_personelDepartman.GetRowCellValue(gridView_personelDepartman.FocusedRowHandle, "AdSoyad").ToString();
            int departmanId = Convert.ToInt32(gridView_personelDepartman.GetRowCellValue(gridView_personelDepartman.FocusedRowHandle, "DepartmanId"));
            DepartmanZimmetGetirForm ozgForm = new DepartmanZimmetGetirForm(departmanId);
            ozgForm.ShowDialog();
        }
    }
}