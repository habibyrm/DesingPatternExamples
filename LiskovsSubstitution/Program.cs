// Alt sınıflardan herhangi birinin nesnesi ile bir üst sınıfın nesnesi yer değiştirebilmelidir.
using LiskovsSubstitution.BaseClass;
using LiskovsSubstitution.DerivedClass;

class Program
{
    static void Main(string[] args)
    {
        Account savings = new SavingsAccount(1000, 500);
        Account loan = new LoanAccount(1000);

        Console.WriteLine("Saving Account:");
        try
        {
            savings.Withdraw(400); // This will succeed
            savings.Withdraw(100); // This will throw an exception (minimum balance violated)
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Savings Account Error: {ex.Message}");
        }

        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("Loan Account:");
        try
        {
            loan.Withdraw(500); // This will throw an exception (insufficient funds)
            ((LoanAccount)loan).Overdraft(500); // This will allow overdraft
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Loan Account Error: {ex.Message}");
        }
    }
}
