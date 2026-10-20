namespace Midterm.Domain.Checkout;

public abstract record DeliveryOption(string Id, string Name, string Description)
{
    public abstract decimal Fee { get; }
}

public sealed record StandardDeliveryOption()
    : DeliveryOption("standard", "Standard delivery", "Delivered in 3–5 business days")
{
    public override decimal Fee => 150m;
}

public sealed record StudioPickupOption()
    : DeliveryOption("pickup", "Makati studio pickup", "Ready in 1–2 days")
{
    public override decimal Fee => 0m;
}
