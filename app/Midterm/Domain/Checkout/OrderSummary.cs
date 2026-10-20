namespace Midterm.Domain.Checkout;

public sealed record OrderSummary(int ItemCount, decimal Subtotal, decimal DeliveryFee)
{
    public decimal Total => Subtotal + DeliveryFee;
}

public sealed record OrderConfirmation(string Reference);
