using TepmlatePattern;
using TepmlatePattern.Employee;

class Program
{
    static void Main(string[] args)
    {
        Worker firefighter = new Firefighter();
        firefighter.DailyRoutine();

        Worker lumberjack = new Lumberjack();
        lumberjack.DailyRoutine();

        Worker postman = new Postman();
        postman.DailyRoutine();

        Worker manager = new Manager();
        manager.DailyRoutine();
    }
}