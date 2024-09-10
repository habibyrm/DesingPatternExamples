namespace Mediatorattern
{
    public class AirTrafficControlTower : IAirTrafficControlMediator
    {
        private List<Airplane> _airplanes = new List<Airplane>();

        public void RegisterAirplane(Airplane airplane)
        {
            _airplanes.Add(airplane);
        }

        public void SendMessage(string message, Airplane airplane)
        {
            foreach (var plane in _airplanes)
            {
                if (plane != airplane)
                {
                    plane.Receive(message);
                }
            }
        }
    }

}
