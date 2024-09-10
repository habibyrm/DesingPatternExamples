using VisitorPattern.AbstractProduct;
using VisitorPattern.AbstractVisitor;

namespace VisitorPattern.ConcreteProduct
{
    public class Sandwich : IFood
    {
        public decimal Price { get; set; }

        public Sandwich(decimal price)
        {
            Price = price;
        }
        public void Accept(IFoodVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
