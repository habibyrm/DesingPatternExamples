namespace ProxyPattern.ControlledAccess
{
    public interface IDatabase
    {
        void RunQuery(string query);
    }
}