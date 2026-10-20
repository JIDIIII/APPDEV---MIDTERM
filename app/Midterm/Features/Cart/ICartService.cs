using Midterm.Domain.Cart;
using Midterm.Domain.Products;

namespace Midterm.Features.Cart;

public interface ICartService
{
    event Action? Changed;
    IReadOnlyList<CartLine> Items { get; }
    int ItemCount { get; }
    decimal Subtotal { get; }
    void Add(Product product, ProductVariant variant, int quantity = 1);
    void SetQuantity(string productId, string variantId, int quantity);
    void Remove(string productId, string variantId);
    void Clear();
}
