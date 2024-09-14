using OpenClose.Abstract;

namespace OpenClose.Concrete
{
    public class PaypalPayment : IPayment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment was made by paypal.");
        }
    }
}
