using System;
using System.Collections.Generic;
using capstone.Clients.PaymentModes;
using capstone.Models;
using capstone.Clients;

namespace capstone
{
  public class PaymentProcessor
    {
        public void ProcessPayments(decimal amountToPay)
        {
            Console.WriteLine("Available Payment Modes:");
            Console.WriteLine("1. Cash");
            Console.WriteLine("2. Credit Card");
            Console.WriteLine("3. Mobile Money");
            Console.WriteLine("4. Bank Transfer");

            Console.Write("Select a payment mode by entering its number: ");
            int selectedModeIndex = int.Parse(Console.ReadLine());

            // Convert the selected index to a PaymentMethod enum value
            PaymentMethod selectedMethod = (PaymentMethod)(selectedModeIndex - 1);

            try
            {
                // Create an instance of the selected payment mode using the static factory method
                IPaymentMode selectedMode = PaymentModeFactory.PickPaymentMode(selectedMethod);

                // Process payment using the selected payment mode
                Console.WriteLine($"Processing payment using {selectedMode.GetType().Name}...");
                // selectedMode.ProcessPayment(amountToPay);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}