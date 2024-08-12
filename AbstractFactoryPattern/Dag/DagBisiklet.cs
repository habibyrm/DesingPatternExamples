using AbstractFactoryPattern.Interface;

namespace AbstractFactoryPattern.Dag
{
    public class DagBisiklet : IBisiklet
    {
        public void GetBisiklet()
        {
            Console.WriteLine("Dağ bisikletsi");
        }
    }
}
