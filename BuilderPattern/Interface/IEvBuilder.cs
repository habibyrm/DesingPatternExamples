using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Builder;

namespace BuilderPattern
{
    public interface IEvBuilder
    {
        IEvBuilder TemelYap();
        IEvBuilder DuvarlariYap();
        IEvBuilder CatiYap();
        IEvBuilder GarajEkle();
        IEvBuilder YuzmeHavuzuEkle();
        IEvBuilder BahceEkle();
        Ev EviAl();
    }

}
