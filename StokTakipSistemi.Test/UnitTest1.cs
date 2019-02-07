using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Security.Authentication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YazilimSinamaStokTakipSistemi.Controller;
using YazilimSinamaStokTakipSistemi.Model;
using YazilimSinamaStokTakipSistemi.Views;


namespace StokTakipSistemi.Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [ExpectedException(typeof(AuthenticationException))]
        public void AdminGirisi()
        {
            var kullanici = new Kullanicilar();
            KullaniciController.UserAdminLogin(kullanici);

        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void UrunEkle()
        {
            Urunler urun = null;
            int stok = 0;
            UrunController.UrunEkle(urun, stok);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void DepartmanDetayiGetir()
        {
            DepartmanController.DepartmanDetayiGetir(0);
        }
        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void DepartmanEkle()
        {
            string departman_adi = "xxxxx";
            int departman_id = 0;
            DepartmanController.DepartmanEkle(departman_adi, departman_id);
        }
        [TestMethod]
        [ExpectedException(typeof(ValidationException))]

        public void UrunSil()
        {
            Urunler u = new Urunler();
            UrunController.UrunSil(u.UrunId);
        }
    }


}
