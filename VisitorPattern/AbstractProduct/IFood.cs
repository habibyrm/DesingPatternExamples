using VisitorPattern.AbstractVisitor;

namespace VisitorPattern.AbstractProduct
{
    public interface IFood
    {
        decimal Price { get; set; }
        void Accept(IFoodVisitor visitor);
    }
}
