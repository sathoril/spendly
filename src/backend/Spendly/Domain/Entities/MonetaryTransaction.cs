namespace Domain.Entities;

public class MonetaryTransaction
{
    public Expense Expense { get; set; }
    public Income Income { get; set; }
    public DateTime CreationDateTime { get; set; }
}