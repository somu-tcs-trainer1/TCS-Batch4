using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class DragElementTest : PageTest
{
    [Test]
    public async Task DragAnElementTest()
    {
        Console.WriteLine("Executing DragNDropTest");
        await Page.GotoAsync("https://jqueryui.com/draggable/");
        await Page.WaitForTimeoutAsync(3000);

        ILocator sourceElement = Page.FrameLocator(".demo-frame").GetByText("Drag me around");

        await sourceElement.DragToAsync(sourceElement, new()
            {
                TargetPosition = new() { X = -50, Y = 120 },
                Force = true
            });
        await Page.WaitForTimeoutAsync(3000);
    }
}