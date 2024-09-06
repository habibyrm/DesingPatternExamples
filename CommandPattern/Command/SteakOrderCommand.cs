namespace CommandPattern.Command
{
    internal class SteakOrderCommand : IOrderCommand
    {
        private Chef _chef;

        public SteakOrderCommand(Chef chef)
        {
            _chef = chef;
        }

        public void Execute()
        {
            _chef.CookSteak();
        }
    }
}
