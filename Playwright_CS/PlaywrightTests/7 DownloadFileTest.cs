using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class DownloadFileTest : PageTest
{
    [Test]
    public async Task FileDownloadTest()
    {
        Console.WriteLine("Executing FileDownloadTest");
        await Page.GotoAsync("https://www.microsoft.com/en-in/microsoft-teams/download-app");

        ILocator downloadElement = Page.GetByRole(AriaRole.Link, new() {Name = "Download Microsoft Teams for Windows"});

        // Start the task of waiting for the download before clicking
        var waitForDownloadTask = Page.WaitForDownloadAsync();
        await downloadElement.ClickAsync();
        var download = await waitForDownloadTask;

        // Wait for the download process to complete and save the downloaded file somewhere
        await download.SaveAsAsync("C:\\Users\\Lenovo\\OneDrive\\Desktop\\Class Programs\\Playwright_CS\\PlaywrightTests\\DownloadedFiles\\" + download.SuggestedFilename);

        await Page.WaitForTimeoutAsync(3000);

    }
}