using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpendSplit.Domain.Entities;

namespace SpendSplit.Infrastructure.Data.Configurations;

public class ExpenseSplitConfiguration : IEntityTypeConfiguration<ExpenseSplit>
{
    public void Configure(EntityTypeBuilder<ExpenseSplit> builder)
    {
        builder.HasKey(es => es.Id);

        builder.Property(es => es.ShareAmount)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.HasOne(es => es.Expense)
            .WithMany(e => e.Splits)
            .HasForeignKey(es => es.ExpenseId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(es => es.User)
            .WithMany()
            .HasForeignKey(es => es.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
