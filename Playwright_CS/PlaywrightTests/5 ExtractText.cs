using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class ExtractTextTest : PageTest
{
    [Test]
    public async Task TextExtractTest()
    {
        Console.WriteLine("Executing TextExtractTest");
        await Page.GotoAsync("https://playwright.dev/");
        await Page.WaitForTimeoutAsync(3000);

        ILocator element = Page.Locator("//div[@id='__docusaurus_skipToContent_fallback']/main/section[1]/div[1]/div/div[1]/h3");
        string innertext = await element.InnerTextAsync();
        Console.WriteLine("The text of the element using INNERTEXT :"+innertext);
        
        string? textcontent = await element.TextContentAsync();
        Console.WriteLine("The text of the element using TEXTCONTENT :"+textcontent);

        await Page.WaitForTimeoutAsync(3000);
    }

}