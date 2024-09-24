using PromotionalCodeComposite.BaseClass;

namespace PromotionalCodeComposite.DerivedClass.ShoppingCart
{
    public class ShoppingCart : IShoppingCart
    {
        private List<IProduct> _items = new List<IProduct>();

        public void AddItem(IProduct product)
        {
            _items.Add(product);
        }
        public void ApplyPromotionToProduct(int productIndex, IPromotion promotion)
        {
            if (productIndex >= 0 && productIndex < _items.Count)
            {
                _items[productIndex].ApplyPromotion(promotion);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(productIndex), "Invalid product index.");
            }
        }

        public void DisplayCart()
        {
            Console.WriteLine("Basket:");
            for (int i = 0; i < _items.Count; i++)
            {
                var item = _items[i];
                Console.WriteLine($"{i + 1}. {item.Name} - Price: {item.GetPrice():C}");
                var promotions = item.GetAppliedPromotions();
                if (promotions.Any())
                {
                    Console.WriteLine($"   Promotions Applied: {string.Join(", ", promotions.Select(p => p.Code))}");
                }
            }
            Console.WriteLine($"Total: {GetTotalPrice():C}");
        }

        public decimal GetTotalPrice()
        {
            return _items.Sum(item => item.GetPrice());
        }
    }
}
