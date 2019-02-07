using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using YazilimSinamaStokTakipSistemi.Model;
using YazilimSinamaStokTakipSistemi.Views;

namespace YazilimSinamaStokTakipSistemi.Controller
{
    public static class DemirbasController
    {
        public static void DemirbasEkle(DemirbasView demirbas)
        {
            using (var context = new DataContext2())
            {
                context.sp_DemirbasEkle(demirbas.Departman.DepartmanId,demirbas.Sirket.SirketId, demirbas.Urun.UrunId, demirbas.Demirbas.DemirbasAdedi, demirbas.Demirbas.DemirbasOzellikleri);
                context.SaveChanges();
            }
        }
        public static Demirbaslar DemirbasGetir(int demirbasNo)
        {
            using (var context = new DataContext2())
            {
                var result = context.Demirbaslars.FirstOrDefault(x => x.DemirbasNo == demirbasNo);
                return result;
            }
        }
        public static void DemirbasSil(int demirbasNo)
        {
            using (var context = new DataContext2())
            {
                var result = context.Demirbaslars.FirstOrDefault(x => x.DemirbasNo == demirbasNo);
                context.Entry(result).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public static void DemirbasGuncelle(int demirbasNo, int sirketId, int departmanId, int demirbasAdedi, string demirbasOzellikler)
        {
            using (var context = new DataContext2())
            {
                context.sp_DemirbasDuzenle(demirbasNo, sirketId,departmanId, demirbasAdedi, demirbasOzellikler);
            }
        }
        public static List<Demirbaslar> DemirbaslariListele()
        {
            using (var context = new DataContext2())
            {
                var result = context.Demirbaslars.ToList();
                return result;
            }
        }
    }
}
