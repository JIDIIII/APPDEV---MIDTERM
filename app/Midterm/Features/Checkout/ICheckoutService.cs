using Midterm.Domain.Checkout;
using Midterm.Features.Cart;

namespace Midterm.Features.Checkout;

public interface ICheckoutService
{
    IReadOnlyList<DeliveryOption> DeliveryOptions { get; }
    OrderSummary CreateSummary(ICartService cart, DeliveryOption delivery);
    OrderConfirmation CreateConfirmation();
}
