namespace ProxyPattern.RemoteAccess
{
    public class RemoteServer : IRemoteServer
    {
        public void GetData()
        {
            Console.WriteLine("Uzaktaki sunucudan veri çekiliyor...");
        }
    }
}
