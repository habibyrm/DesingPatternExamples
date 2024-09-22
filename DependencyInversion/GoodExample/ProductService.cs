namespace DependencyInversion.GoodExample
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
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
