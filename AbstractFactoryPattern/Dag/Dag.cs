using AbstractFactoryPattern.Interface;

namespace AbstractFactoryPattern.Dag
{
    public class Dag : Tasit
    {
        public override IBisiklet CreateBisiklet()
        {
            return new DagBisiklet();
        }

        public override IAraba CreateAraba()
        {
            return new DagAraba();
        }
    }
}
