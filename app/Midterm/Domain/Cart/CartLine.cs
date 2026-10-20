using Midterm.Domain.Products;

namespace Midterm.Domain.Cart;

public sealed record CartLine(Product Product, ProductVariant Variant, int Quantity)
{
    public decimal LineTotal => Product.Price * Quantity;
}
