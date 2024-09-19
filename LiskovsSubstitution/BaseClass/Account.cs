namespace LiskovsSubstitution.BaseClass
{
    public class Account
    {
        public decimal Balance { get; protected set; }

        public Account(decimal balance)
        {
            Balance = balance;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }

            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount}, Remaining Balance: {Balance}");
        }
    }
}
