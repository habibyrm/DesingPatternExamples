using VisitorPattern.AbstractProduct;
using VisitorPattern.AbstractVisitor;

namespace VisitorPattern.ConcreteProduct
{
    public class Pizza : IFood
    {
        public decimal Price { get; set; }

        public Pizza(decimal price)
        {
            Price = price;
        }
        public void Accept(IFoodVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
