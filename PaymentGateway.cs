using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    public interface IPaymentMethod
    {
        void ProcessPayment(double amount);
    }

    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment(double amount)
        {
            // implementation of credit card payment processing
        }
    }

    public class PayPalPayment : IPaymentMethod
    {
        public void ProcessPayment(double amount)
        {
            // implementation of PayPal payment processing
        }
    }

    public class PaymentProcessor
    {
        private IPaymentMethod _paymentMethod;

        public PaymentProcessor(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void SetPaymentMethod(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void ProcessPayment(double amount)
        {
            _paymentMethod.ProcessPayment(amount);
        }
    }
    public abstract class PaymentGateway
    {
        public abstract void processPayment(double amount);
    }

    public class PayPalGateway : PaymentGateway
    {
        public override void processPayment(double amount)
        {
            Console.WriteLine($"Processing payment of {amount} via PayPal.");
        }
    }

    public class StripeGateway : PaymentGateway
    {
        public override void processPayment(double amount)
        {
            Console.WriteLine($"Processing payment of {amount} via Stripe.");
        }
    }

    public class PaymentProcessor
    {
        private PaymentGateway gateway;

        public PaymentProcessor(PaymentGateway gateway)
        {
            this.gateway = gateway;
        }

        public void process(double amount)
        {
            gateway.processPayment(amount);
        }
    }

}
