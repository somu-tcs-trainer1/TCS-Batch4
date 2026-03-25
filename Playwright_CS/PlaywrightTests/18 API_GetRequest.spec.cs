using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

[TestFixture]
public class GetApiTest : PageTest
{
    [Test]
    public async Task GetApiRequestTest()
    {
        var response = await Page.APIRequest.GetAsync("https://jsonplaceholder.typicode.com");
        Assert.That(response.Status, Is.EqualTo(200));

        // 1. Get the JSON array and access index [0]
        var data = await response.JsonAsync();
        var firstUser = data.Value[0]; 

        // 2. Direct property assertions using GetProperty
        Assert.Multiple(() =>
        {
            // Verifying the values directly
            Assert.That(firstUser.GetProperty("id").GetInt32(), Is.Not.Zero);
            Assert.That(firstUser.GetProperty("name").GetString(), Is.EqualTo("Leanne Graham"));
            Assert.That(firstUser.GetProperty("username").GetString(), Is.Not.Null);
        });

        // 3. Header check
        Assert.That(response.Headers["content-type"], Does.Contain("application/json"));
    }
}
