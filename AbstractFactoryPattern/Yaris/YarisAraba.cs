using AbstractFactoryPattern.Interface;

namespace AbstractFactoryPattern.Yaris
{
    public class YarisAraba : IAraba
    {
        public void GetAraba()
        {
            Console.WriteLine("Yarış arabası");
        }
    }
}
