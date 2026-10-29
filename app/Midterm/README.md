# FREQUENCY

A curated audio storefront built with C# and Blazor WebAssembly. It includes Home, Shop, and Checkout pages with local product and cart state.

## Requirements

- .NET 10 SDK
- Node.js and npm

## Run locally

From this directory, run:

```sh
npm install
npm run build:css
dotnet run --launch-profile http
```

Then open [http://localhost:5053](http://localhost:5053).

For live Tailwind CSS rebuilding while editing styles, run `npm run watch:css` in a second terminal.

The catalog, cart, and checkout run locally in the browser. No backend or payment processing is configured.
