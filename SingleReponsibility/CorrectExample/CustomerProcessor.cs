namespace SingleReponsibility.CorrectExample
{
    public class CustomerProcessor
    {
        private CustomerDatabaseService _databaseService;
        private CustomerValidationService _validationService;
        private CustomerApiService _apiService;

        public CustomerProcessor(CustomerDatabaseService databaseService,
                                 CustomerValidationService validationService,
                                 CustomerApiService apiService)
        {
            _databaseService = databaseService;
            _validationService = validationService;
            _apiService = apiService;
        }

        public void UpdateCustomerDetails(Customer customer)
        {
            // Update in the database
            _databaseService.UpdateInDatabase(customer);

            // Validate customer details
            if (!_validationService.ValidateCustomerDetails(customer))
            {
                throw new Exception("Invalid customer details");
            }

            // Send data to external API
            _apiService.SendDataToExternalApi(customer);
        }
    }
}
