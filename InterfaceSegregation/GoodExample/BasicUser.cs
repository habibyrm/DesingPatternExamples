using InterfaceSegregation.GoodExample.Interface;

namespace InterfaceSegregation.GoodExample
{
    internal class BasicUser : IReadPermission
    {
        public void Read()
        {
            Console.WriteLine("Reading data....");
        }
    }
}
