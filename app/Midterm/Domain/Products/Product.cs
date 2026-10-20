namespace Midterm.Domain.Products;

public sealed record Product(
    string Id,
    string Name,
    string Category,
    string Description,
    decimal Price,
    string ImageUrl,
    string ImageAlt,
    IReadOnlyList<ProductVariant> Variants,
    bool RequiresQuickView = false);
