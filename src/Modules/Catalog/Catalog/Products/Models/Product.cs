
namespace Catalog.Products.Models;

public class Product : Aggregate<Guid>
{
    public string Name { get; private set; } = string.Empty;
    public List<string> Category { get; private set; } = new();

    public string Description { get; private set; } = string.Empty;

    public decimal Price { get; private set; }
    public string ImageUrl { get; private set; } = string.Empty;


    //We will take the domain rich model approach for Product entity in this case.

    public static Product Create(string name, List<string> category, string description, decimal price, string imageUrl)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);
        

        var product = new Product
        {
            Id = Guid.NewGuid(),
            Name = name,
            Category = category,
            Description = description,
            Price = price,
            ImageUrl = imageUrl,
            CreatedAt = DateTime.UtcNow
        };
        // Here you can add domain events if needed
         product.AddDomainEvent(new ProductCreatedEvent(product));
        return product;
    }



    // update methods for rich domain model
    public void Update(string name, List<string> category, string description, decimal price, string imageUrl)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);

        Name = name;
        Category = category;
        Description = description;
        
        ImageUrl = imageUrl;
        // if price changes we will raise a domain event call

        if(Price != price)
        {
            Price = price;
            AddDomainEvent(new ProductPriceChangedEvent(this));
        }
        



    }
}
