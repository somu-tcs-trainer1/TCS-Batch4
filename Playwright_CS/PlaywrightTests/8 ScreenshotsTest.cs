using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class ScreenshotsTest : PageTest
{
    [Test]
    public async Task ScreenshotTest()
    {
        Console.WriteLine("Executing FormFillTest");
        await Page.GotoAsync("https://parabank.parasoft.com/parabank/index.htm");

        string filepath = "C:\\Users\\Lenovo\\OneDrive\\Desktop\\Class Programs\\Playwright_CS\\PlaywrightTests\\DownloadedFiles\\";
        await Page.ScreenshotAsync(new() { Path = filepath + "VisiblePageScreenshot.png"});
        await Page.ScreenshotAsync(new() { Path = filepath + "fullPageScreenshot.png", FullPage = true});

        ILocator element = Page.Locator("//div[@id='headerPanel']/ul[2]/li[1]/a");

        await element.ScreenshotAsync(new() { Path = filepath  + "elementScrshot.png"});
        await Page.WaitForTimeoutAsync(3000);

    }
}