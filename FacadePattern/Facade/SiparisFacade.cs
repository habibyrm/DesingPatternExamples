using FacadePattern.Servisler;
using FacadePattern.Urunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Facade
{
    public class SiparisFacade
    {
        private OdemeServisi _odemeServisi;
        private StokServisi _stokServisi;
        private KargoServisi _kargoServisi;

        public SiparisFacade()
        {
            _odemeServisi = new OdemeServisi();
            _stokServisi = new StokServisi();
            _kargoServisi = new KargoServisi();
        }

        public void SiparisiIsle(int urunId, int miktar, decimal bakiye)
        {
            Urun urun = _stokServisi.UrunBul(urunId);
            Console.WriteLine($"Verilen sipariş: Ürün-> {urun.Ad} Miktarı-> {miktar}");
            Console.WriteLine("Sipariş işleme başlatılıyor...");
            if (urun != null)
            {
                decimal toplamTutar = urun.Fiyat * miktar;

                //Stok KOntrolü
                if (_stokServisi.StokKontrolEt(urunId, miktar))
                {
                    // Ödeme işleme
                    if (_odemeServisi.OdemeIsle(bakiye, toplamTutar, out decimal kalanBakiye))
                    {
                        // Stoktan düşme
                        _stokServisi.StoktanDus(urunId, miktar);

                        // Kargolama
                        _kargoServisi.UrunKargola(urunId, miktar);

                        // Bildirim
                        Console.WriteLine("Sipariş başarıyla işlenmiştir.");

                        Console.WriteLine($"Kalan bakiye: {kalanBakiye} TL");
                    }
                }
                else
                {
                    Console.WriteLine("Yetersiz stok!");
                }
            }

            Console.WriteLine("Sipariş işleminiz başarıyla tamamlandı.");
        }

        public void StokDurumunuGoster()
        {
            _stokServisi.StokDurumuGoster();
        }
    }


}
