
namespace capstone.Models
{
    public interface IDecorateInvoice
    {
        void SetPrice(decimal price);
        void SetBillableItem(string item);
        void SetCurrentDate();
        void AddTax();
        decimal GetTotalAmount();
        string GetInvoiceDetails();
    }
}