using FacadePattern.Urunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Servisler
{
    public class StokServisi
    {
        private List<Urun> urunListesi;

        public StokServisi()
        {
            urunListesi = new List<Urun>
        {
            new Urun(101, "Laptop", 10, 7500m),
            new Urun(102, "Telefon", 20, 3500m),
            new Urun(103, "Tablet", 15, 1500m)
        };
        }

        public Urun UrunBul(int urunId)
        {
            return urunListesi.Find(u => u.Id == urunId);
        }

        public bool StokKontrolEt(int urunId, int miktar)
        {
            Urun urun = UrunBul(urunId);
            if (urun != null && urun.StokMiktari >= miktar)
            {
                return true; // Stokta yeterli ürün var
            }
            return false; // Yeterli ürün stokta yok
        }

        public void StoktanDus(int urunId, int miktar)
        {
            Urun urun = UrunBul(urunId);
            if (urun != null)
            {
                urun.StokMiktari -= miktar;
                Console.WriteLine($"{urun.Ad} stoktan düşüldü. Kalan Stok: {urun.StokMiktari}");
            }
        }

        public void StokDurumuGoster()
        {
            Console.WriteLine("Mevcut Stok Durumu:");
            foreach (var urun in urunListesi)
            {
                Console.WriteLine($"{urun.Ad} - Stok: {urun.StokMiktari}, Fiyat: {urun.Fiyat} TL");
            }
        }
    }

}
