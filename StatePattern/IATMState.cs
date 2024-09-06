namespace StatePattern
{
    public interface IATMState
    {
        void InsertCard();
        void EjectCard();
        void EnterPin(int pin);
        void WithdrawCash(int amount);
    }
}
