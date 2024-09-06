namespace TepmlatePattern.Employee
{
    public class Lumberjack : Worker
    {
        protected override void DoWork()
        {
            Console.WriteLine("Lumberjack: Chopping wood...");
        }
    }
}
