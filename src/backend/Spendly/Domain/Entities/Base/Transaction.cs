namespace Domain.Entities.Base;

public class Transaction
{
    public string Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime CreationDateTime { get; set; }
}