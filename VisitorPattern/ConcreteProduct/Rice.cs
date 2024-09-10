using VisitorPattern.AbstractProduct;
using VisitorPattern.AbstractVisitor;

namespace VisitorPattern.ConcreteProduct
{
    public class Rice : IFood
    {
        public decimal Price { get; set; }

        public Rice(decimal price)
        {
            Price = price;
        }
        public void Accept(IFoodVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
