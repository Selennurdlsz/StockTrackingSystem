using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using YazilimSinamaStokTakipSistemi.Model;

namespace YazilimSinamaStokTakipSistemi.Controller
{
    public class DepartmanPersonelController
    {
        public static void DepartmanaDemirbasEkle(int demirbasId, int departmanId, int adet)
        {
            using (var context = new DataContext2())
            {
                context.sp_DepartmanaDemirbasEkle(demirbasId, departmanId, adet);
            }
        }

        public static void departmanDemirbasSil(int demirbasDepartmanId)
        {
            using (var context = new DataContext2())
            {
                var result = context.DemirbasDepartmen.FirstOrDefault(x => x.DemirbasDepartmanId == demirbasDepartmanId);
                context.Entry(result).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public static List<DepartmanPersonelView> DepartmanSorumlulariListele()
        {
            using (var context = new DataContext2())
            {
                var result = from p in context.Personellers
                             join z in context.Zimmetlers on p.PersonelId equals z.PersonelId
                             join o in context.Departmanlars on z.DepartmanId equals o.DepartmanId
                             select new DepartmanPersonelView
                             {
                                 Personel = p,
                                 Departman = o,
                                 Zimmet = z
                             };
                return result.ToList();
            }
        }
    }
}
