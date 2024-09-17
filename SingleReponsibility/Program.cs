/*SENARYO:
 * Bir e-ticaret sisteminde müşteri verilerini farklı 
 * mikroservisler aracılığıyla yönetiyoruz. Veritabanı işlemleri, 
 * doğrulamalar, raporlama ve dış API çağrıları gibi işlemler farklı 
 * mikroservisler tarafından gerçekleştiriliyor. Müşteri bilgilerinin 
 * güncellenmesi sürecini ele alacağız*/

using SingleReponsibility;
using SingleReponsibility.BadExample;
using SingleReponsibility.CorrectExample;

class Program
{
    static void Main(string[] args)
    {
        // Creating the customer object
        Customer customer = new Customer
        {
            Id = 1,
            Name = "John Doe",
            Email = "john.doe@example.com",
            Address = "123 Main Street"
        };
        /***********************************/
        Console.WriteLine("BAD EXAMPLE");
        // Using the single service with multiple responsibilities
        CustomerService customerService = new CustomerService();

        try
        {
            customerService.UpdateCustomerDetails(customer);
            Console.WriteLine("Customer details successfully processed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        /************************************/
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("GOOD EXAMPLE");
        /************************************/
        // Creating the services
        CustomerDatabaseService databaseService = new CustomerDatabaseService();
        CustomerValidationService validationService = new CustomerValidationService();
        CustomerApiService apiService = new CustomerApiService();

        // Creating the processor and injecting the services
        CustomerProcessor processor = new CustomerProcessor(databaseService, validationService, apiService);

        // Processing customer details
        try
        {
            processor.UpdateCustomerDetails(customer);
            Console.WriteLine("Customer details successfully processed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        /******************************************/
    }
}