namespace Mediatorattern
{
    public class Airplane
    {
        private string _flightNumber;
        private IAirTrafficControlMediator _mediator;

        public Airplane(string flightNumber, IAirTrafficControlMediator mediator)
        {
            _flightNumber = flightNumber;
            _mediator = mediator;
        }

        public string FlightNumber => _flightNumber;

        public void Send(string message)
        {
            Console.WriteLine($"[{_flightNumber}] gönderiyor: {message}");
            _mediator.SendMessage(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"[{_flightNumber}] mesaj aldı: {message}");
        }
    }

}
