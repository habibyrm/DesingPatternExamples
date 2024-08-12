using AbstractFactoryPattern.Dag;
using AbstractFactoryPattern.Interface;
using AbstractFactoryPattern.Yaris;

public class Program
{
    private static void Main(string[] args)
    {
        Tasit yaris = new Yaris();

        IBisiklet yarisBisiklet = yaris.CreateBisiklet();
        yarisBisiklet.GetBisiklet();

        IAraba yarisAraba = yaris.CreateAraba();
        yarisAraba.GetAraba();

        Tasit dag = new Dag();

        IBisiklet dagBisiklet = dag.CreateBisiklet();
        dagBisiklet.GetBisiklet();

        IAraba dagAraba = dag.CreateAraba();
        dagAraba.GetAraba();
    }
}