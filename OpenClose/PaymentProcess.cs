using OpenClose.Abstract;

namespace OpenClose
{
    public class PaymentProcess
    {
        private IPayment _payment;

        public PaymentProcess(IPayment payment)
        {
            _payment = payment;
        }

        public void MakePayment()
        {
            _payment.MakePayment();
        }
    }
}
