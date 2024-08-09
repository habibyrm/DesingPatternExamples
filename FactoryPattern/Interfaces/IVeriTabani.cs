using System.Data.Common;

namespace FactoryPattern.Interfaces
{
    public interface IVeriTabani
    {
        public string Server { get; }
        public string Database { get; }
        public string UserId { get; }
        public string Password { get; }

        public DbConnection CreateConnection();
        void Connect();
        void Disconnect();
    }
}
