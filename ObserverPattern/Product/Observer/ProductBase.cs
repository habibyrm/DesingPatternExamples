namespace ObserverPattern.Product.Observer
{
    public abstract class ProductBase : IProduct
    {
        private List<IObserver> _observers = new List<IObserver>();

        public string Name { get; private set; }

        public string Model { get; private set; }

        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    NotifyObservers();
                }
            }
        }

        public ProductBase(string name, string model, decimal price)
        {
            Name = name;
            Model = model;
            _price = price;
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
