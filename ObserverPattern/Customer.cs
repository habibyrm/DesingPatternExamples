using ObserverPattern.Product;

namespace ObserverPattern
{
    public class Customer : IObserver
    {
        public string Name { get; private set; }

        public Customer(string name)
        {
            Name = name;
        }

        public void Update(IProduct product)
        {
            Console.WriteLine($"{Name} müşterisine bildirim: {product.Name} - {product.Model} ürününün fiyatı değişti: {product.Price} TL");
        }
    }
}
