using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace PlaywrightTests
{
    [Parallelizable(ParallelScope.Self)]
    public class StyleTests : PageTest
    {
        [Test]
        public async Task GetCssPropertyTest()
        {
            // await page.goto("https://demowebshop.tricentis.com/");
            await Page.GotoAsync("https://demowebshop.tricentis.com/");
            Console.WriteLine("Page opened successfully");

            // const registerLink = await page.locator("//a[@href='/register']")
            var registerLink = Page.Locator("//a[@href='/register']");

            /* 
               const txtColor = await registerLink.evaluate((ev) => {
                   return window.getComputedStyle(ev).getPropertyValue('background-color');
               })
            */
            var bgColor = await registerLink.EvaluateAsync<string>("ev => window.getComputedStyle(ev).getPropertyValue('background-color')");

            Console.WriteLine($"The background-color of the registerLink on the page is: {bgColor}");
            
            await Page.WaitForTimeoutAsync(2000);
        }
    }
}
