namespace ProxyPattern.ControlledAccess
{
    public class Database : IDatabase
    {
        public void RunQuery(string query)
        {
            Console.WriteLine($"Veritabanı sorgusu çalıştırılıyor: {query}");
        }
    }
}
