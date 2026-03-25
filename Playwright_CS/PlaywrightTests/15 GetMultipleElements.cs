using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace PlaywrightTests
{
    [Parallelizable(ParallelScope.Self)]
    public class LinkTests : PageTest
    {
        [Test]
        public async Task GetAllLinksTest()
        {
            await Page.GotoAsync("https://demowebshop.tricentis.com/");
            Console.WriteLine("Page opened successfully");

            // const links = await page.getByRole("link").all();
            var links = await Page.GetByRole(AriaRole.Link).AllAsync();
            
            // console.log("The number of links on this page are: ", links.length);
            Console.WriteLine($"The number of links on this page are: {links.Count}");
            
            await Page.WaitForTimeoutAsync(3000);

            Console.WriteLine("List of all links in the page: ");
            
            // for(const link of links)
            foreach (var link in links)
            {
                // await link.getAttribute("href")
                var href = await link.GetAttributeAsync("href");
                Console.WriteLine(href);
                
                /* Uncomment if you need text content
                var text = await link.TextContentAsync();
                if (!string.IsNullOrEmpty(text))
                {
                    Console.WriteLine(text.Trim());
                }
                */
            }
        }
    }
}
