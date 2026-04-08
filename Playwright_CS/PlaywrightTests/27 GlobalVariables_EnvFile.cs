using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;
using dotenv.net;

namespace PlaywrightTests
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class GlobalVarTest : PageTest
    {
        [OneTimeSetUp]
        public void GlobalSetup()
        {
            // Load .env variables into System.Environment
            DotEnv.Load();
        }

        [Test]
        public async Task TestGlobalVars()
        {
            String? baseUrl = Environment.GetEnvironmentVariable("BASE_URL");
            String? baseUrlPageTitle = Environment.GetEnvironmentVariable("BASE_URL_PAGE_TITLE");
            String? name = Environment.GetEnvironmentVariable("NAME");
            String? email = Environment.GetEnvironmentVariable("EMAIL");
            String? phone = Environment.GetEnvironmentVariable("PHONE");

            Console.WriteLine("BASE_URL from the .env file is: "+baseUrl);
            Console.WriteLine("BASE_URL_PAGE_TITLE from the .env file is: "+baseUrlPageTitle);
            Console.WriteLine("NAME from the .env file is: "+name);
            Console.WriteLine("EMAIL from the .env file is: "+email);
            Console.WriteLine("PHONE from the .env file is: "+phone);

            await Page.GotoAsync(baseUrl!);
            Console.WriteLine("Page opened successfully");

            // Page assertions
            await Expect(Page).ToHaveTitleAsync(baseUrlPageTitle!);
            await Expect(Page).ToHaveURLAsync(baseUrl!);

            await Page.GetByPlaceholder("Enter Name").FillAsync(name!);
            await Page.Locator("#email").FillAsync(email!);
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Phone" }).FillAsync(phone!);

            await Task.Delay(3000);
        }
    }
}
