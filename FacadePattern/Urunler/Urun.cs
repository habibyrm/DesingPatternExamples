using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Urunler
{
    public class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int StokMiktari { get; set; }
        public decimal Fiyat { get; set; }

        public Urun(int id, string ad, int stokMiktari, decimal fiyat)
        {
            Id = id;
            Ad = ad;
            StokMiktari = stokMiktari;
            Fiyat = fiyat;
        }
    }

}
