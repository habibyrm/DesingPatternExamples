namespace PromotionalCodeComposite.DerivedClass.Product
{
    public class ProductBundle : IProduct
    {
        public string Name { get; }
        private List<IProduct> _products = new List<IProduct>();
        private List<IPromotion> _appliedPromotions = new List<IPromotion>();

        public ProductBundle(string name)
        {
            Name = name;
        }

        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }

        public decimal GetPrice()
        {
            decimal totalPrice = _products.Sum(p => p.GetPrice());
            foreach (var promotion in _appliedPromotions)
            {
                totalPrice = promotion.ApplyDiscount(totalPrice);
            }
            return totalPrice;
        }

        public void ApplyPromotion(IPromotion promotion)
        {
            if (_appliedPromotions.Count < 2)
            {
                _appliedPromotions.Add(promotion);
            }
            else
            {
                throw new InvalidOperationException("A maximum of 2 promotional codes can be applied.");
            }
        }

        public List<IPromotion> GetAppliedPromotions() => _appliedPromotions;
    }
}
