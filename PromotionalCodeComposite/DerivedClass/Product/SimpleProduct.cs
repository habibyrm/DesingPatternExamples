
namespace PromotionalCodeComposite.DerivedClass.Product
{
    public class SimpleProduct : IProduct
    {
        public string Name { get; }
        private decimal _price;
        private List<IPromotion> _appliedPromotions = new List<IPromotion>();

        public SimpleProduct(string name, decimal price)
        {
            Name = name;
            _price = price;
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

        public decimal GetPrice()
        {
            decimal discountedPrice = _price;
            foreach (var promotion in _appliedPromotions)
            {
                discountedPrice = promotion.ApplyDiscount(discountedPrice);
            }
            return discountedPrice;
        }
    }
}
