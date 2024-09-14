using OpenClose.Abstract;

namespace OpenClose.Concrete
{
    public class CreditCardPayment : IPayment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment was made by credit card");
        }
    }
}
