namespace InterfaceSegregation.BadExample
{
    public class AdminUser : IUser
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
