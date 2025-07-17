namespace Domain.Entities;

public class CurrentBalance
{
    public decimal Amount { get; set; }
    public DateTime LastAmountCalculationDateTime { get; set; }
    public decimal PreviousAmount { get; set; }
}