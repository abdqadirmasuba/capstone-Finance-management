using capstone.Models;
using System;

namespace capstone.Clients.PaymentModes
{
    // Concrete implementation of bank transfer payment mode
    public class BankTransferPaymentMode : IPaymentMode
    {
        public void ProcessPayment(IDecorateInvoice invoice)
        {
            Console.WriteLine($"Processing bank transfer payment for total amount: {invoice.GetTotalAmount()}");
        }
    }
}
