using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using NUnit.Framework.Internal;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class PageObjectFormFillTest : PageTest
{
    internal AutomationSitePage? formFillPOMPage;
    [Test]
    public async Task FillFormTest()
    {
        formFillPOMPage = new AutomationSitePage(Page);
        Console.WriteLine("Executing FormFillTest");
        await formFillPOMPage.Launch();
        await formFillPOMPage.FillBasicForm("Raju", "Raj234@email.com", "1111222233");
        await Page.WaitForTimeoutAsync(3000);
    }
}