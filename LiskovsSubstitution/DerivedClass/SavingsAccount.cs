using LiskovsSubstitution.BaseClass;

namespace LiskovsSubstitution.DerivedClass
{
    public class SavingsAccount : Account
    {
        private decimal _minimumBalance;

        public SavingsAccount(decimal balance, decimal minimumBalance) : base(balance)
        {
            _minimumBalance = minimumBalance;
        }

        public override void Withdraw(decimal amount)
        {
            if (Balance - amount < _minimumBalance)
            {
                throw new InvalidOperationException("Cannot go below the minimum balance");
            }

            base.Withdraw(amount);
        }
    }
}
