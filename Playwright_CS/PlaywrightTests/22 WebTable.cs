using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace PlaywrightTests
{
    [Parallelizable(ParallelScope.Self)]
    public class TableTests : PageTest
    {
        [Test]
        public async Task WebTableTest()
        {
            await Page.GotoAsync("https://testautomationpractice.blogspot.com/");

            // const table = await page.locator("//table[@name='BookTable']");
            var table = Page.Locator("//table[@name='BookTable']");
            await table.ScrollIntoViewIfNeededAsync();

            // const rows = await page.locator("//table[@name='BookTable']/tbody/tr");
            var rows = Page.Locator("//table[@name='BookTable']/tbody/tr");
            var cols = Page.Locator("//table[@name='BookTable']/tbody/tr[2]/td");

            int rowCount = await rows.CountAsync();
            int colCount = await cols.CountAsync();

            Console.WriteLine($"The number of rows in the Books table: {rowCount}");
            Console.WriteLine($"The number of cols in the Books table: {colCount}");

            // Loop through rows (starting from index 1 to skip header if necessary)
            for (int i = 1; i < rowCount; i++)
            {
                var row = rows.Nth(i);
                var cells = row.Locator("td");
                string result = "";

                for (int j = 0; j < colCount; j++)
                {
                    // const value = await col.nth(j).textContent();
                    var value = await cells.Nth(j).TextContentAsync();
                    result = result + value?.Trim() + " | ";
                }
                Console.WriteLine(result);
            }
        }
    }
}
