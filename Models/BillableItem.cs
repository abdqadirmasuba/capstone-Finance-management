namespace capstone.Models
{
    // Represents a billable item
    public class BillableItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Constructor
        public BillableItem(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}