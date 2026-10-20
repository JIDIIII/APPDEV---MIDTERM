using System.Collections.ObjectModel;
using Midterm.Domain.Products;

namespace Midterm.Domain.Cart;

public sealed class ShoppingCart
{
    private readonly List<CartLine> _items = [];
    private readonly ReadOnlyCollection<CartLine> _readOnlyItems;

    public ShoppingCart() => _readOnlyItems = _items.AsReadOnly();

    public IReadOnlyList<CartLine> Items => _readOnlyItems;
    public int ItemCount => _items.Sum(item => item.Quantity);
    public decimal Subtotal => _items.Sum(item => item.LineTotal);

    public void Add(Product product, ProductVariant variant, int quantity = 1)
    {
        ArgumentNullException.ThrowIfNull(product);
        ArgumentNullException.ThrowIfNull(variant);
        if (quantity < 1) throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be at least one.");
        if (product.Price < 0m) throw new ArgumentOutOfRangeException(nameof(product), "Product price cannot be negative.");

        var existingIndex = _items.FindIndex(item =>
            item.Product.Id == product.Id && item.Variant.Id == variant.Id);

        if (existingIndex >= 0)
        {
            var existing = _items[existingIndex];
            _items[existingIndex] = existing with { Quantity = checked(existing.Quantity + quantity) };
            return;
        }

        _items.Add(new CartLine(product, variant, quantity));
    }

    public void SetQuantity(string productId, string variantId, int quantity)
    {
        if (quantity < 1) return;
        var index = _items.FindIndex(item => item.Product.Id == productId && item.Variant.Id == variantId);
        if (index < 0) return;
        _items[index] = _items[index] with { Quantity = quantity };
    }

    public void Remove(string productId, string variantId) =>
        _items.RemoveAll(item => item.Product.Id == productId && item.Variant.Id == variantId);

    public void Clear() => _items.Clear();
}
