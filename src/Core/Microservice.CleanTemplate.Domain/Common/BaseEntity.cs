namespace Microservice.CleanTemplate.Domain.Common;

public abstract class BaseEntity<T>
{
    /// <summary>
    /// Primary Key
    /// </summary>
    public T Id { get; protected set; }
}