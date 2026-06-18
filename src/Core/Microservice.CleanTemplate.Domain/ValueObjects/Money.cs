namespace Microservice.CleanTemplate.Domain.ValueObjects;

public class Money
{
    public decimal Amount { get; init; }
    public string Currency { get; init; }
    private Money(decimal amount, string currency)
    {
        if (amount < 0)
            throw new ArgumentException("Amount cannot be negative.");

        Amount = amount;
        Currency = currency;
    }

    public static Money FromDecimal(decimal amount, string currency = "USD")
    {
        return new Money(amount, currency);
    }
}