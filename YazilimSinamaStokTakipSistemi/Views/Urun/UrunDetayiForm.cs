using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using YazilimSinamaStokTakipSistemi.Controller;
using YazilimSinamaStokTakipSistemi.Model;


namespace YazilimSinamaStokTakipSistemi.Views.Urun
{
    public partial class UrunDetayiForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public UrunDetayiForm(int urunId)
        {
            if (urunId != 0)
            {
                this.UrunId = urunId;
            }
            InitializeComponent();
        }

        public int UrunId { get; }

        private void btn_UrunDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = Convert.ToDateTime(calendarControl1.SelectionStart.ToShortDateString());
                if (string.IsNullOrEmpty(txt_UrunAdi.Text) || string.IsNullOrEmpty(txt_UrunBirimFiyat.Text) || string.IsNullOrEmpty(txt_urunAdet.Text))
                {
                    throw new ValidationException("Ürün Bilgileri Boş Geçilemez !");
                }
                if (int.Parse(txt_urunAdet.Text) <= 0)
                {
                    throw new ValidationException("Stok Değeri Sıfır veya Daha Düşük Değerler Olamaz !");
                }
                if (selectedDate > DateTime.Now)
                {
                    throw new ValidationException("Satın alma tarihi bugünden daha sonraki bir tarih olamaz!");
                }

                Urunler urun = new Urunler();
                urun.UrunAdi = txt_UrunAdi.Text;
                urun.UrunBirimFiyati = decimal.Parse(txt_UrunBirimFiyat.Text);
                urun.SatinAlinmaTarihi = selectedDate;
                urun.SatinAlinilanKurum = txtSatinAlinilanKurum.Text;
                urun.UrunToptanFiyati = decimal.Parse(txtToptanFiyat.Text);
                urun.UrunId = UrunId;
                UrunController.UrunDuzenle(urun, int.Parse(txt_urunAdet.Text));
                MessageBox.Show("Ürün Başarıyla Düzenlendi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UrunGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UrunDetayiForm_Load(object sender, EventArgs e)
        {
            if (LoginForm._session == eRoller.SatisSorumlusu.ToString())
            {
                btn_UrunEkle.Enabled = false;
                //btn_AktifYap.Enabled = false;
                //btn_UrunSil.Enabled = false;
            }
            UrunGetir();
        }

        private void UrunGetir()
        {
           
            StokUrunView urun = UrunController.UrunGetir(UrunId);
            txt_UrunAdi.Text = urun.Urun.UrunAdi;
            txt_UrunBirimFiyat.Text = urun.Urun.UrunBirimFiyati.ToString("C");
            txtToptanFiyat.Text = urun.Urun.UrunToptanFiyati.ToString("C");
            txtSatinAlinilanKurum.Text = urun.Urun.SatinAlinilanKurum;
            lbl_FiyatGizli.Text = urun.Urun.UrunBirimFiyati.ToString(CultureInfo.InvariantCulture);
            txt_urunAdet.Text = urun.UrunStok.Stok.ToString();
            calendarControl1.StartDate = Convert.ToDateTime(urun.Urun.SatinAlinmaTarihi);
        }

        private void btn_UrunSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show(txt_UrunAdi.Text + " İsimli Ürün Silinsin Mi ?", "Karar ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                UrunController.UrunSil(UrunId);
                MessageBox.Show(txt_UrunAdi.Text + " İsimli Ürün Silindi !\nÜrün Listeleme Sayfasına Yönlendiriliyorsunuz !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(500);
                this.Close();
                urunListesiGetir();
            }
        }

        public void urunListesiGetir()
        {
            UrunStokListeForm pslForm = new UrunStokListeForm();
            this.Close();
            pslForm.Show();
        }

        private void btn_AktifYap_ItemClick(object sender, ItemClickEventArgs e)
        {
            btn_UrunDuzenle.Enabled =  calendarControl1.Enabled = txt_UrunAdi.Enabled = txt_UrunBirimFiyat.Enabled = txt_urunAdet.Enabled = txtSatinAlinilanKurum.Enabled = txtToptanFiyat.Enabled= true;
            txt_UrunBirimFiyat.Text = lbl_FiyatGizli.Text;
            txtToptanFiyat.Text = lbl_FiyatGizli.Text;
        }

        private void txt_urunAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }

        private void btn_urunListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            urunListesiGetir();
        }
    }
}