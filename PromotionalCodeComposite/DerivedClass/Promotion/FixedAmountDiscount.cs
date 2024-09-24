namespace PromotionalCodeComposite.DerivedClass.Promotion
{
    public class FixedAmountDiscount : IPromotion
    {
        public string Code { get; }
        private decimal _amount;

        public FixedAmountDiscount(string code, decimal amount)
        {
            Code = code;
            _amount = amount;
        }

        public decimal ApplyDiscount(decimal price)
        {
            return Math.Max(price - _amount, 0);
        }
    }
}
