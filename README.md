# Microsoft Entra External ID BFF security architecture using ASP.NET Core and nx Angular standalone

[![.NET and npm build](https://github.com/damienbod/bff-MicrosoftEntraExternalID-aspnetcore-angular/actions/workflows/dotnet.yml/badge.svg)](https://github.com/damienbod/bff-MicrosoftEntraExternalID-aspnetcore-angular/actions/workflows/dotnet.yml) [![License](https://img.shields.io/badge/license-Apache%20License%202.0-blue.svg)](https://github.com/damienbod/bff-MicrosoftEntraExternalID-aspnetcore-angular/blob/main/LICENSE)

[Secure an Angular application using Microsoft Entra External ID and ASP.NET Core with BFF]([https://damienbod.com](https://damienbod.com/2023/10/24/secure-an-angular-application-using-microsoft-entra-external-id-and-asp-net-core-with-bff/))
## Debugging

Start the Angular project from the **ui** folder

```
nx serve --ssl
```

Start the ASP.NET Core project from the **server** folder

```
dotnet run
```

Or just open Visual Studio and run the solution.

## Credits and used libraries

- NetEscapades.AspNetCore.SecurityHeaders
- Yarp.ReverseProxy
- Microsoft.Identity.Web
- ASP.NET Core
- Angular 
- Nx

## Links

https://learn.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core

https://nx.dev/getting-started/intro

https://github.com/AzureAD/microsoft-identity-web

https://github.com/isolutionsag/aspnet-react-bff-proxy-example

https://learn.microsoft.com/en-us/azure/active-directory/external-identities/

https://www.microsoft.com/en-us/security/business/identity-access/microsoft-entra-external-id

https://developer.microsoft.com/en-us/identity/customers

https://www.cloudpartner.fi/?p=14685

https://techcommunity.microsoft.com/t5/microsoft-entra-azure-ad-blog/microsoft-entra-external-id-public-preview-developer-centric/ba-p/3823766

https://github.com/Azure-Samples/ms-identity-ciam-dotnet-tutorial

https://github.com/damienbod/EntraExternalIdCiam

https://github.com/damienbod/bff-aspnetcore-angular

https://github.com/damienbod/bff-auth0-aspnetcore-angular

https://github.com/damienbod/bff-openiddict-aspnetcore-angular

https://github.com/damienbod/bff-azureadb2c-aspnetcore-angular

https://github.com/damienbod/bff-aspnetcore-vuejs
