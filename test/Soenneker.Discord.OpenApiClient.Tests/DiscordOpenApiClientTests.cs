using Soenneker.Tests.HostedUnit;

namespace Soenneker.Discord.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class DiscordOpenApiClientTests : HostedUnitTest
{
    public DiscordOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
