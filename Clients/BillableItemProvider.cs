using capstone.Models;

namespace capstone.Clients
{
    public static class BillableItemProvider
    {
        // Returns an array of billable items
        public static BillableItem[] GetBillableItems()
        {
            return new BillableItem[]
            {
                new BillableItem(1, "Consultation", 50.00m),
                new BillableItem(2, "Lab Test", 75.00m),
                new BillableItem(3, "Pharmacy Item", 20.00m),
                new BillableItem(4, "Medical Equipment", 500.00m),
                new BillableItem(5, "Surgery", 1000.00m)
            };
        }
    }
}