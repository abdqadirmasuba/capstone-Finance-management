using capstone.Models;
using System.Collections.Generic;

namespace capstone.Clients
{
    public class DecorateInvoice : IDecorateInvoice
    {
        private decimal Price { get; set; }
        private string? BillableItem { get; set; }
        private DateTime CurrentDate { get; set; }
        private decimal TaxRate { get; } = 1.5m;

        public void SetPrice(decimal price)
        {
            Price = price;
        }

        public void SetBillableItem(string item)
        {
            BillableItem = item;
        }

        public void SetCurrentDate()
        {
            CurrentDate = DateTime.Now;
        }

        public void AddTax()
        {
            decimal taxAmount = Price * (TaxRate / 100);
            Price += taxAmount;
        }

        public decimal GetTotalAmount()
        {
            return Price;
        }

        public string GetInvoiceDetails()
        {
            return $"Invoice Details:\n" +
       $"-------------------------------------\n" +
       $"Billable Item: {BillableItem}\n" +
       $"Price: {Price:C}\n" +
       $"Date: {CurrentDate.ToString("yyyy-MM-dd HH:mm:ss")}\n" +
       $"Tax (1.5%): {(Price * 0.015m):C}\n" + // Calculate and display tax
       $"Total Amount: {(Price * 1.015m):C}"; // Add tax to total amount
        }
    }
}
