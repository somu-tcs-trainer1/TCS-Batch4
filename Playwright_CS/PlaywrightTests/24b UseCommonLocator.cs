using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using PlaywrightTests.Pages; // Ensure this matches your RegisterPage namespace
using System.Threading.Tasks;

namespace PlaywrightTests
{
    [TestFixture]
    public class CommonLocator_RegisterTest : PageTest
    {
        [Test]
        public async Task RegisterANewUserUsingCommonLocator()
        {
            // Initialize the Page Object
            var registerPage = new RegisterPage(Page);

            // Navigate to the URL
            await Page.GotoAsync("https://demowebshop.tricentis.com/register");
            Console.WriteLine("Page opened successfully");

            // Use the Page Object methods
            await registerPage.FillRegisterForm("fnameUser4", "male");
            
            // Print multiple common locator (using the params object[] logic)
            registerPage.PrintMultipleCommonLocator();

            // Wait for 3 seconds (similar to waitForTimeout)
            await Task.Delay(3000);
        }
    }
}