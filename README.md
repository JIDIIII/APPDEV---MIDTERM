# FREQUENCY

A curated audio storefront built with C# and Blazor WebAssembly. It includes Home, Shop, and Checkout pages with local product and cart state.

## Requirements

- .NET 10 SDK
- Node.js and npm

## Run locally

From the repository root, enter the app directory, install the CSS build dependencies, build the stylesheet, and start the app:

```sh
cd app/Midterm
npm install
npm run build:css
dotnet run --launch-profile http
```

Keep the server running in that terminal, then open [http://localhost:5053](http://localhost:5053). Stop the server with `Ctrl+C`.

You only need to run `npm install` for the initial setup or after the package dependencies change. `npm run build:css` compiles `Styles/app.css` into `wwwroot/css/tailwind.css` before the app starts.

## Edit styles

For live CSS rebuilding, open a second terminal and run:

```sh
cd app/Midterm
npm run watch:css
```

The watcher stays active while you edit styles. The catalog, cart, and checkout run locally in the browser; no backend or payment processing is configured.

See [the app README](app/Midterm/README.md) for the same commands and more project-specific setup details.
