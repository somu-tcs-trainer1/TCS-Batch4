using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;

namespace PlaywrightTests
{
    [TestFixture]
    public class DatePickerTest : PageTest
    {
        [Test]
        public async Task FillDatesInForm()
        {
            await Page.GotoAsync("https://testautomationpractice.blogspot.com/");
            Console.WriteLine("Page opened successfully");

            // 1. Date Picker (Standard Input)
            var datePicker = Page.Locator("//input[@id='datepicker']");
            await datePicker.ScrollIntoViewIfNeededAsync();
            
            // Fill and verify
            await datePicker.FillAsync("27/03/2026");
            await Expect(datePicker).ToHaveValueAsync("27/03/2026");
            
            await datePicker.ClickAsync();
            await Task.Delay(3000); // Wait to see the calendar popup

            // 2. Start Date (HTML5 Date Input)
            var startDate = Page.Locator("//input[@id='start-date']");
            await startDate.ScrollIntoViewIfNeededAsync();
            
            // Using PressSequentially to mimic typing (often needed for date masks)
            await startDate.PressSequentiallyAsync("27032026");
            
            // Assertion: HTML5 date inputs store values in YYYY-MM-DD format internally
            await Expect(startDate).ToHaveValueAsync("2026-03-27");
            // await Expect(startDate).ToHaveValueAsync("27-03-2026");

            // 3. End Date
            var endDate = Page.Locator("//input[@id='end-date']");
            await endDate.PressSequentiallyAsync("28032026");
            
            // Assertion
            await Expect(endDate).ToHaveValueAsync("2026-03-28");
            // await Expect(endDate).ToHaveValueAsync("28-03-2026");

            await Page.WaitForTimeoutAsync(3000);
            //await Task.Delay(3000);
        }
    }
}
