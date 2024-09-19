namespace InterfaceSegregation.BadExample
{
    public class BasicUser : IUser
    {
        public void Read()
        {
            Console.WriteLine("Reading data...");
        }

        public void Write()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
