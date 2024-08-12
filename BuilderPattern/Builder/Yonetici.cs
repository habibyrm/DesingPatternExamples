using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public class Yonetici
    {
        private IEvBuilder _evBuilder;

        public Yonetici(IEvBuilder evBuilder)
        {
            _evBuilder = evBuilder;
        }

        public void MinimalEvYap()
        {
            _evBuilder.TemelYap()
                      .DuvarlariYap()
                      .CatiYap();
        }

        public void TamDonanimliEvYap()
        {
            _evBuilder.TemelYap()
                      .DuvarlariYap()
                      .CatiYap()
                      .GarajEkle()
                      .YuzmeHavuzuEkle()
                      .BahceEkle();
        }
    }

}
