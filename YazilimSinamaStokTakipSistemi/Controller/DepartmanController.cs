using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using YazilimSinamaStokTakipSistemi.Model;

namespace YazilimSinamaStokTakipSistemi.Controller
{
    public static class DepartmanController
    {
        public static void DepartmanEkle(string departmanAdi, int sirketId)
        {
            if (string.IsNullOrEmpty(departmanAdi) || sirketId == 0)
            {
                throw new ValidationException("Departman adı ve departman ıd Boş Geçilemez !");
            }
            var result = TumDepartmanlariGetir().FirstOrDefault(x => x.Departman.DepartmanAdi == departmanAdi);
            if (result != null)
            {
                throw new Exception("Bu isimdeki departman mevcuttur!");
            }
            using (var context = new DataContext2())
            {
                context.sp_DepartmanEkle(departmanAdi, sirketId);
            }

        }
        public static void DepartmanGuncelle(int departmanId, string departmanAdi, int personelId)
        {
            using (var context = new DataContext2())
            {
                context.sp_DepartmanGuncelle(departmanId, departmanAdi, personelId);
            }
        }
        public static void DepartmanSil(int departmanId)
        {
            using (var context = new DataContext2())
            {
                var result = context.Departmanlars.FirstOrDefault(x => x.DepartmanId == departmanId);
                context.Entry(result).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public static DepartmanView DepartmanDetayiGetir(int departmanId)
        {
            if (departmanId == 0)
            {
                throw new ValidationException("Departman Id Boş Geldi !");
            }
            var result = TumDepartmanlariGetir().FirstOrDefault(x => x.Departman.DepartmanId == departmanId);
            return result;
        }


        public static IEnumerable<object> DepartmanDemirbaslariList(int departmanId)
        {
            using (var context = new DataContext2())
            {
                var result = context.sp_Departmandaki_Demirbaslar02(departmanId);
                return result.ToList();
            }
        }
        public static List<DepartmanView> TumDepartmanlariGetir()
        {
            using (var context = new DataContext2())
            {
                var result = from Sirket in context.Sirketlers
                             join departman in context.Departmanlars on Sirket.SirketId equals departman.DepartmanId
                            

                             select new DepartmanView
                             {
                                
                                 Departman = departman
                             };
                return result.ToList();
            }
        }

        public static void DepartmanYetkilendir(int personelId, int departmanId)
        {
            using (var context = new DataContext2())
            {
                Zimmetler z = new Zimmetler();
                z.PersonelId = personelId;
                z.DepartmanId = departmanId;
                context.Zimmetlers.Add(z);
                context.SaveChanges();

            }
        }
    }
}
