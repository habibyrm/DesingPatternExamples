using InterfaceSegregation.GoodExample.Interface;

namespace InterfaceSegregation.GoodExample
{
    public class AdminUser : IReadPermission, IWritePermission, IDeletePermission
    {
        public void Read()
        {
            Console.WriteLine("Reading data");
        }

        public void Write()
        {
            Console.WriteLine("Writing data");
        }

        public void Delete()
        {
            Console.WriteLine("Deleting data");
        }
    }
}
