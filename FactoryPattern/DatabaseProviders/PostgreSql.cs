using System.Data.Common;
using FactoryPattern.Interfaces;
using Npgsql;

namespace FactoryPattern.DatabaseProviders
{
    public class PostgreSql : IVeriTabani
    {
        public string Server { get; }
        public string Database { get; }
        public string UserId { get; }
        public string Password { get; }

        public PostgreSql(string server, string database, string userId, string password)
        {
            Server = server;
            Database = database;
            UserId = userId;
            Password = password;
        }

        public void Connect()
        {
            Console.WriteLine("PostgreSQL'e bağlanıldı.");
        }

        public void Disconnect()
        {
            Console.WriteLine("PostgreSQL bağlantısı kesildi.");
        }
        public DbConnection CreateConnection()
        {
            //tools eklenmediği için hata veriyor
            return new NpgsqlConnection($"Host={Server};Port=5432;Database={Database};Username={UserId};Password={Password}");
        }
    }
}
