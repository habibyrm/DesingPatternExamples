namespace DependencyInversion.GoodExample
{
    public class PostgreSqlProductRepository : IProductRepository
    {
        public void AddProduct(string productName)
        {
            Console.WriteLine("Product added to PostgreSQL database.");
        }

        public string GetProduct(int productId)
        {
            return $"Product {productId} from PostgreSQL database.";
        }
    }
}
