using AbstractFactoryPattern.Interface;

namespace AbstractFactoryPattern.Yaris
{
    public class YarisBisiklet : IBisiklet
    {
        public void GetBisiklet()
        {
            Console.WriteLine("Yarış bisikleti");
        }
    }
}
