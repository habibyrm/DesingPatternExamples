namespace MediatorPattern2
{
    public class Employee
    {
        private IMediator mediator;

        public string Name { get; }

        public Employee(IMediator mediator, string name)
        {
            this.mediator = mediator;
            this.Name = name;
            
            mediator.RegisterEmployee(this);
        }

        public void SendMessage(string message,params string[] receivers)
        {
                mediator.SendMessage(message, Name, receivers);
        }

        public void ReceiveMessage(string message, string sender)
        {
            Console.WriteLine($"{Name} yeni bildirim - {sender}: {message}");
        }
    }
}
