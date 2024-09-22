namespace DependencyInversion.GoodExample
{
    public interface IProductRepository
    {
        void AddProduct(string productName);
        string GetProduct(int productId);
    }
}
