using SpendSplit.Domain.Enums;

namespace SpendSplit.Domain.Entities;

public class Expense
{
    public Guid Id { get; set; }
    public Guid GroupId { get; set; }
    public Group Group { get; set; } = null!;
    public Guid PaidById { get; set; }
    public User PaidBy { get; set; } = null!;
    public decimal Amount { get; set; }
    public string Description { get; set; } = string.Empty;
    public Category Category { get; set; }
    public DateTime CreatedAt { get; set; }
    public ICollection<ExpenseSplit> Splits { get; set; } = new List<ExpenseSplit>();
}
