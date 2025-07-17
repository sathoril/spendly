namespace Domain.Entities;

public class DailyTransaction(
    string id,
    decimal incomeAmount,
    decimal expenseAmount,
    DateTime ocurrenceDateTime,
    decimal currentBalance)
{
    public string Id { get; set; } = id;
    public decimal IncomeAmount { get; set; } = incomeAmount;
    public decimal ExpenseAmount { get; set; } = expenseAmount;
    public DateTime OcurrenceDateTime { get; set; } = ocurrenceDateTime;
    public decimal CurrentBalance { get; set; } = currentBalance;
}