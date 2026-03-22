using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Discord.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class DiscordOpenApiClientTests : FixturedUnitTest
{
    public DiscordOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
