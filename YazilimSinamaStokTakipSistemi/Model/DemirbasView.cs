using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSinamaStokTakipSistemi.Model
{
    public class DemirbasView
    {
        public DemirbasView()
        {
            Sirket = new Sirketler();
            Departman = new Departmanlar();
            Demirbas = new Demirbaslar();
            Urun = new Urunler();
        }

        public Sirketler Sirket { get; set; }
        public Departmanlar Departman { get; set; }
        public Urunler Urun { get; set; }
        public Demirbaslar Demirbas { get; set; }
    }
}
