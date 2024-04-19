using System;
using capstone.Clients;
namespace capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            FinanceManager financeManager = new FinanceManager();
            financeManager.ProcessInvoices();


        }
    }
}