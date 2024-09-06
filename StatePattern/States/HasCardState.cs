namespace StatePattern.States
{
    public class HasCardState : IATMState
    {
        private readonly ATMMachine _atmMachine;

        public HasCardState(ATMMachine atmMachine)
        {
            _atmMachine = atmMachine;
        }

        public void InsertCard()
        {
            Console.WriteLine("A card is already inserted.");
        }

        public void EjectCard()
        {
            Console.WriteLine("Card ejected.");
            _atmMachine.ChangeState(_atmMachine.NoCardState);
        }

        public void EnterPin(int pin)
        {
            if (pin == 1234)
            {
                Console.WriteLine("Correct PIN entered.");
                _atmMachine.ChangeState(_atmMachine.CorrectPinState);
            }
            else
            {
                Console.WriteLine("Incorrect PIN.");
                _atmMachine.ChangeState(_atmMachine.NoCardState);
            }
        }

        public void WithdrawCash(int amount)
        {
            Console.WriteLine("Enter PIN first.");
        }
    }
}
