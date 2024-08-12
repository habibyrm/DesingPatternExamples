using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public class SomutEvBuilder : IEvBuilder
    {
        private Ev _ev;

        public SomutEvBuilder()
        {
            _ev = new Ev();
        }

        public IEvBuilder TemelYap()
        {
            _ev.Temel = "Beton Temel";
            return this;
        }

        public IEvBuilder DuvarlariYap()
        {
            _ev.Duvarlar = "Tuğla Duvarlar";
            return this;
        }

        public IEvBuilder CatiYap()
        {
            _ev.Çatı = "Kiremit Çatı";
            return this;
        }

        public IEvBuilder GarajEkle()
        {
            _ev.GarajVarMi = true;
            return this;
        }

        public IEvBuilder YuzmeHavuzuEkle()
        {
            _ev.YüzmeHavuzuVarMi = true;
            return this;
        }

        public IEvBuilder BahceEkle()
        {
            _ev.BahçeVarMi = true;
            return this;
        }

        public Ev EviAl()
        {
            return _ev;
        }
    }

}
