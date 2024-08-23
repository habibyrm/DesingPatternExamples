using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Servisler
{
    public class KargoServisi
    {
        public void UrunKargola(int urunId, int miktar)
        {
            Console.WriteLine($"Ürün kargolanıyor. Ürün Id: {urunId}, Miktar: {miktar}");
        }
    }

}
