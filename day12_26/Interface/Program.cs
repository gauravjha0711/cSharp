using System;
public class Program
{
    public static void Main()
    {
        IPayment payment;
        payment = new CreditCardPayment();
        payment.Refund(1000.0);
        payment.Pay(1524.0);

        payment = new UPIPayment();
        payment.Refund(500.0);
        payment.Pay(2500.0);
    }
}