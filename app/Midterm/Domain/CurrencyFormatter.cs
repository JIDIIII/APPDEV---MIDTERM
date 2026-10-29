using System.Globalization;

namespace Midterm.Domain;

public static class CurrencyFormatter
{
    public static string PhilippinePeso(decimal amount) => $"₱{amount.ToString("N0", CultureInfo.InvariantCulture)}";
}
