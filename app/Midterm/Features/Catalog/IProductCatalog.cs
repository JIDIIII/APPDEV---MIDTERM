using Midterm.Domain.Products;

namespace Midterm.Features.Catalog;

public interface IProductCatalog
{
    IReadOnlyList<Product> Products { get; }
    Product? FindById(string productId);
}
