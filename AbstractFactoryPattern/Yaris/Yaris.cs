using AbstractFactoryPattern.Interface;

namespace AbstractFactoryPattern.Yaris
{
    public class Yaris : Tasit
    {
        public override IBisiklet CreateBisiklet()
        {
            return new YarisBisiklet();
        }

        public override IAraba CreateAraba()
        {
            return new YarisAraba();
        }
    }
}
