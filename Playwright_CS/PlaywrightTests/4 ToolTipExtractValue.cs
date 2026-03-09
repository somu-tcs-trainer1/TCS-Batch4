using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class ToolTipAndExtractValueTest : PageTest
{
    [Test]
    public async Task ToolTipTest()
    {
        Console.WriteLine("Executing DragNDropTest");
        await Page.GotoAsync("https://parabank.parasoft.com/parabank/index.htm");
        await Page.WaitForTimeoutAsync(3000);

        ILocator element = Page.Locator("//img[@alt='ParaBank']");
        await element.HoverAsync();
        await Page.WaitForTimeoutAsync(2000);
        await Expect(element).ToHaveAttributeAsync("title", "ParaBank");

        await Page.WaitForTimeoutAsync(3000);
    }

    [Test]
    public async Task ExtractValueAttributeTest()
    {
        Console.WriteLine("Executing DragNDropTest");
        await Page.GotoAsync("https://www.bing.com/");
        await Page.WaitForTimeoutAsync(3000);

        ILocator element = Page.Locator("#sb_form_q");

        string txtToEnter = "mango";
        await element.FillAsync(txtToEnter);
        await element.PressAsync("Tab");
        await Page.WaitForTimeoutAsync(2000);

        Task<string> valueFromElement = element.GetAttributeAsync("value");
        string txtvalueFromElement = valueFromElement.Result;
        Console.WriteLine("The value attribute text extracted: "+valueFromElement.Result);
        //Assert.Equals(txtToEnter, valueFromElement);
        Assert.That(txtvalueFromElement, Is.EqualTo(txtToEnter));
        await Expect(element).ToHaveAttributeAsync("value", txtToEnter);

        Console.WriteLine("the text entered into the search and value attribute extracted are same");
        await Page.WaitForTimeoutAsync(3000);
    }    
}