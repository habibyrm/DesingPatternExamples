using AbstractFactoryPattern.Interface;

namespace AbstractFactoryPattern.Dag
{
    public class DagAraba : IAraba
    {
        public void GetAraba()
        {
            Console.WriteLine("Dağ arabası");
        }
    }
}
