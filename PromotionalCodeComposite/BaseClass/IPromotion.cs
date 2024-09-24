namespace PromotionalCodeComposite
{
    public interface IPromotion
    {
        string Code { get; }
        decimal ApplyDiscount(decimal price);
    }
}
