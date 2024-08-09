using FactoryPattern.DatabaseProviders;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Factories
{
    public class VeriTabaniFactory
    {
        public static IVeriTabani CreateDatabase(string dbTur, string server, string database, string userId, string password)
        {
            dbTur = dbTur.ToLower();

            if (dbTur == "sqlserver")
            {
                return new SQLServer(server, database, userId, password);
            }
            else if (dbTur == "postgresql")
            {
                return new PostgreSql(server, database, userId, password);
            }
            else if (dbTur == "mysql")
            {
                return new MySqlDb(server, database, userId, password);
            }
            else
            {
                throw new ArgumentException("Geçersiz veritabanı türü.");
            }
        }
    }
}
