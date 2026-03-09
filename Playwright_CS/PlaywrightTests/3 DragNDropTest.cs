using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class DragAndDropTest : PageTest
{
    [Test]
    public async Task DragNDropTest()
    {
        Console.WriteLine("Executing DragNDropTest");
        await Page.GotoAsync("https://jqueryui.com/droppable/");
        await Page.WaitForTimeoutAsync(3000);

        ILocator sourceElement = Page.FrameLocator(".demo-frame").GetByText("Drag me to my target");
        ILocator targetElement = Page.FrameLocator(".demo-frame").GetByText("Drop here");

        await sourceElement.DragToAsync(targetElement);
        await Page.WaitForTimeoutAsync(3000);
    }

    // [Test]
    // public async Task DragNDropTes2()
    // {
    //     Console.WriteLine("Executing DragNDropTest2");
    //     await Page.GotoAsync("https://jqueryui.com/droppable/");
    //     await Page.WaitForTimeoutAsync(3000);

    //     var frameElementHandle = await Page.EvaluateAsync("window.frames[0]");
    //     var frame = frameElementHandle

    //     ILocator sourceElement = frameElement.GetByText("Drag me to my target");
    //     ILocator targetElement = Page.FrameLocator(".demo-frame").GetByText("Drop here");

    //     await sourceElement.DragToAsync(targetElement);
    //     await Page.WaitForTimeoutAsync(3000);
    // }
}