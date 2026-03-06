using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class ExampleTest2 : PageTest
{
    [SetUp]
    public async Task BeforeMyTest()
    {
        Console.WriteLine("Before Test");
    }

    [Test]
    public async Task HasTitle2()
    {
        Console.WriteLine("Executing HasTitle2 Test");
        await Page.GotoAsync("https://playwright.dev");

        // Expect a title "to contain" a substring.
        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));
    }

    [Test]
    public async Task GetStartedLink2()
    {
        Console.WriteLine("Executing GetStartedLink2 Test");
        await Page.GotoAsync("https://playwright.dev");

        // Click the get started link.
        await Page.GetByRole(AriaRole.Link, new() { Name = "Get started" }).ClickAsync();

        // Expects page to have a heading with the name of Installation.
        await Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "Installation" })).ToBeVisibleAsync();
    } 

    [TearDown]
    public async Task AfterMyTest()
    {
        Console.WriteLine("After Test");
    }

}