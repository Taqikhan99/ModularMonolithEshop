namespace Catalog.Events
{
    public record ProductPriceChangedEvent (Product product) : IDomainEvent;
   
}
