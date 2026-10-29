using Midterm.Domain.Cart;
using Midterm.Domain.Products;
using Midterm.Features.Catalog;

namespace Midterm.Features.Cart;

public sealed class CartService : ICartService
{
    private readonly ShoppingCart _cart = new();

    public CartService(IProductCatalog catalog)
    {
        AddInitialBagLine(catalog, "horizon-one");
        AddInitialBagLine(catalog, "tide-mini");
    }

    public event Action? Changed;
    public IReadOnlyList<CartLine> Items => _cart.Items;
    public int ItemCount => _cart.ItemCount;
    public decimal Subtotal => _cart.Subtotal;

    public void Add(Product product, ProductVariant variant, int quantity = 1)
    {
        _cart.Add(product, variant, quantity);
        Changed?.Invoke();
    }

    public void SetQuantity(string productId, string variantId, int quantity)
    {
        _cart.SetQuantity(productId, variantId, quantity);
        Changed?.Invoke();
    }

    public void Remove(string productId, string variantId)
    {
        _cart.Remove(productId, variantId);
        Changed?.Invoke();
    }

    public void Clear()
    {
        _cart.Clear();
        Changed?.Invoke();
    }

    private void AddInitialBagLine(IProductCatalog catalog, string productId)
    {
        var product = catalog.FindById(productId)
            ?? throw new InvalidOperationException($"Initial product '{productId}' is missing from the catalog.");
        _cart.Add(product, product.Variants[0]);
    }
}
