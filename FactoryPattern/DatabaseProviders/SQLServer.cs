using System.Data.Common;
using FactoryPattern.Interfaces;
using Microsoft.Data.SqlClient;

namespace FactoryPattern.DatabaseProviders
{
    public class SQLServer : IVeriTabani
    {
        public string Server { get; }
        public string Database { get; }
        public string UserId { get; }
        public string Password { get; }

        public SQLServer(string server, string database, string userId, string password)
        {
            Server = server;
            Database = database;
            UserId = userId;
            Password = password;
        }

        public void Connect()
        {
            Console.WriteLine("SQL Server'a bağlanıldı.");
        }

        public void Disconnect()
        {
            Console.WriteLine("SQL Server bağlantısı kesildi.");
        }

        public DbConnection CreateConnection()
        {
            //tools eklenmediği için hata veriyor
            return new SqlConnection($"Server={Server};Database={Database};User ID={UserId};Password={Password};");
        }
    }
}
