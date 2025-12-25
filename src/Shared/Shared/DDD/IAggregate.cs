namespace Shared.DDD
{

    //generic IAggregate could be created if needed
    public interface IAggregate<T> : IAggregate, IEntity<T>
    {
       IReadOnlyList<IDomainEvent> DomainEvents { get; }
        IDomainEvent[] ClearDomainEvents();
    }



    public interface IAggregate : IEntity
    {
       IReadOnlyList<IDomainEvent> DomainEvents { get; }

        IDomainEvent[] ClearDomainEvents();
    }
}
