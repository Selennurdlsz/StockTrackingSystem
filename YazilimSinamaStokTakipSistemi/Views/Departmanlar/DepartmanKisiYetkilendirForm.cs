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

namespace YazilimSinamaStokTakipSistemi.Views.Departmanlar
{
    public partial class DepartmanKisiYetkilendirForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DepartmanKisiYetkilendirForm()
        {
            InitializeComponent();
        }

        private int personelId, departmanId;

        private void DepartmanKisiYetkilendirForm_Load(object sender, EventArgs e)
        {
            var DepartmanlarListesi = DepartmanController.TumDepartmanlariGetir();
            DataTable dtBitenStokList = new DataTable("departmanListesi");
            dtBitenStokList.Columns.Add("DepartmanId", typeof(int));
            dtBitenStokList.Columns.Add("DepartmanAdi", typeof(string));
            dtBitenStokList.Columns.Add("SirketAdi", typeof(string));
            foreach (var item in DepartmanlarListesi)
            {
                dtBitenStokList.Rows.Add(item.Departman.DepartmanId, item.Departman.DepartmanAdi/*,item.Departman.Sirketler.SirketAdi*/);
            }
            grid_DepartmanListesi.DataSource = dtBitenStokList;
           // gridView_DepartmanListesi.Columns["departmanId"].Visible = false;

            var kullanicilariListele = PersonelController.KullanicilariListele();
            DataTable dtKullancilar = new DataTable("personeller");
            dtKullancilar.Columns.Add("Ad", typeof(string));
            dtKullancilar.Columns.Add("Soyad", typeof(string));
            dtKullancilar.Columns.Add("PersonelId", typeof(int));
            foreach (var item in kullanicilariListele)
            {
                dtKullancilar.Rows.Add(item.Ad, item.Soyad, item.PersonelId);
            }
            grid_personelListesi.DataSource = dtKullancilar;
        }

        private void gridView_personelListesi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string personelAdi = gridView_personelListesi.GetRowCellValue(gridView_personelListesi.FocusedRowHandle, "Ad") + " " + gridView_personelListesi.GetRowCellValue(gridView_personelListesi.FocusedRowHandle, "Soyad").ToString();
            lbl_PersonelBilgi.Text = personelAdi;
            personelId = Convert.ToInt32(gridView_personelListesi.GetRowCellValue(gridView_personelListesi.FocusedRowHandle, "PersonelId"));
        }

        private void gridView_DepartmanListesi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string DepartmanAdi = gridView_DepartmanListesi.GetRowCellValue(gridView_DepartmanListesi.FocusedRowHandle, "departmanAdi").ToString();
            lbl_DepartmanAdi.Text = DepartmanAdi;
            departmanId = Convert.ToInt32(gridView_DepartmanListesi.GetRowCellValue(gridView_DepartmanListesi.FocusedRowHandle, "departmanId"));
        }

        private void btn_Yetkilendir_Click(object sender, EventArgs e)
        {
            try
            {
                if (personelId == 0 || departmanId == 0)
                {
                    throw new Exception("Kişi veya Oda Seçmediniz Lütfen Kontrol Edin !");
                }
                DepartmanController.DepartmanYetkilendir(personelId, departmanId);
                MessageBox.Show("Yetkilendirme Başarılı !", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}