namespace StatePattern.States
{
    public class NoCardState : IATMState
    {
        private readonly ATMMachine _atmMachine;

        public NoCardState(ATMMachine atmMachine)
        {
            _atmMachine = atmMachine;
        }

        public void InsertCard()
        {
            Console.WriteLine("Card inserted.");
            _atmMachine.ChangeState(_atmMachine.HasCardState);
        }

        public void EjectCard()
        {
            Console.WriteLine("No card to eject.");
        }

        public void EnterPin(int pin)
        {
            Console.WriteLine("Please insert a card first.");
        }

        public void WithdrawCash(int amount)
        {
            Console.WriteLine("Please insert a card first.");
        }
    }
}
