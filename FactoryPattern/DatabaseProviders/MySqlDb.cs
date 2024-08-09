using System.Data.Common;
using FactoryPattern.Interfaces;
using MySql.Data.MySqlClient;

namespace FactoryPattern.DatabaseProviders
{
    public class MySqlDb : IVeriTabani
    {
        public string Server { get; }
        public string Database { get; }
        public string UserId { get; }
        public string Password { get; }

        public MySqlDb(string server, string database, string userId, string password)
        {
            Server = server;
            Database = database;
            UserId = userId;
            Password = password;
        }

        public void Connect()
        {
            Console.WriteLine("MySQL'e bağlanıldı.");
        }

        public void Disconnect()
        {
            Console.WriteLine("MySQL bağlantısı kesildi.");
        }

        public DbConnection CreateConnection()
        {
            return new MySqlConnection($"Server={Server};Database={Database};User ID={UserId};Password={Password};");
        }
    }
}
