namespace capstone.Models
{
    // Interface for payment modes
    public interface IPaymentMode
    {
        void ProcessPayment( IDecorateInvoice invoice);
    }
}