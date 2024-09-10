using VisitorPattern.AbstractProduct;
using VisitorPattern.AbstractVisitor;

namespace VisitorPattern.ConcreteProduct
{
    public class Soup : IFood
    {
        public decimal Price { get; set; }

        public Soup(decimal price)
        {
            Price = price;
        }
        public void Accept(IFoodVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
