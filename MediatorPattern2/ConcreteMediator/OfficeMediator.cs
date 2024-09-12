namespace MediatorPattern2.ConcreteMediator
{
    public class OfficeMediator : IMediator
    {
        private Dictionary<string, Employee> employees = new Dictionary<string, Employee>();

        public void RegisterEmployee(Employee employee)
        {
            if (!employees.ContainsKey(employee.Name))
            {
                employees[employee.Name] = employee;
            }
        }

        public void SendMessage(string message, string sender, params string[] receivers)
        {
            foreach (string receiver in receivers)
            {
                if (employees.ContainsKey(receiver))
                {
                    employees[receiver].ReceiveMessage(message, sender);
                }
            }
        }
    }
}
