// using Microsoft.Playwright.NUnit;
// using NUnit.Framework;
// using System;
// using System.Threading.Tasks;

// namespace PlaywrightTests
// {
//     [Parallelizable(ParallelScope.Self)]
//     // 1. Ensure you inherit from PageTest (capital P and T)
//     public class DeleteApiTest : PageTest 
//     {
//         [Test]
//         public async Task DeleteApiRequestTest()
//         {
//             var response = await Page.APIRequest.DeleteAsync("https://jsonplaceholder.typicode.com");
//             Console.WriteLine($"Response Status: {response.Status}");

//             // 3. Playwright assertions also use the capital 'Expect'
//             await Expect(response).ToBeOKAsync();
//             // Classic NUnit assertion
//             Assert.That(response.Status, Is.EqualTo(200));

//             // Or using the StatusText if you want to verify the message
//             Assert.That(response.StatusText, Is.EqualTo("OK"));
//         }
//     }
// }


using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Threading.Tasks;

namespace PlaywrightApiTests
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class ApiTests : PageTest
    {
        private IAPIRequestContext Request = null!;
        private const string BaseUrl = "https://jsonplaceholder.typicode.com"; // Replace with your API base URL

        [SetUp]
        public async Task SetUpApiTesting()
        {
            // Create a new API request context for the test
            Request = await Playwright.APIRequest.NewContextAsync(new()
            {
                BaseURL = BaseUrl
            });
        }

        [TearDown]
        public async Task TearDownApiTesting()
        {
            // Dispose the API request context after the test
            await Request.DisposeAsync();
        }

        [Test]
        public async Task ShouldReturnUser()
        {
            // Perform a GET request to a specific endpoint
            var response = await Request.GetAsync("users");

            // Assert the status code is 200 OK
            await Expect(response).ToBeOKAsync();
            // Classic NUnit assertion
            Assert.That(response.Status, Is.EqualTo(200));
            // Or using the StatusText if you want to verify the message
            Assert.That(response.StatusText, Is.EqualTo("OK"));
            var responseTxt = response.TextAsync().Result;
            Console.WriteLine(responseTxt);

            // Deserialize the response to a C# object (optional, for detailed validation)
            // var user = await response.JsonAsync<User>();

            // // Assert specific data in the response body
            // ClassicAssert.AreEqual("John Doe", user?.Name);
            // ClassicAssert.AreEqual("john.doe@example.com", user?.Email);
        }
    }
    
    // Define a simple class to match the expected JSON structure
    public class User
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
