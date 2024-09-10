using VisitorPattern.AbstractVisitor;
using VisitorPattern.ConcreteProduct;

namespace VisitorPattern.ConcreteVisitor
{
    public class TaxVisitor : IFoodVisitor
    {
        public void Visit(Pizza pizza)
        {
            pizza.Price += GetPercent(pizza.Price, 8);
        }

        public void Visit(Rice rice)
        {
            rice.Price += GetPercent(rice.Price, 2);
        }

        public void Visit(Sandwich sandwich)
        {
            sandwich.Price += GetPercent(sandwich.Price, 3);
        }

        public void Visit(Soup soup)
        {
            soup.Price += GetPercent(soup.Price, 1);
        }

        private decimal GetPercent(decimal price, decimal percent)
        {
            if (percent > 0)
                return price * (percent / 100);
            return 0;
        }
    }
}
