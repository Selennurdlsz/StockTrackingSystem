using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using YazilimSinamaStokTakipSistemi.Model;

namespace YazilimSinamaStokTakipSistemi.Controller
{
    public static class PersonelController
    {
        public static void PersonelEkle(Kullanicilar personel)
        {
            /*if ((string.IsNullOrEmpty(personeller.Personeller.Ad) == null)|| (string.IsNullOrEmpty(personeller.Personeller.Soyad) == null))
            {
                throw new ValidationException("Hata");
            }*/
            using (var context = new DataContext2())
            {
                context.sp_PersonelEkle(personel.Personeller.Soyad);
            }
        }
        public static List<Personeller> KullanicilariListele()
        {
            using (var context = new DataContext2())
            {
                var result = context.Personellers;
                return result.ToList();
            }
        }
        public static PersonelKullaniciView PersonelGetir(int personelId)
        {
            if (personelId == 0)
            {
                throw new TargetParameterCountException("Kullanici Getirilemedi !");
            }
            using (var context = new DataContext2())
            {
                var result = from personel in context.Personellers
                             join kullanici in context.Kullanicilars on personel.PersonelId equals kullanici.KullaniciId
                             join kullaniciRol in context.KullaniciRols on kullanici.KullaniciId equals kullaniciRol.KullaniciId
                             join rol in context.Rollers on kullaniciRol.RolId equals rol.RolId
                             select new PersonelKullaniciView
                             {
                                 Personel = personel,
                                 Kullanici = kullanici,
                                 Rol = rol
                             };
                return result.FirstOrDefault(x => x.Personel.PersonelId == personelId);
            }
        }

        public static List<DepartmanPersonelView> KullaniciZimmetleri(int personelId)
        {
            using (var context = new DataContext2())
            {
                var result = from departman in context.Departmanlars
                             join zim in context.Zimmetlers on departman.DepartmanId equals zim.DepartmanId
                             join demirbasDepartman in context.DemirbasDepartmen on zim.ZimmetId equals demirbasDepartman.ZimmetId
                             join db in context.Demirbaslars on demirbasDepartman.DemirbasId equals db.DemirbasNo
                             join p in context.Personellers on zim.PersonelId equals p.PersonelId
                             select new DepartmanPersonelView
                             {
                                 Personel = p,
                                 Departman = departman,
                                 Zimmet = zim,
                                 Demirbas = db
                             };
                return result.Where(x => x.Personel.PersonelId == personelId).ToList();
            }
        }

        public static List<DepartmanPersonelView> KullaniciSorumluDepartmanlar(int personelId)
        {
            using (var context = new DataContext2())
            {
                var result = from departman in context.Departmanlars
                             join zim in context.Zimmetlers on departman.DepartmanId equals zim.DepartmanId
                             join p in context.Personellers on zim.PersonelId equals p.PersonelId
                             select new DepartmanPersonelView
                             {
                                 Personel = p,
                                 Departman = departman,
                                 Zimmet = zim,

                             };
                return result.Where(x => x.Personel.PersonelId == personelId).ToList();
            }
        }
    }
}
