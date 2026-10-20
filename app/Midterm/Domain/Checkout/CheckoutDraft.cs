using System.ComponentModel.DataAnnotations;

namespace Midterm.Domain.Checkout;

public sealed class CheckoutDraft
{
    [Required(ErrorMessage = "Enter an email address.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Enter your full name.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Enter a name between 2 and 100 characters.")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Enter a phone number.")]
    [RegularExpression(@"^[+0-9 ()-]{8,20}$", ErrorMessage = "Enter a valid phone number.")]
    public string Phone { get; set; } = string.Empty;

    [Required(ErrorMessage = "Enter a street address.")]
    [StringLength(150, MinimumLength = 4, ErrorMessage = "Enter a complete street address.")]
    public string StreetAddress { get; set; } = string.Empty;

    [Required(ErrorMessage = "Enter a city.")]
    public string City { get; set; } = string.Empty;

    [Required(ErrorMessage = "Enter a postal code.")]
    [RegularExpression(@"^\d{4,6}$", ErrorMessage = "Use a 4–6 digit postal code.")]
    public string PostalCode { get; set; } = string.Empty;
}
