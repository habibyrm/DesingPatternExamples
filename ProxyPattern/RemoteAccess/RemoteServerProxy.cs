namespace ProxyPattern.RemoteAccess
{
    public class RemoteServerProxy : IRemoteServer
    {
        private RemoteServer _remoteServer;

        public void GetData()
        {
            if (_remoteServer == null)
            {
                _remoteServer = new RemoteServer();
            }
            _remoteServer.GetData();
        }
    }
}
