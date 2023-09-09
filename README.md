# Microsoft Entra External ID BFF security architecture using ASP.NET Core and nx Angular standalone

[![.NET and npm build](https://github.com/damienbod/bff-MicrosoftEntraExternalID-aspnetcore-angular/actions/workflows/dotnet.yml/badge.svg)](https://github.com/damienbod/bff-MicrosoftEntraExternalID-aspnetcore-angular/actions/workflows/dotnet.yml) [![License](https://img.shields.io/badge/license-Apache%20License%202.0-blue.svg)](https://github.com/damienbod/bff-MicrosoftEntraExternalID-aspnetcore-angular/blob/main/LICENSE)

## Setup Angular nx

Add the certificates to the nx project for example in the **/certs** folder

Update the nx project.json file:

```json
"serve": {
    "executor": "@angular-devkit/build-angular:dev-server",
    "options": {
    "browserTarget": "ui:build",
    "sslKey": "certs/dev_localhost.key",
    "sslCert": "certs/dev_localhost.pem",
    "port": 4201
},
```

> [!NOTE]  
> The default Angular setup uses port 4200, this needs to match the YARP reverse proxy settings for development.

Update the outputPath for the (nx build) to deploy the production paths to the wwwroot of the .NET project

```
 "build": {
      "executor": "@angular-devkit/build-angular:browser",
      "outputs": ["{options.outputPath}"],
      "options": {
        "outputPath": "../server/wwwroot",
        "index": "./src/index.html",
        "main": "./src/main.ts",
        "polyfills": ["zone.js"],
        "tsConfig": "./tsconfig.app.json",
        "assets": ["./src/favicon.ico", "./src/assets"],
        "styles": ["./src/styles.scss"],
        "scripts": []
      },
```

> [!NOTE]  
> When creating a new Angular nx project, it adds git files as well, delete these as this is not required.

## Setup development

The development environment is setup to use the defualt tools for each of the tech stacks. Angular nx is used like recommended. I use Visual Studio code. A YARP reverse proxy is used to integrate the Angular development into the backend application.

![BFF development](https://github.com/damienbod/bff-aspnetcore-angular/blob/main/images/bff-arch-development_01.png)

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