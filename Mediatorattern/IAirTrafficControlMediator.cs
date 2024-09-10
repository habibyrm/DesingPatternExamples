namespace Mediatorattern
{
    public interface IAirTrafficControlMediator
    {
        void RegisterAirplane(Airplane airplane);
        void SendMessage(string message, Airplane airplane);
    }
}
