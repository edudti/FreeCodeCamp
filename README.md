# FreeCodeCamp Minimal API Example

This repository contains a minimal ASP.NET Core API that demonstrates JWT token generation.

## Running

Make sure you have the .NET 6 SDK installed. To run the API:

```bash
cd MinimalJwtApi
dotnet run
```

The API exposes a `/token` endpoint that accepts a JSON body with a `username` and returns a JWT.

## Testing

Run the unit tests with:

```bash
dotnet test
```

## WinForms client

The `JwtClientApp` project is a simple UI built with DevExpress controls that
demonstrates how to request a token from the API. Make sure the API is running
and then start the client:

```bash
cd JwtClientApp
dotnet run
```

Enter a username and click **Obtener** to retrieve the token. Use **Limpiar** to
clear the fields.
