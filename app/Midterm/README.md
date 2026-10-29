# FREQUENCY

A curated audio storefront built with C# and Blazor WebAssembly. It includes Home, Shop, and Checkout pages with local product and cart state.

## Requirements

- .NET 10 SDK
- Node.js and npm

## First-time setup

Run these commands from the `app/Midterm` directory:

```sh
npm install
npm run build:css
```

`npm install` installs the Tailwind CSS build tools from `package-lock.json`. The CSS build compiles `Styles/app.css` into `wwwroot/css/tailwind.css`.

## Start the app

From `app/Midterm`, run:

```sh
dotnet run --launch-profile http
```

The `http` launch profile serves the app at [http://localhost:5053](http://localhost:5053). Keep the terminal open while using the app and press `Ctrl+C` to stop the server. The command uses the HTTP profile so local development does not require an HTTPS development certificate.

## Edit styles

To rebuild Tailwind CSS automatically while editing, open a second terminal in `app/Midterm` and run:

```sh
npm run watch:css
```

Stop the watcher with `Ctrl+C`. Re-run `npm run build:css` when you want a one-time CSS build instead.

The catalog, cart, and checkout run locally in the browser. No backend or payment processing is configured.
