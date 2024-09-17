namespace SingleReponsibility.CorrectExample
{
    public class CustomerValidationService
    {
        public bool ValidateCustomerDetails(Customer customer)
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
    }
}
