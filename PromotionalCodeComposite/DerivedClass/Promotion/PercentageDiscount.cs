namespace PromotionalCodeComposite.DerivedClass.Promotion
{
    public class PercentageDiscount : IPromotion
    {
        public string Code { get; }
        private decimal _percentage;

        public PercentageDiscount(string code, decimal percentage)
        {
            Code = code;
            _percentage = percentage;
        }

        public decimal ApplyDiscount(decimal price)
        {
            return price * (1 - _percentage / 100);
        }
    }
}
