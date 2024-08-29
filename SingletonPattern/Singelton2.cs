using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singelton2
    {
        private static Singelton2 instance = null;
        private Singelton2()
        {Console.WriteLine("Ben oluştum. Singeltom2");}
        public static Singelton2 Instance
        {
            get
            {
                if (instance == null){instance = new Singelton2();}
                return instance;
            }
        }
    }
}
