using OpenClose;
using OpenClose.Abstract;
using OpenClose.Concrete;

IPayment payment = new CreditCardPayment();
PaymentProcess process = new PaymentProcess(payment);
process.MakePayment();
