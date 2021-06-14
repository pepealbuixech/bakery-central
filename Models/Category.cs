using System.Collections.Generic;

namespace Bakery.Models
{
    public record Category(
        string Id,
        string Name,
        string Description, 
        IEnumerable<Product> Products
    );
}
