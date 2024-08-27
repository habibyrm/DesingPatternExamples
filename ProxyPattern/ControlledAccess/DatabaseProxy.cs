namespace ProxyPattern.ControlledAccess
{
    public class DatabaseProxy : IDatabase
    {
        private IDatabase _database;
        private bool _isAuthorized;

        public DatabaseProxy(IDatabase database, bool isAuthorized)
        {
            _database = database;
            _isAuthorized = isAuthorized;
        }

        public void RunQuery(string query)
        {
            if (_isAuthorized)
            {
                _database.RunQuery(query);
            }
            else
            {
                Console.WriteLine("Yetkisiz kullanıcı, sorgu çalıştırılamaz.");
            }
        }
    }
}
