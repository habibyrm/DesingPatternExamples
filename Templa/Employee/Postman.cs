namespace TepmlatePattern.Employee
{
    public class Postman : Worker
    {
        protected override void DoWork()
        {
            Console.WriteLine("Postman: Delivering mail...");
        }
    }
}
