using LiskovsSubstitution.BaseClass;

namespace LiskovsSubstitution.DerivedClass
{
    public class LoanAccount:Account
    {
        public LoanAccount(decimal balance):base(balance) { }

        public override void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds for withdrawal. Consider using overdraft.");
            }

            base.Withdraw(amount);
        }

        // Provide an explicit method for handling overdrafts
        public void Overdraft(decimal amount)
        {
            Balance -= amount;
            Console.WriteLine($"Overdraft {amount}, Remaining Balance: {Balance} (Overdraft Used)");
        }
    }
}
