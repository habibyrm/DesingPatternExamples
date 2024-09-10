namespace ObserverPattern.Product
{
    public interface IProduct
    {
        string Name { get; }
        string Model { get; }
        decimal Price { get; set; }
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
