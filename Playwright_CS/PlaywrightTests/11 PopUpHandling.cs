using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;

[TestFixture]
public class DialogTests : PageTest
{
    [Test]
    public async Task HandlingPopUpWithAccept()
    {
        await Page.GotoAsync("https://testautomationpractice.blogspot.com/");
        System.Console.WriteLine("Page opened successfully");
        await Task.Delay(2000);

        await Page.GetByText("Confirmation Alert").ScrollIntoViewIfNeededAsync();

        // Register the event handler
        Page.Dialog += async (_, dialog) =>
        {
            await Task.Delay(2000);
            System.Console.WriteLine($"The message inside the dialog box is: {dialog.Message}");
            await dialog.AcceptAsync();
        };

        await Page.GetByText("Confirmation Alert").ClickAsync();

        await Task.Delay(2000);
        await Page.Locator("//button[@name='start']").ClickAsync();
        await Task.Delay(3000);
    }

    [Test]
    public async Task HandlingPopUpWithDismiss()
    {
        await Page.GotoAsync("https://testautomationpractice.blogspot.com/");
        System.Console.WriteLine("Page opened successfully");
        await Task.Delay(2000);

        await Page.GetByText("Confirmation Alert").ScrollIntoViewIfNeededAsync();

        Page.Dialog += async (_, dialog) =>
        {
            await Task.Delay(2000);
            System.Console.WriteLine($"The message inside the dialog box is: {dialog.Message}");
            await dialog.DismissAsync();
        };

        await Page.GetByText("Confirmation Alert").ClickAsync();

        await Task.Delay(2000);
        await Page.Locator("//button[@name='start']").ClickAsync();
        await Task.Delay(3000);
    }

    [Test]
    public async Task HandlingPopUpWithPrompt()
    {
        await Page.GotoAsync("https://testautomationpractice.blogspot.com/");
        System.Console.WriteLine("Page opened successfully");
        await Task.Delay(2000);

        await Page.GetByText("Prompt Alert").ScrollIntoViewIfNeededAsync();

        // Using a local function to handle the dialog once
        async void HandlePrompt(object sender, IDialog dialog)
        {
            await Task.Delay(2000);
            if (dialog.Type == "prompt")
            {
                System.Console.WriteLine($"Dialog message: {dialog.Message}");
                await dialog.AcceptAsync("UserName");
            }
            else
            {
                await dialog.AcceptAsync();
            }
            // Unsubscribe to mimic JS 'once'
            Page.Dialog -= HandlePrompt!;
        }

        Page.Dialog += HandlePrompt!;

        await Page.GetByText("Prompt Alert").ClickAsync();
        await Task.Delay(2000);
        await Page.Locator("//button[@name='start']").ClickAsync();
        await Task.Delay(3000);
    }
}
