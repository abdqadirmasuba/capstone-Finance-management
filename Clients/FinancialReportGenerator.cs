using capstone.Models;

namespace capstone.Clients
{
    // Generates financial reports
    public class FinancialReportGenerator
    {
        public void GenerateMonthlyReport(FinancialReport report)
        {
            report.GenerateMonthlyReport();
        }

        public void GenerateYearlyReport(FinancialReport report)
        {
            report.GenerateYearlyReport();
        }
    }
}