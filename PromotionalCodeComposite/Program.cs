using PromotionalCodeComposite.BaseClass;
using PromotionalCodeComposite.DerivedClass.Product;
using PromotionalCodeComposite.DerivedClass.Promotion;
using PromotionalCodeComposite.DerivedClass.ShoppingCart;
using PromotionalCodeComposite;

class Program
{
    static void Main()
    {
        IShoppingCart cart = new ShoppingCart();

        IProduct laptop = new SimpleProduct("Laptop", 1000m);
        IProduct mouse = new SimpleProduct("Mouse", 50m);
        ProductBundle bundle = new ProductBundle("Ofis Packet");
        bundle.AddProduct(new SimpleProduct("Klavye", 100m));
        bundle.AddProduct(new SimpleProduct("Monitor", 200m));

        cart.AddItem(laptop);
        cart.AddItem(mouse);
        cart.AddItem(bundle);

        IPromotion tenPercentOff = new PercentageDiscount("Percent10", 10);
        IPromotion fiftyOff = new FixedAmountDiscount("50$", 50);

        Console.WriteLine("Original Basket:");
        cart.DisplayCart();

        try
        {
            cart.ApplyPromotionToProduct(0, tenPercentOff);
            cart.ApplyPromotionToProduct(0, fiftyOff);
            cart.ApplyPromotionToProduct(2, tenPercentOff);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine("\nAfter Promotion is Applied:");
        cart.DisplayCart();
    }
}