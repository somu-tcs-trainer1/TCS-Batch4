using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightDemo.Tests
{
    // [Parallelizable] allows tests in this class to run in parallel
    [Parallelizable(ParallelScope.Self)]
    // [TestFixture] identifies this class as containing NUnit tests
    [TestFixture]
    public class PlaywrightHookDemo : PageTest
    {
        // 1. ONE-TIME SETUP: Runs once before all tests in this class
        [OneTimeSetUp]
        public void GlobalSetup()
        {
            // Useful for initializing shared reporting or reading global config
            Console.WriteLine("--- Starting Test Suite Execution ---");
        }

        // 2. SETUP: Runs before EACH individual [Test]
        [SetUp]
        public async Task Setup()
        {
            // Use this to perform common actions like logging in
            await Page.GotoAsync("https://demowebshop.tricentis.com/");
            Console.WriteLine($"Pre-test: Navigated to {Page.Url}");
        }

        // 3. STANDARD TEST: Marks a method as an executable test
        [Test]
        [Category("Smoke")] // Group tests for filtered execution
        [Description("Verifies basic page title")] // Adds documentation
        public async Task BasicTitleTest()
        {
            await Expect(Page).ToHaveTitleAsync(new Regex("Demo Web Shop"));
        }

        // 4. DATA-DRIVEN TEST: Runs the same test multiple times with different data
        [TestCase("https://playwright.dev", "Playwright")]
        [TestCase("https://dotnet.microsoft.com", ".NET")]
        public async Task ParameterizedNavigationTest(string url, string expectedTitle)
        {
            await Page.GotoAsync(url);
            await Expect(Page).ToHaveTitleAsync(new Regex (expectedTitle));
        }

        // 5. IGNORED TEST: Skips this test with a provided reason
        [Test]
        [Ignore("Feature currently under maintenance")]
        public async Task SkippedTest()
        {
            // This code will not run
        }

        // 6. RETRY: Automatically reruns the test if it fails (useful for flakiness)
        [Test]
        [Retry(2)]
        public async Task FlakyTestDemo()
        {
            // Will attempt up to 3 times total if assertions fail
            await Expect(Page.Locator("h1")).ToBeVisibleAsync();
        }

        // 7. TEARDOWN: Runs after EACH individual [Test]
        [TearDown]
        public void Cleanup()
        {
            // Useful for logging results or local cleanup
            Console.WriteLine("Post-test: Cleaning up...");
        }

        // 8. ONE-TIME TEARDOWN: Runs once after all tests in this class
        [OneTimeTearDown]
        public void GlobalTeardown()
        {
            Console.WriteLine("--- All Tests Completed ---");
        }
    }
}
