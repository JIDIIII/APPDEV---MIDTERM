using Midterm.Domain.Checkout;
using Midterm.Features.Cart;

namespace Midterm.Features.Checkout;

public sealed class CheckoutService : ICheckoutService
{
    private static readonly IReadOnlyList<DeliveryOption> Options = Array.AsReadOnly<DeliveryOption>(
    [new StandardDeliveryOption(), new StudioPickupOption()]);

    public IReadOnlyList<DeliveryOption> DeliveryOptions => Options;

    public OrderSummary CreateSummary(ICartService cart, DeliveryOption delivery) =>
        new(cart.ItemCount, cart.Subtotal, delivery.Fee);

    public OrderConfirmation CreateConfirmation() =>
        new($"FRQ-{Guid.NewGuid():N}"[..12].ToUpperInvariant());
}
