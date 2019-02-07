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
using YazilimSinamaStokTakipSistemi.Views.Departmanlar;
using YazilimSinamaStokTakipSistemi.Views.Personeller;
using YazilimSinamaStokTakipSistemi.Views.Urun;

namespace YazilimSinamaStokTakipSistemi.Views.Users
{
    public partial class DepartmanYetkilisiIslevleriForm : DevExpress.XtraEditors.XtraForm
    {
        public DepartmanYetkilisiIslevleriForm()
        {
            InitializeComponent();
        }

        //DemirbaslariListele formu
        //Demirbaşlarını listeler
        private void btn_DemirbasListele_ItemClick(object sender, TileItemEventArgs e)
        {
            DemirbaslariListeleForm DLF = new DemirbaslariListeleForm();
            DLF.ShowDialog();
        }

        //DepartmaSorumluListele formu
        //Departman sorumlularını listeler
        private void btn_DepartmanSorumluListele_ItemClick(object sender, TileItemEventArgs e)
        {
            DepartmanSorumluListeleForm DSLF = new DepartmanSorumluListeleForm();
            DSLF.ShowDialog();
        }

        //PersonelListe formu
        //Personel listesini gösterir
        private void btn_PersonelIslem_ItemClick(object sender, TileItemEventArgs e)
        {
            PersonelListeForm plForm = new PersonelListeForm();
            plForm.ShowDialog(); 
        }
        
        //UrunStokListe formu
        //Urun stoklarını listeler
        private void btn_StokListele_ItemClick(object sender, TileItemEventArgs e)
        {
            UrunStokListeForm pslForm=new UrunStokListeForm();
            pslForm.ShowDialog();
        }

        //Uygulamayı kapatır
        private void btnCikis_ItemClick(object sender, TileItemEventArgs e)
        {
            Application.Exit();
        }
    }
}