using ObserverPattern.Product;

namespace ObserverPattern
{
    public class Basket : IObserver
    {
        private List<IProduct> _products = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            _products.Add(product);
            product.AddObserver(this);
        }

        public void RemoveProduct(IProduct product)
        {
            _products.Remove(product);
            product.RemoveObserver(this);
        }

        public void Update(IProduct product)
        {
            Console.WriteLine($"Sepetteki {product.Name} - {product.Model} ürününün fiyatı güncellendi: {product.Price} TL");
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;

            foreach (var product in _products)
            {
                total += product.Price;
            }

            return total;
        }
    }
}

