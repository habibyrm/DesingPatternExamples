namespace MediatorPattern2
{
    public interface IMediator
    {
        void SendMessage(string message, string sender, params string[] receivers);
        void RegisterEmployee(Employee employee);
    }
}
