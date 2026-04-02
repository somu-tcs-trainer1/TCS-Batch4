using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;

namespace PlaywrightTests
{
    [TestFixture]
    public class AssertionsTest : PageTest
    {
        [Test]
        public async Task TestAssertions()
        {
            await Page.GotoAsync("https://testautomationpractice.blogspot.com/");
            Console.WriteLine("Page opened successfully");

            // Page assertions
            await Expect(Page).ToHaveTitleAsync("Automation Testing Practice");
            await Expect(Page).ToHaveURLAsync("https://testautomationpractice.blogspot.com/");

            // textbox assertions - to check visibility and if editable
            var nameInput = Page.GetByPlaceholder("Enter Name");
            await Expect(nameInput).ToBeVisibleAsync();
            await Expect(nameInput).ToBeEditableAsync();
            await nameInput.FillAsync("Sample Name");

            // Locators and basic fields
            await Page.Locator("#email").FillAsync("sample_email@example.com");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Phone" }).FillAsync("1234567890");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Address" }).FillAsync("4th Street, First Down, Umbrella Avenue, RajNagar ");

            // Radio button assertion if enabled and checked
            var femaleRadio = Page.GetByLabel("Female");
            await Expect(femaleRadio).ToBeEnabledAsync();
            await femaleRadio.CheckAsync();
            await Expect(femaleRadio).ToBeCheckedAsync();

            // Checkbox assertion if enabled and checked
            var tuesdayCheckbox = Page.GetByLabel("Tuesday");
            await Expect(tuesdayCheckbox).ToBeEnabledAsync();
            await tuesdayCheckbox.CheckAsync();
            await Expect(tuesdayCheckbox).ToBeCheckedAsync();

            // Heading assertions - check for text, element class has specific attribute value
            var header = Page.Locator("//div[@id='header-inner']/div/h1");
            await Expect(header).ToHaveTextAsync("Automation Testing Practice");
            await Expect(header).ToContainTextAsync("Automation Testing Practice");
            await Expect(header).ToHaveClassAsync("title");

            // Assert Text content extract is equal to expected value
            string? headerTxt = await header.TextContentAsync();
            Console.WriteLine($"Header Text value: {headerTxt}");
            Assert.That(headerTxt?.Trim(), Is.EqualTo("Automation Testing Practice"));

            await Task.Delay(3000);
        }
    }
}
