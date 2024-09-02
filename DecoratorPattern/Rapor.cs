namespace DecoratorPattern
{
    public class Rapor: IRapor
    {
        public void Yazdir(string content)
        {
            Console.WriteLine(content);
        }
    }
}
