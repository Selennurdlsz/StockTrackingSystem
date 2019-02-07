using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSinamaStokTakipSistemi.Model
{
    public class DepartmanPersonelView
    {
        public Personeller Personel { get; set; }
        public Departmanlar Departman { get; set; }
        public Zimmetler Zimmet { get; set; }
        public Demirbaslar Demirbas { get; set; }
    }
}
