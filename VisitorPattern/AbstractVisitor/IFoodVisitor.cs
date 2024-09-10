using VisitorPattern.ConcreteProduct;

namespace VisitorPattern.AbstractVisitor
{
    public interface IFoodVisitor
    {
        void Visit(Pizza pizza);
        void Visit(Rice rice);
        void Visit(Sandwich sandwich);
        void Visit(Soup soup);
    }
}
