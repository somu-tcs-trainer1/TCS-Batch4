using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class FormFillTest : PageTest
{
    [Test]
    public async Task FillFormTest()
    {
        Console.WriteLine("Executing FormFillTest");

        await Page.GotoAsync("https://testautomationpractice.blogspot.com/");

        await Page.GetByPlaceholder("Enter Name").FillAsync("Sample Name");

        await Page.Locator("#email").FillAsync("sample_email@example.com");

        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Phone" }).FillAsync("1234567890");

        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Address" }).FillAsync("4th Street, First Down, Umbrella Avenue, RajNagar");

        await Page.GetByLabel("Female").CheckAsync();
        await Page.GetByLabel("Tuesday").CheckAsync();
        await Page.GetByLabel("Wednesday").CheckAsync();

        await Page.Locator("#country").SelectOptionAsync("India");

        await Page.WaitForTimeoutAsync(3000);

        // Expect a title "to contain" a substring.
        // await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));
    }

}