using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singelton3
    {
        private static Singelton3 instance = null;

        // Erişimi thread-safe hale getirmek için bir kilit nesnesi.
        private static readonly object lockObject = new object();

        // Özel bir yapıcı (constructor) böylece sınıf dışından nesne oluşturulamaz.
        private Singelton3()
        {
            Console.WriteLine("Ben oluştum.Singelton3");
        }

        public static Singelton3 Instance
        {
            get
            {       //Her seferinde multithread kontorlü
                    //Multithread projelerde aynı anda çağırıldığında birden 
                lock (lockObject)
                {
                    // Kilit içinde bir kez daha kontrol et.
                    if (instance == null)
                    {
                        Console.WriteLine("Aynı anda birden fazla threadin ilk çağırılma anında yalnızca tek nesne oluşturma kontrolü");
                        instance = new Singelton3();
                    }
                }
                return instance;
            }
        }
    }
}
