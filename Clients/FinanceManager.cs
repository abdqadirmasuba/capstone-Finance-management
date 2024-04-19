using System;
using capstone.Models;

namespace capstone.Clients
{
    // Handles finance management operations
    public class FinanceManager
    {
        // Process invoices
        public void ProcessInvoices()
        {
            Console.WriteLine("Welcome to the Finance Management System!");

            // Simulate a list of billable items
            BillableItem[] billableItems = BillableItemProvider.GetBillableItems();

            // Display available billable items
            Console.WriteLine("Available billable items:");
            for (int i = 0; i < billableItems.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {billableItems[i].Name}");
            }
            // Prompt user to select a billable item
            Console.Write("Select a billable item by entering its number: ");
            int selectedItemIndex = int.Parse(Console.ReadLine()) - 1;

            // Prompt user to enter amount to bill
            Console.Write("Enter the amount to bill: ");
            decimal amountToBill = decimal.Parse(Console.ReadLine());

            // Create an instance of DecorateInvoice
            IDecorateInvoice decorator = new DecorateInvoice();

            // Set price, billable item, and current date
            decorator.SetPrice(amountToBill); // Use the entered amount as the price
            decorator.SetBillableItem(billableItems[selectedItemIndex].Name); // Use the selected billable item
            decorator.SetCurrentDate();

            // Add tax
            decorator.AddTax();

            // Get invoice details
            string invoiceDetails = decorator.GetInvoiceDetails();

            Console.WriteLine(invoiceDetails);

            Console.WriteLine("Processing payment...");
            Console.WriteLine(decorator.GetTotalAmount());

            PaymentProcessor paymentProcessor = new PaymentProcessor();
            paymentProcessor.ProcessPayments(decorator.GetTotalAmount());


            Console.WriteLine("Process ended sucessfully!");
            // Console.WriteLine(invoice);
        }
    }
}
