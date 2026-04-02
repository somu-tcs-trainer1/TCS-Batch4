using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;

namespace PlaywrightTests
{
    [TestFixture]
    public class RetriesTest : PageTest
    {
        // [Test]
        // [Retry(3)] // Retries up to 3 times if it fails
        // public async Task FlakyTest()
        // {
        //     await Page.GotoAsync("https://testautomationpractice.blogspot.com/");
        //     await Expect(Page).ToHaveTitleAsync("Automation Testing Practice1");
        // }

        [Test]
        [Retry(3)]
        public async Task FlakyTest()
        {
            try
            {
                await Page.GotoAsync("https://testautomationpractice.blogspot.com/");
                await Expect(Page).ToHaveTitleAsync("Automation Testing Practice1");
            }
            catch (Exception ex)
            {
                // Force NUnit to see this as a Failure so it triggers the [Retry]
                Assert.Fail($"Test failed with exception: {ex.Message}");
            }
        }

    }
}