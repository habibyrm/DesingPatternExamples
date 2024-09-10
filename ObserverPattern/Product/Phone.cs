using ObserverPattern.Product.Observer;

namespace ObserverPattern.Product
{
    public class Phone : ProductBase
    {
        public Phone(string model, decimal price) : base("Telefon", model, price) { }
    }
}
