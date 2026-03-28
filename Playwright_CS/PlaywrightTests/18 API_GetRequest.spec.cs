// using Microsoft.Playwright.NUnit;
// using NUnit.Framework;
// using System;
// using System.Threading.Tasks;

// [TestFixture]
// public class GetApiTest : PageTest
// {
//     [Test]
//     public async Task GetApiRequestTest()
//     {
//         var response = await Page.APIRequest.GetAsync("https://jsonplaceholder.typicode.com");
//         Assert.That(response.Status, Is.EqualTo(200));

//         // 1. Get the JSON array and access index [0]
//         var data = await response.JsonAsync();
//         var firstUser = data.Value[0]; 

//         // 2. Direct property assertions using GetProperty
//         Assert.Multiple(() =>
//         {
//             // Verifying the values directly
//             Assert.That(firstUser.GetProperty("id").GetInt32(), Is.Not.Zero);
//             Assert.That(firstUser.GetProperty("name").GetString(), Is.EqualTo("Leanne Graham"));
//             Assert.That(firstUser.GetProperty("username").GetString(), Is.Not.Null);
//         });

//         // 3. Header check
//         Assert.That(response.Headers["content-type"], Does.Contain("application/json"));
//     }
// }

using Microsoft.Playwright.NUnit;
using System.Threading.Tasks;
using Microsoft.Playwright;
using NUnit.Framework;

namespace ApiTests
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class JsonPlaceholderApiTests
    {
        private IPlaywright _playwright;
        private IBrowser _browser;

        [SetUp]
        public async Task Setup()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = true
            });
        }

        [TearDown]
        public async Task Teardown()
        {
            await _browser.CloseAsync();
            _playwright.Dispose();
        }

        [Test]
        public async Task GetUsersApi_ShouldReturnValidResponse()
        {
            var context = await _browser.NewContextAsync();
            var request = context.APIRequest;

            // Send GET request
            var response = await request.GetAsync("https://jsonplaceholder.typicode.com/users");

            // Status check
            Assert.That(response.Status, Is.EqualTo(200), "Status code should be 200");
            Assert.That(response.Ok, Is.True, "Response should be successful");

            // Parse JSON
            var json = await response.JsonAsync();

            // Validate properties of first user
            var firstUser = json.Value[0];
            Assert.That(firstUser.TryGetProperty("id", out _), Is.True);
            Assert.That(firstUser.TryGetProperty("name", out _), Is.True);
            Assert.That(firstUser.TryGetProperty("username", out _), Is.True);

            Assert.That(firstUser.GetProperty("name").GetString(), Is.EqualTo("Leanne Graham"));

            // Validate headers
            var headers = response.Headers;
            Console.WriteLine(headers["content-type"]);
            Assert.That(headers["content-type"], Does.Contain("application/json"));
        }
    }
}