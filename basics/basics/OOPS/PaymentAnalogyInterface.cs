public interface IPaymentProcessor
{
    void processPayment(double payment);
}

public class Stripe: IPaymentProcessor
{
    public void processPayment(double payment) => Console.WriteLine($"Stripe processed the payment of {payment}");
}

public class Paypal: IPaymentProcessor
{
    public void processPayment(double payment) => Console.WriteLine($"Paypal processed the payment of {payment}");
}

public class OrderCheckout
{
    public void ProcessPayment(double payment, IPaymentProcessor processor)
    {
        processor.processPayment(payment);
    }
}