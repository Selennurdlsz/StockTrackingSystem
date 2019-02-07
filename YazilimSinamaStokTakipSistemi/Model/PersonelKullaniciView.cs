using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSinamaStokTakipSistemi.Model
{
    public class PersonelKullaniciView
    {
        public Personeller Personel { get; set; }
        public Kullanicilar Kullanici { get; set; }
        public Roller Rol { get; set; }
    }
}
