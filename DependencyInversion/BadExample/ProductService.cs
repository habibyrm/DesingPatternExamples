namespace DependencyInversion.BadExample
{
    public class ProductService
    {
        private readonly SqlProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new SqlProductRepository();  // Somut sınıfa doğrudan bağımlılık
        }

        public void AddProduct(string productName)
        {
            _productRepository.AddProduct(productName);
        }

        public string GetProduct(int productId)
        {
            return _productRepository.GetProduct(productId);
        }
    }
}
