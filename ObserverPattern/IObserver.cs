using ObserverPattern.Product;

namespace ObserverPattern
{
    public interface IObserver
    {
        void Update(IProduct product);
    }
}
