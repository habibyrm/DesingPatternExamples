using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Asker : Oyuncu
    {

        public Asker(string Renk, string Rutbe, string Alan,string techizat, string guc)
        {
            this.Renk = Renk;
            this.Rutbe = Rutbe;
            this.SavasAlani = Alan;
            this.Techizat = techizat;
            this.Guc = guc;
        }

        public override Oyuncu Klonla()
        {
            return (Oyuncu)this.MemberwiseClone();
        }
    }
}
