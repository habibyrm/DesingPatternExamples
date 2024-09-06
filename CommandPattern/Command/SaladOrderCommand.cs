namespace CommandPattern.Command
{
    public class SaladOrderCommand : IOrderCommand
    {
        private Chef _chef;

        public SaladOrderCommand(Chef chef)
        {
            _chef = chef;
        }

        public void Execute()
        {
            _chef.CookSalad();
        }
    }
}
