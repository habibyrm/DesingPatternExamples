namespace TepmlatePattern.Employee
{
    public class Firefighter : Worker
    {
        protected override void DoWork()
        {
            Console.WriteLine("Firefighter: Fighting fires...");
        }
    }
}
