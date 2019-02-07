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
using YazilimSinamaStokTakipSistemi.Views.Demirbaşlar;
using YazilimSinamaStokTakipSistemi.Views.Personeller;
using YazilimSinamaStokTakipSistemi.Views.Urun;
using YazilimSinamaStokTakipSistemi.Views.Raporlar;
using YazilimSinamaStokTakipSistemi.Views.Departmanlar;

namespace YazilimSinamaStokTakipSistemi.Views
{
    public partial class AdminIslevleri : DevExpress.XtraEditors.XtraForm
    {
        public AdminIslevleri()
        {
            InitializeComponent();
        }

        //UrunEkle formu 
        //Stoğa ürün ekler
        private void btn_StokGirisi_ItemClick(object sender, TileItemEventArgs e)
        {
            UrunEkleForm frm = new UrunEkleForm();
            frm.ShowDialog();
        }

        //UurunStokListele Formu  
        //Stoktaki ürünleri gösterir
        private void btn_StokListele_ItemClick(object sender, TileItemEventArgs e)
        {
            UrunStokListeForm psListForm = new UrunStokListeForm();
            psListForm.ShowDialog();
        }

        //Raporlar formu
        //Daire grafiğini gösterir
        private void btn_RaporIslem_ItemClick(object sender, TileItemEventArgs e)
        {
            RaporlarForm rpForm = new RaporlarForm();
            rpForm.ShowDialog();
        }

        //DemirbasUurunEkle formu
        //Demirbaş olacak ürünü ekler
        private void btn_DemirbasEkle_ItemClick(object sender, TileItemEventArgs e)
        {
            DemirbasUrunEkleForm fpAddForm = new DemirbasUrunEkleForm();
            fpAddForm.ShowDialog();
        }

        //DemirbaşListele formu
        //Demirbaşların listesini gösterir
        private void btn_DemirbasListele_ItemClick(object sender, TileItemEventArgs e)
        {
            DemirbaslariListeleForm flForm = new DemirbaslariListeleForm();
            flForm.ShowDialog();
        }

        //PersonelListe formu
        //Personel listesini gösterir
        private void btn_PersonelIslem_ItemClick(object sender, TileItemEventArgs e)
        {
            PersonelListeForm plForm = new PersonelListeForm();
            plForm.ShowDialog();
        }

        //DepartmanEkle formu
        //Departman ekler
        private void btn_OdaTanimla_ItemClick(object sender, TileItemEventArgs e)
        {
            DepartmanEkleForm roomsForm = new DepartmanEkleForm();
            roomsForm.ShowDialog();
        }

        //DepartmanListele formu
        //Departmanları listeler
        private void btn_OdaListele_ItemClick(object sender, TileItemEventArgs e)
        {
            DepartmanListele DListForm = new DepartmanListele();
            DListForm.ShowDialog();
        }

        //Uygulamayı kapatır
        private void btnCikis_ItemClick(object sender, TileItemEventArgs e)
        {
            Application.Exit();
        }

        //DepartmanSorumluListele formu
        //Departman sorumlularını listeler
        private void btn_DepartmanSorumluListele_ItemClick(object sender, TileItemEventArgs e)
        {
            DepartmanSorumluListeleForm lfaForm = new DepartmanSorumluListeleForm();
            lfaForm.ShowDialog();
        }
        
        //PersonelEkle formu
        //Personel ekler
        private void btnPersonelEkle_ItemClick(object sender, TileItemEventArgs e)
        {
            PersonelEkle Form = new PersonelEkle();
            Form.ShowDialog();
        }
    }
}