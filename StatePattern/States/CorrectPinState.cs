namespace StatePattern.States
{
    public class CorrectPinState : IATMState
    {
        private readonly ATMMachine _atmMachine;

        public CorrectPinState(ATMMachine atmMachine)
        {
            _atmMachine = atmMachine;
        }

        public void InsertCard()
        {
            Console.WriteLine("Operation in progress, card cannot be inserted.");
        }

        public void EjectCard()
        {
            Console.WriteLine("Card cannot be ejected during an operation.");
        }

        public void EnterPin(int pin)
        {
            Console.WriteLine("PIN already entered.");
        }

        public void WithdrawCash(int amount)
        {
            Console.WriteLine($"Withdrew {amount} dollars.");
            _atmMachine.ChangeState(_atmMachine.NoCardState);
        }
    }
}
