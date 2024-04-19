using capstone.Models;
using capstone.Clients.PaymentModes;
using System;

namespace capstone.Clients
{
    // Factory for creating payment modes
    public static class PaymentModeFactory
    {
        public static IPaymentMode PickPaymentMode(PaymentMethod method)
        {
            switch (method)
            {
                case PaymentMethod.Cash:
                    return new CashPaymentMode();
                case PaymentMethod.CreditCard:
                    return new CreditCardPaymentMode();
                case PaymentMethod.MobileMoney:
                    return new MobileMoneyPaymentMode();
                case PaymentMethod.BankTransfer:
                    return new BankTransferPaymentMode();
                default:
                    throw new ArgumentException("Invalid payment method.");
            }
        }
    }
}
