using capstone.Models;
using System;

namespace capstone.Clients.PaymentModes
{
    // Concrete implementation of cash payment mode
    public class CashPaymentMode : IPaymentMode
    {
        public void ProcessPayment(IDecorateInvoice invoice)
        {
            Console.WriteLine($"Processing cash payment for total amount: {invoice.GetTotalAmount()}");
        }
    }
}
