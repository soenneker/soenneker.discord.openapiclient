[![](https://img.shields.io/nuget/v/soenneker.discord.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.discord.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.discord.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.discord.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.discord.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.discord.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.discord.openapiclient/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.discord.openapiclient/actions/workflows/codeql.yml)

# Soenneker.Discord.OpenApiClient

A generated .NET client for Discord's HTTP API, covering applications, channels, guilds, interactions, users, webhooks, voice, stickers, and OAuth operations.

## Installation

```bash
dotnet add package Soenneker.Discord.OpenApiClient
```

## Create the client directly

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Discord.OpenApiClient;

using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bot", botToken);

var authentication = new AnonymousAuthenticationProvider();
using var adapter = new HttpClientRequestAdapter(authentication, httpClient: httpClient);
var client = new DiscordOpenApiClient(adapter);

var currentUser = await client.Users.Me.GetAsync(cancellationToken: cancellationToken);
```

The client defaults to `https://discord.com/api/v10`. Use `Bearer` instead of `Bot` when calling an endpoint with an OAuth access token. Never place Discord credentials on an `HttpClient` that can send default headers to unrelated hosts.

Generated request builders mirror Discord's URL hierarchy. Collection items are selected with generated indexers, request bodies and responses use types from `Soenneker.Discord.OpenApiClient.Models`, and endpoint methods accept request-configuration callbacks and cancellation tokens.

For managed transport reuse and configuration, use `Soenneker.Discord.OpenApiClientUtil` with `Soenneker.Discord.HttpClients`.

This repository contains generated source. Keep application-specific behavior in wrapper services or separate partial-class files because regeneration can replace generated files.
