namespace PromotionalCodeComposite.BaseClass
{
    public interface IShoppingCart
    {
        void AddItem(IProduct product);
        decimal GetTotalPrice();
        void ApplyPromotionToProduct(int productIndex, IPromotion promotion);
        void DisplayCart();
    }
}
