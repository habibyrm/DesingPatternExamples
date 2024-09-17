namespace SingleReponsibility.CorrectExample
{
    public class CustomerApiService
    {
        public void SendDataToExternalApi(Customer customer)
        {
            // Simulating external API call
            Console.WriteLine($"Customer details for {customer.Name} sent to external API.");
        }
    }
}
