using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.ODataLinq.Helpers;
using YazilimSinamaStokTakipSistemi.Model;

namespace YazilimSinamaStokTakipSistemi.Controller
{
    public static class UrunController
    {
        public static void UrunEkle(Urunler urun, int stok)
        {
            if (urun == null || stok == 0)
            {
                throw new ValidationException("Hata");
            }
            using (var context = new DataContext2())
            {
              context.sp_UrunEkle(urun.UrunAdi, urun.UrunBirimFiyati, stok, urun.SatinAlinmaTarihi, urun.UrunToptanFiyati, urun.SatinAlinilanKurum);
            }
        }
        public static void UrunDuzenle(Urunler urun, int stok)
        {
            using (var context = new DataContext2())
            {
                context.sp_UrunGuncelle(urun.UrunId, urun.UrunAdi, urun.UrunBirimFiyati, stok, urun.SatinAlinmaTarihi, urun.UrunToptanFiyati, urun.SatinAlinilanKurum);
            }
        }
        public static void UrunSil(int urunId)
        {
            using (var context = new DataContext2())
            {
                var result = context.Urunlers.FirstOrDefault(x => x.UrunId == urunId);
                context.Entry(result).State = EntityState.Deleted;
                //context.SaveChanges();
            }
        }
        public static StokUrunView UrunGetir(int urunId)
        {
            using (var context = new DataContext2())
            {
                var result = from urunStok in context.Urun_Stok
                             join urun in context.Urunlers
                                 on urunStok.UrunId equals urun.UrunId
                             select new StokUrunView
                             {
                                 Urun = urun,
                                 UrunStok = urunStok
                             };

                return result.FirstOrDefault(x => x.Urun.UrunId == urunId);
            }
        }
        public static List<StokUrunView> SilinenleriGetir()
        {
            using (var context = new DataContext2())
            {
                var result = from urun in context.Urunlers
                             join stok in context.Urun_Stok
                                 on urun.UrunId equals stok.UrunId
                             select new StokUrunView
                             {
                                 UrunStok = stok,
                                 Urun = urun
                             };
                return result.Where(x => x.Urun.Silindi == Convert.ToBoolean(EDeleted.silindi)).ToList();
            }
        }
    }
}
