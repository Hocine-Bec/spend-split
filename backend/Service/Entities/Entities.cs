using System;

public class Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public ICollection<GroupMember> GroupMembers { get; set; }
        public ICollection<Expense> PaidExpenses { get; set; }
    }
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid CreatedById { get; set; }
        public User CreatedBy { get; set; }

        public ICollection<GroupMember> Members { get; set; }
        public ICollection<Expense> Expenses { get; set; }
    }
    public class GroupMember
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid GroupId { get; set; }
        public Group Group { get; set; }

        public DateTime JoinedAt { get; set; }
    }
    public class Expense
    {
        public Guid Id { get; set; }

        public Guid GroupId { get; set; }
        public Group Group { get; set; }

        public Guid PaidById { get; set; }
        public User PaidBy { get; set; }

        public decimal Amount { get; set; }
        public string Description { get; set; }

        public Category Category { get; set; }

        public DateTime CreatedAt { get; set; }

        public ICollection<ExpenseSplit> Splits { get; set; }
    }
    public class ExpenseSplit
    {
        public Guid Id { get; set; }

        public Guid ExpenseId { get; set; }
        public Expense Expense { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public decimal ShareAmount { get; set; }
    }

}
