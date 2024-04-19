using capstone.Models;
using System;

namespace capstone.Clients.PaymentModes
{
    // Concrete implementation of mobile money payment mode
    public class MobileMoneyPaymentMode : IPaymentMode
    {
        public void ProcessPayment(IDecorateInvoice invoice)
        {
            Console.WriteLine($"Processing mobile money payment for total amount: {invoice.GetTotalAmount()}");
        }
    }
}
