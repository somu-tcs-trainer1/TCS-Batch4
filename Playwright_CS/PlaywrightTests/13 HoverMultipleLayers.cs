using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace PlaywrightTests
{
    [Parallelizable(ParallelScope.Self)]
    public class HoverTests : PageTest
    {
        [Test]
        public async Task HoverMultipleLayersTest()
        {
            // page.goto("https://tgsouthernpower.org");
            await Page.GotoAsync("https://tgsouthernpower.org");
            Console.WriteLine("Page opened successfully");

            // const mainElement = page.getByRole("link", { name: 'Renewable Energy '});
            var mainElement = Page.GetByRole(AriaRole.Link, new() { Name = "Renewable Energy " });
            
            // await mainElement.waitFor({state: 'visible'});
            await mainElement.WaitForAsync(new LocatorWaitForOptions { State = WaitForSelectorState.Visible });
            
            await mainElement.HoverAsync();
            await Page.WaitForTimeoutAsync(2000);

            // await page.getByRole("link", { name: 'Solar Rooftop Netmetering'}).hover();
            await Page.GetByRole(AriaRole.Link, new() { Name = "Solar Rooftop Netmetering" }).HoverAsync();
            await Page.WaitForTimeoutAsync(2000);

            // const lastLink = page.getByRole("link", { name: 'Solar Rooftop Net Metering Guidelines'});
            var lastLink = Page.GetByRole(AriaRole.Link, new() { Name = "Solar Rooftop Net Metering Guidelines" });
            
            await lastLink.HoverAsync();
            await Page.WaitForTimeoutAsync(2000);
            
            await lastLink.ClickAsync();

            await Page.WaitForTimeoutAsync(5000);
        }
    }
}
