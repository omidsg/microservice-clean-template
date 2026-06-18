using Microservice.CleanTemplate.Domain.Common;
using Microservice.CleanTemplate.Domain.Enums;
using Microservice.CleanTemplate.Domain.ValueObjects;

namespace Microservice.CleanTemplate.Domain.Entities;

public class Sample : BaseAuditableEntity<int>
{
    public string Title { get; private set; } = null!;
    public Money Price { get; private set; }
    public int AvailableStock { get; private set; }
    public SampleType Type { get; private set; }
    public bool IsActive { get; private set; }
  

    /// <summary>
    /// Just for EF Core proxies and tracking
    /// </summary>
    protected Sample()
    {
    }
    public Sample(string title, Money price, int availableStock,SampleType type,bool isActive)
    {
        if (availableStock < 0)
            throw new ArgumentException("Initial stock cannot be negative.");
        ChangeTitle(title);
        UpdatePrice(price);
        AvailableStock = availableStock;
        ChangeType(type);
        IsActive = isActive;
    }
    public void ChangeTitle(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentNullException(nameof(title), "Title cannot be empty.");
        }
        this.Title = title;
    }
    
    public void ReduceStock(int quantity)
    {
        if (quantity <= 0)
            throw new ArgumentException("Quantity to reduce must be greater than zero.");

        if (AvailableStock - quantity < 0)
            throw new ArgumentException("Inadequate stock available.");

        AvailableStock -= quantity;
    }

    public void UpdatePrice(Money newPrice)
    {
        Price = newPrice ?? throw new ArgumentNullException(nameof(newPrice));
        this.Price = newPrice;
    }

    public void Deactivate()
    {
        IsActive = false;
    }
    public void Activate()
    {
        IsActive = true;
    }
    
    public void ChangeType(SampleType type)
    {
        this.Type = type;
    }
    public static Sample CreateGoldSampleSample(string title,Money price, int availableStock,bool isActive)
    {
        return new Sample(title, price, availableStock, SampleType.Gold,isActive);
    }

    public static Sample CreateSilverSample(string title, Money price, int availableStock,bool isActive)
    {
        return new Sample(title, price, availableStock, SampleType.Silver,isActive);
    }

    public static Sample CreateBronzeSample(string title, Money price, int availableStock,bool isActive)
    {
        return new Sample(title, price, availableStock, SampleType.Bronze,isActive);
    }
}