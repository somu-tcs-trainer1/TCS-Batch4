using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace PlaywrightTests
{
    [Parallelizable(ParallelScope.Self)]
    public class NavigationTests : PageTest
    {
        [Test]
        public async Task NavigationCommandsTest()
        {
            // await page.goto("https://demowebshop.tricentis.com/");
            await Page.GotoAsync("https://demowebshop.tricentis.com/");
            Console.WriteLine("Page opened successfully");

            // await page.locator("//a[@href='/register']").click();
            await Page.Locator("//a[@href='/register']").ClickAsync();
            await Page.WaitForTimeoutAsync(2000);

            // await page.goBack();
            await Page.GoBackAsync();
            await Page.WaitForTimeoutAsync(2000);

            // await page.goForward();
            await Page.GoForwardAsync();
            await Page.WaitForTimeoutAsync(2000);

            // await page.reload();
            await Page.ReloadAsync();
            await Page.WaitForTimeoutAsync(3000);
        }
    }
}
