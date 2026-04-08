using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;
using Allure.NUnit;

namespace PlaywrightTests
{
    [AllureNUnit]
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class RunSettingsTest : PageTest
    {
        private string? _baseUrl;
        private bool? _takeScreenshot;

    public override BrowserNewContextOptions ContextOptions()
        {
            return new BrowserNewContextOptions
            {
                // This disables the default 1280x720 viewport
                // so the page fills the maximized browser window.
                ViewportSize = ViewportSize.NoViewport 
            };
        }

        [SetUp]
        public void Setup()
        {
            // 1. Fetching Custom Parameters
            // _baseUrl = TestContext.Parameters["BaseUrl"] ?? "https://localhost:5000";
            _baseUrl = TestContext.Parameters["BaseUrl"];
            _takeScreenshot = bool.Parse(TestContext.Parameters["TakeScreenshotOnFailure"] ?? "false");

            // 2. Using Parameters for Logic
            var timeout = float.Parse(TestContext.Parameters["Timeout"] ?? "30000");
            Page.SetDefaultTimeout(timeout);
        }

        [Test]
        public async Task TestGlobalVars()
        {
            String? baseUrlPageTitle = TestContext.Parameters["PageTitle"];
            String? name = TestContext.Parameters["Name"];
            String? email = TestContext.Parameters["Email"];
            String? phone = TestContext.Parameters["Phone"];

            Console.WriteLine("BaseUrl from the local.runsettings file is: " + _baseUrl);
            Console.WriteLine("PageTitle from the .env file is: " + baseUrlPageTitle);
            Console.WriteLine("Name from the .env file is: " + name);
            Console.WriteLine("Email from the .env file is: " + email);
            Console.WriteLine("Phone from the .env file is: " + phone);

            await Page.GotoAsync(_baseUrl!);
            Console.WriteLine("Page opened successfully");

            // Page assertions
            await Expect(Page).ToHaveTitleAsync(baseUrlPageTitle!);
            await Expect(Page).ToHaveURLAsync(_baseUrl!);

            await Page.GetByPlaceholder("Enter Name").FillAsync(name!);
            await Page.Locator("#email").FillAsync(email!);
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Phone" }).FillAsync(phone!);

            await Task.Delay(3000);
        }

        [TearDown]
        public async Task Teardown()
        {
            // 4. Conditional Teardown Logic
            if (TestContext.CurrentContext.Result.Outcome.Status == (NUnit.Framework.Interfaces.TestStatus.Failed) && (_takeScreenshot ?? false))
            {
                await Page.ScreenshotAsync(new() { Path = "DownloadedFiles/failure_screenshot1.png" });
            }
        }

    }
}
