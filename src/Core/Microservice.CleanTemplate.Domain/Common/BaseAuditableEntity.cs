namespace Microservice.CleanTemplate.Domain.Common;

public abstract class BaseAuditableEntity<T>: BaseEntity<T>
{

    public DateTimeOffset Created { get; private set; }

    public int CreatedBy { get; private set; }

    public DateTimeOffset LastModified { get;private set; }

    public int? LastModifiedBy { get; private set; }
}