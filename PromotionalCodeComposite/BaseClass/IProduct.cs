namespace PromotionalCodeComposite
{
    public interface IProduct
    {
        string Name { get; }
        decimal GetPrice();
        void ApplyPromotion(IPromotion promotion);
        List<IPromotion> GetAppliedPromotions();
    }
}
