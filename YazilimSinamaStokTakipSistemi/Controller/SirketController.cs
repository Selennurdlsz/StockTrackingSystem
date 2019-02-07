using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimSinamaStokTakipSistemi.Model;

namespace YazilimSinamaStokTakipSistemi.Controller
{
    public static class SirketController
    {
        public static List<Sirketler> SirkerleriListele()
        {
            using (var context = new DataContext2())
            {
                var result = context.Sirketlers.ToList();
                return result.ToList();
            }
        }
    }
}
