using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace PlaywrightTests
{
    [Parallelizable(ParallelScope.Self)]
    // 1. Ensure you inherit from PageTest (capital P and T)
    public class DeleteApiTest : PageTest 
    {
        [Test]
        public async Task DeleteApiRequestTest()
        {
            var response = await Page.APIRequest.DeleteAsync("https://jsonplaceholder.typicode.com");
            Console.WriteLine($"Response Status: {response.Status}");

            // 3. Playwright assertions also use the capital 'Expect'
            await Expect(response).ToBeOKAsync();
            // Classic NUnit assertion
            Assert.That(response.Status, Is.EqualTo(200));

            // Or using the StatusText if you want to verify the message
            Assert.That(response.StatusText, Is.EqualTo("OK"));
        }
    }
}
