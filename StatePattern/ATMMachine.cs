using StatePattern.States;

namespace StatePattern
{
    public class ATMMachine
    {
        public IATMState NoCardState { get; private set; }
        public IATMState HasCardState { get; private set; }
        public IATMState CorrectPinState { get; private set; }

        private IATMState _currentState;

        public ATMMachine()
        {
            NoCardState = new NoCardState(this);
            HasCardState = new HasCardState(this);
            CorrectPinState = new CorrectPinState(this);

            _currentState = NoCardState;  // Initial state
        }

        public void ChangeState(IATMState newState)
        {
            _currentState = newState;
        }

        public void InsertCard()
        {
            _currentState.InsertCard();
        }

        public void EjectCard()
        {
            _currentState.EjectCard();
        }

        public void EnterPin(int pin)
        {
            _currentState.EnterPin(pin);
        }

        public void WithdrawCash(int amount)
        {
            _currentState.WithdrawCash(amount);
        }
    }
}
