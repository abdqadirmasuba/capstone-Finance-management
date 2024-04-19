using capstone.Models;
using System;

namespace capstone.Clients.PaymentModes
{
    // Concrete implementation of credit card payment mode
    public class CreditCardPaymentMode : IPaymentMode
    {
        public void ProcessPayment(IDecorateInvoice invoice)
        {
            Console.WriteLine($"Processing credit card payment for total amount: {invoice.GetTotalAmount()}");
        }
    }
}