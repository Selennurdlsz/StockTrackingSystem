using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using YazilimSinamaStokTakipSistemi.Controller;
using YazilimSinamaStokTakipSistemi.Model;

namespace YazilimSinamaStokTakipSistemi.Views.Departmanlar
{
    public partial class DepartmanDuzenleForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _departmanId;
        public DepartmanDuzenleForm(int departmanId)
        {
            if (departmanId == 0) return;
            this._departmanId = departmanId;

            InitializeComponent();
        }

        private void btn_DepartmanDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (personelId == 0)
                {
                    throw new Exception("Kişi Seçmediniz !");

                }
                if (string.IsNullOrEmpty(txt_DepartmanAdi.Text))
                {
                    throw new Exception("Oda Adı Boş Geçilemez !");
                }
                DepartmanController.DepartmanGuncelle(this._departmanId, txt_DepartmanAdi.Text, personelId);
                MessageBox.Show("Güncelleme Başarılı !", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_DepartmanListele_ItemClick(object sender, ItemClickEventArgs e)
        {
            DepartmanListele rlForm = new DepartmanListele();
            this.Close();
            rlForm.Show();
        }

        private void btn_Ekle_ItemClick(object sender, ItemClickEventArgs e)
        {
            //AddRoomForm arForm=new AddRoomForm();
            //this.Close();
            //arForm.Show();
        }

        private void DepartmanDuzenleForm_Load(object sender, EventArgs e)
        {
            if (LoginForm._session == eRoller.SatisSorumlusu.ToString())
            {
                btn_Ekle.Enabled = false;
                btn_DepartmanSil.Enabled = false;
            }
            Tools.ComboBoxSirketGetir(cmb_Sirket);
            var result = DepartmanController.DepartmanDetayiGetir(_departmanId);
            txt_DepartmanAdi.Text = result.Departman.DepartmanAdi;
            cmb_Sirket.SelectedValue = result.Departman.Sirketler.SirketId;
            cmb_Departman.SelectedValue = result.Departman.DepartmanId;
            var kullanicilariListele = PersonelController.KullanicilariListele();
            DataTable dtKullancilar = new DataTable("personeller");
            dtKullancilar.Columns.Add("Ad", typeof(string));
            dtKullancilar.Columns.Add("Soyad", typeof(string));
            dtKullancilar.Columns.Add("PersonelId", typeof(int));
            foreach (var item in kullanicilariListele)
            {
                dtKullancilar.Rows.Add(item.Ad, item.Soyad, item.PersonelId);
            }
            grid_Kisiler.DataSource = dtKullancilar;
        }

        private int personelId;

        private void btn_DepartmanSil_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DialogResult sonuc = MessageBox.Show("Departman Silinecektir !", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (sonuc == DialogResult.Yes)
                {
                    DepartmanController.DepartmanSil(_departmanId);
                    MessageBox.Show("Departman Silindi !\nDepartmanlar Listesine Yönlendiriliyorsunuz !", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread.Sleep(500);
                    DepartmanListele rlForm = new DepartmanListele();
                    this.Close();
                    rlForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Departmana Bağlı Zimmetler Vardır Departma Silinemez  !", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView_Kisiler_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            personelId = Convert.ToInt32(gridView_Kisiler.GetRowCellValue(gridView_Kisiler.FocusedRowHandle, "PersonelId"));
        }

        private void cmb_Sirket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Sirket.SelectedIndex == -1) return;
            int sirketId = int.Parse(cmb_Sirket.SelectedValue.ToString());
            Tools.ComboBoxBolumGetir(cmb_Departman, sirketId);
        }
    }
}