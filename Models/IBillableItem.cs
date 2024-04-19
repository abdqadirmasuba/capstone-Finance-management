namespace capstone.Models
{
    // Interface for billable items
    public interface IBillableItem
    {
        string Name { get; }
        string Description { get; }
        decimal Price { get; }
    }
}