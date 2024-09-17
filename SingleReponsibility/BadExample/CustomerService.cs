namespace SingleReponsibility.BadExample
{
    public class CustomerService
    {
        public void UpdateCustomerDetails(Customer customer)
        {
            // Update in the database
            UpdateInDatabase(customer);

            // Validate customer details
            if (!ValidateCustomerDetails(customer))
            {
                throw new Exception("Invalid customer details");
            }

            // Send data to an external API
            SendDataToExternalApi(customer);
        }

        private void UpdateInDatabase(Customer customer)
        {
            // Simulating database update
            Console.WriteLine($"Customer with ID {customer.Id} updated in the database.");
        }

        private bool ValidateCustomerDetails(Customer customer)
        {
            // Simple validation logic (for example purposes)
            if (string.IsNullOrWhiteSpace(customer.Name) || string.IsNullOrWhiteSpace(customer.Email))
            {
                Console.WriteLine("Customer details are invalid.");
                return false;
            }

            Console.WriteLine("Customer details validated.");
            return true;
        }

        private void SendDataToExternalApi(Customer customer)
        {
            // Simulating external API call
            Console.WriteLine($"Customer details for {customer.Name} sent to external API.");
        }
    }

}
