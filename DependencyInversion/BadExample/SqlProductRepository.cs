namespace DependencyInversion.BadExample
{
    public class SqlProductRepository
    {
        public void AddProduct(string productName)
        {
            Console.WriteLine("Product added to SQL Server database.");
        }

        public string GetProduct(int productId)
        {
            return $"Product {productId} from SQL Server database.";
        }
    }
}
