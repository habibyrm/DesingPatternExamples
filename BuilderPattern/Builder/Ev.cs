using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public class Ev
    {
        public string Temel { get; set; }
        public string Duvarlar { get; set; }
        public string Çatı { get; set; }
        public bool GarajVarMi { get; set; }
        public bool YüzmeHavuzuVarMi { get; set; }
        public bool BahçeVarMi { get; set; }

        public override string ToString()
        {
            return $"Temel: {Temel}, Duvarlar: {Duvarlar}, Çatı: {Çatı}, " +
                   $"Garaj: {GarajVarMi}, Yüzme Havuzu: {YüzmeHavuzuVarMi}, Bahçe: {BahçeVarMi}";
        }
    }
}
