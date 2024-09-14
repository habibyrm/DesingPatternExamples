using OpenClose.Abstract;

namespace OpenClose.Concrete
{
    public class BitcoinPayment : IPayment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment was made by bitcoin.");
        }
    }
}
