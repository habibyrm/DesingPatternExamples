namespace SingleReponsibility.CorrectExample
{
    public class CustomerDatabaseService
    {
        public void UpdateInDatabase(Customer customer)
        {
            // Simulating database update
            Console.WriteLine($"Customer with ID {customer.Id} updated in the database.");
        }
    }
}
