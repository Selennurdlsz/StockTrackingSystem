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
using YazilimSinamaStokTakipSistemi.Model;

namespace YazilimSinamaStokTakipSistemi.Views.Demirbaşlar
{
    public partial class DemirbasUrunEkleForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DemirbasUrunEkleForm()
        {
            InitializeComponent();
        }

        private void btn_DemirbasEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmb_Sirket.SelectedValue.ToString()))
                {
                    throw new Exception("Lütfen Sirket ve Departman Bilgilerini Kontrol Ediniz !");
                }
                if (string.IsNullOrEmpty(_productName) || _productBuyId == 0)
                {
                    throw new Exception("Lütfen Demirbaş Olacak Ürünü Seçiniz !");
                }
                if (string.IsNullOrEmpty(txt_Adet.Text) || short.Parse(txt_Adet.Text) == 0 || short.Parse(txt_Adet.Text) < 0)
                {
                    throw new Exception("Lütfen Adet Bilgisini Kontrol Ediniz !");
                }
                if (short.Parse(txt_Adet.Text) > _selectedQuantity)
                {
                    throw new Exception("Stok Miktarındakinden Fazla Ürün Demirbaşa Eklenemez ! !");
                }
                
                DemirbasView model = new DemirbasView
                {
                    Sirket = { SirketId = Convert.ToInt32(cmb_Sirket.SelectedValue) },
                    Demirbas =
                    {
                        DemirbasOzellikleri = txt_Aciklama.Text,
                        DemirbasAdedi = Convert.ToInt32(txt_Adet.Text)
                    },
                    Urun = { UrunId = _productBuyId }
                };
                DemirbasController.DemirbasEkle(model);
                MessageBox.Show("Demirbaş Başarıyla Eklendi !", "Demirbaş Eklendi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStocks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DemirbasUrunEkleForm_Load(object sender, EventArgs e)
        {
            GetStocks();
            Tools.ComboBoxSirketGetir(cmb_Sirket);
        }

        private void GetStocks()
        {
            Tools.StoklariGrideDoldur(grid_Urunler, gridView_Urun);
        }

        private bool drm = false;
        private int _productBuyId;
        private string _productName;
        private int _selectedQuantity;

        private void btn_DemirbasListe_ItemClick(object sender, ItemClickEventArgs e)
        {
            DemirbaslariListeleForm x = new DemirbaslariListeleForm();
            x.ShowDialog();
        }

        private void gridView_Urun_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                _productName = gridView_Urun.GetRowCellValue(gridView_Urun.FocusedRowHandle, "UrunAdi").ToString();
                _productBuyId = int.Parse(gridView_Urun.GetRowCellValue(gridView_Urun.FocusedRowHandle, "UrunId").ToString());
                _selectedQuantity = int.Parse(gridView_Urun.GetRowCellValue(gridView_Urun.FocusedRowHandle, "Adet").ToString());
                if (_selectedQuantity == 0)
                {
                    btn_DemirbasEkle.Enabled = false;
                    throw new Exception("Ürün Stoklarda Bulunmadığı Üzerinde İçin İşlem Yapılamaz !");
                }
                else
                {
                    btn_DemirbasEkle.Enabled = true;
                }
                lbl_UrunAdi.Text = _productName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_Adet_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }

        private void btn_OdaDemirbasAta_ItemClick(object sender, ItemClickEventArgs e)
        {
            DemirbasDepartmanTanimlaForm dotForm = new DemirbasDepartmanTanimlaForm();
            this.Close();
            dotForm.Show();
        }

        private void cmb_Sirket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Sirket.SelectedIndex == -1) return;
            int fakulteId = int.Parse(cmb_Sirket.SelectedValue.ToString());
            Tools.ComboBoxBolumGetir(cmb_Departments, fakulteId);
        }

        private void cmb_Sirket_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}