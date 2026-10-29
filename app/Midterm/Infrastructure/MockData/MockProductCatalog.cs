using Midterm.Domain.Products;
using Midterm.Features.Catalog;

namespace Midterm.Infrastructure.MockData;

public sealed class MockProductCatalog : IProductCatalog
{
    private static readonly IReadOnlyList<Product> Catalog = Array.AsReadOnly<Product>(
    [
        new("horizon-one", "Horizon One", "Headphones", "Wireless over-ear headphones", 18900m,
            "images/products/horizon-one.png", "Graphite over-ear headphones on a cool-gray studio surface.",
            Variants(("graphite", "Graphite", "#34383b"), ("stone", "Stone", "#d8d4ca"))),
        new("tide-mini", "Tide Mini", "Earbuds", "Noise-cancelling earbuds", 6900m,
            "images/products/tide-mini.png", "Chalk wireless earbuds in their open charging case.",
            Variants(("chalk", "Chalk", "#e7e5de"), ("charcoal", "Charcoal", "#45494c"))),
        new("roam-s", "Roam S", "Speakers", "Portable wireless speaker", 8900m,
            "images/products/roam-s.png", "Charcoal portable wireless speaker on a dark studio surface.",
            Variants(("charcoal", "Charcoal", "#34383b"), ("sand", "Sand", "#c9c2ad"))),
        new("form-two", "Form Two", "Speakers", "Powered bookshelf speaker pair", 24900m,
            "images/products/form-two.png", "Walnut bookshelf speakers in a calm living room.",
            Variants(("walnut", "Walnut", "#9a6f50"), ("black", "Black", "#303234"))),
        new("orbit-deck", "Orbit Deck", "Turntables", "Belt-drive turntable", 16900m,
            "images/products/orbit-deck.png", "Walnut belt-drive turntable with a black record on a gray surface.",
            Variants(("walnut", "Walnut", "#9a6f50"), ("black", "Black", "#35383a"))),
        new("vocal-m1", "Vocal M1", "Studio", "USB-C condenser microphone", 7900m,
            "images/products/vocal-m1.png", "Graphite condenser microphone on a desktop stand.",
            Variants(("graphite", "Graphite", "#484c4f")), RequiresQuickView: true),
        new("bridge-d1", "Bridge D1", "Studio", "Compact DAC & audio interface", 9900m,
            "images/products/bridge-d1.png", "Compact silver DAC and audio interface on a gray surface.",
            Variants(("silver", "Silver", "#c5c8c8"), ("black", "Black", "#35383a")), RequiresQuickView: true),
        new("rest-stand", "Rest Stand", "Accessories", "Aluminum headphone stand", 2900m,
            "images/products/rest-stand.png", "Aluminum headphone stand with a coiled audio cable.",
            Variants(("silver", "Silver", "#d7d9d9"), ("graphite", "Graphite", "#505356"))),
        new("carry-case", "Carry Case", "Accessories", "Protective headphone case", 1900m,
            "images/products/carry-case.png", "Textured graphite protective headphone case.",
            Variants(("graphite", "Graphite", "#45484a")))
    ]);

    public IReadOnlyList<Product> Products => Catalog;

    public Product? FindById(string productId) =>
        Catalog.FirstOrDefault(product => product.Id.Equals(productId, StringComparison.OrdinalIgnoreCase));

    private static IReadOnlyList<ProductVariant> Variants(params (string Id, string Name, string Hex)[] options) =>
        Array.AsReadOnly(options.Select(option => new ProductVariant(option.Id, option.Name, option.Hex)).ToArray());
}
