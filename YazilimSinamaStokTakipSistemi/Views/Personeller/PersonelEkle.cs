using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using YazilimSinamaStokTakipSistemi.Controller;
using YazilimSinamaStokTakipSistemi.Model;

namespace YazilimSinamaStokTakipSistemi.Views.Personeller
{
    public partial class PersonelEkle : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void btn_PersonelEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_PersonelAdi.Text) || string.IsNullOrEmpty(txt_PersonelSoyadi.Text))
                {
                    throw new ValidationException("Personel Bilgileri Boş Geçilemez !");
                }

                Kullanicilar kullanicilar = new Kullanicilar();
                kullanicilar.Personeller.Ad = txt_PersonelAdi.Text;
                kullanicilar.Personeller.Soyad = txt_PersonelSoyadi.Text;
                PersonelController.PersonelEkle(kullanicilar);
                MessageBox.Show("Personel Bilgileri Başarıyla Eklendi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}