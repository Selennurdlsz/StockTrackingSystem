using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.ODataLinq.Helpers;
using YazilimSinamaStokTakipSistemi.Model;

namespace YazilimSinamaStokTakipSistemi.Controller
{
    public static class StokController
    {
        public static List<StokUrunView> StoklarıGetir()
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
                bool silinmedi = Convert.ToBoolean(EDeleted.silinmedi);
                return result.Where(x => x.UrunStok.Stok > 0 && x.Urun.Silindi == silinmedi).ToList();
            }
        }
        public static List<StokUrunView> StoktaBitenleriGetir()
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
                bool silinmedi = Convert.ToBoolean(EDeleted.silinmedi);
                return result.Where(x => x.UrunStok.Stok == 0 && x.Urun.Silindi == silinmedi).ToList();
            }
        }
    }
}
