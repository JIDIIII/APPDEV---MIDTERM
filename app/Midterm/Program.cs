using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Midterm.Components;
using Midterm.Features.Cart;
using Midterm.Features.Catalog;
using Midterm.Features.Checkout;
using Midterm.Infrastructure.MockData;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<IProductCatalog, MockProductCatalog>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<ICheckoutService, CheckoutService>();

await builder.Build().RunAsync();
