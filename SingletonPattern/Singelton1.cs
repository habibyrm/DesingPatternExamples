using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singelton1
    {
        private static Singelton1 instance = new Singelton1();
        // Özel bir yapıcı (constructor) böylece sınıf dışından nesne oluşturulamaz.
        private Singelton1()
        { Console.WriteLine("Ben oluştum.Singelton1");}
        public static Singelton1 Instance
        { get {return instance;}}
    }
}
