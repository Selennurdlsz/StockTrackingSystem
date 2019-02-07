using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSinamaStokTakipSistemi.Model
{
    public class StokUrunView
    {
        public Urun_Stok UrunStok { get; set; }
        public decimal ToplamFiyat => UrunStok.Stok * Urun.UrunBirimFiyati;
        public Urunler Urun { get; set; }
    }
}
