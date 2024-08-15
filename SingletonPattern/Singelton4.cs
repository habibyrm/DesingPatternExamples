using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singelton4
    {
        private static Singelton4 instance = null;

        // Erişimi thread-safe hale getirmek için bir kilit nesnesi.
        private static readonly object lockObject = new object();

        // Özel bir yapıcı (constructor) böylece sınıf dışından nesne oluşturulamaz.
        private Singelton4()
        {
            Console.WriteLine("Ben oluştum.Singelton4");
        }

        public static Singelton4 Instance
        {
            get
            {
                // İlk kontrol: Eğer örnek oluşturulmamışsa (null ise) kilitle ve oluştur.
                if (instance == null)
                {
                    Console.WriteLine("nesne yoksa thread kontrolü if bloğu.");
                    //Multithread projelerde aynı anda çağırıldığında birden 
                    lock (lockObject)
                    {
                        // İkinci kontrol: Kilit içinde bir kez daha kontrol et.
                        if (instance == null)
                        {
                            instance = new Singelton4();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
