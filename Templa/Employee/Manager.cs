namespace TepmlatePattern.Employee
{
    public class Manager : Worker
    {
        protected override void DoWork()
        {
            Console.WriteLine("Manager: Attending meetings and managing teams...");
        }
    }
}
