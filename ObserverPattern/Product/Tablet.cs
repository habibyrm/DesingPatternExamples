using ObserverPattern.Product.Observer;

namespace ObserverPattern.Product
{
    public class Tablet : ProductBase
    {
        public Tablet(string model, decimal price) : base("Tablet", model, price) { }
    }
}
