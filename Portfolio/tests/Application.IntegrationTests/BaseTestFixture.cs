using NUnit.Framework;

using static Portfolio.Application.IntegrationTests.Testing;

namespace Portfolio.Application.IntegrationTests;
[TestFixture]
public abstract class BaseTestFixture
{
    [SetUp]
    public async Task TestSetUp()
    {
        await ResetState();
    }
}
