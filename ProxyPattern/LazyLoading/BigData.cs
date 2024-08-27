namespace ProxyPattern.LazyLoading
{
    public class BigData
    {
        public BigData()
        {
            Console.WriteLine("Büyük dosya yükleniyor...");
            // Simülasyon için yükleme süresi
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Büyük dosya yüklendi.");
        }

        public void Process()
        {
            Console.WriteLine("Dosya verisi işleniyor.");
        }
    }
}
