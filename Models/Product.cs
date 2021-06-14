namespace Bakery.Models
{
    public record Product(
        string Id,
        string Name,
        string Description,
        decimal Price,
        string Currency,
        string Unit
    );
}
