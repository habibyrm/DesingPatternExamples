using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Servisler
{
    public class OdemeServisi
    {
        public bool OdemeIsle(decimal bakiye, decimal urunFiyati, out decimal kalanBakiye)
        {
            if (bakiye >= urunFiyati)
            {
                kalanBakiye = bakiye - urunFiyati;
                Console.WriteLine($"Ödeme başarılı. Kalan bakiye: {kalanBakiye} TL.");
                return true; // Ödeme başarılı
            }
            else
            {
                kalanBakiye = bakiye;
                Console.WriteLine("Yetersiz bakiye! Ödeme işlemi başarısız.");
                return false; // Yetersiz bakiye
            }
        }
    }

}
