using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using Newtonsoft.Json;
using NUnit.Framework.Internal;
using CsvHelper;
using System.Globalization;

namespace PlaywrightTests
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class ParamterizingTest : PageTest
    {
        [Test]
        public async Task ParamertizeJsonData()
        {
            Console.WriteLine("Executing ParamertizeJsonData");
            await Page.GotoAsync("https://testautomationpractice.blogspot.com/");

            ILocator Name = Page.GetByPlaceholder("Enter Name");
            ILocator Email = Page.Locator("#email");
            ILocator Phone = Page.GetByRole(AriaRole.Textbox, new() { Name = "Phone" });

            string folderPath = "C:\\Users\\Lenovo\\OneDrive\\Desktop\\Class Programs\\Playwright_CS\\PlaywrightTests\\";
            //Read the json file content into a string
            // string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "testdata.json");
            string jsonFilePath = Path.Combine(folderPath, "testdata.json");
            string jsonContent = File.ReadAllText(jsonFilePath);

            // List<TestDataItem>? testData =JsonConvert.DeserializeObject<List<TestDataItem>>(jsonContent);
            dynamic? testData = JsonConvert.DeserializeObject(jsonContent)!;

            //Console.WriteLine(testData);
            // Console.WriteLine(testData[0].name);

            foreach (var dataItem in testData)
            {
                // Console.WriteLine(dataItem.name);
                await Name.ClearAsync();
                await Name.FillAsync(dataItem.name.ToString());
                await Email.ClearAsync();
                await Email.FillAsync(dataItem.email.ToString());
                await Phone.ClearAsync();
                await Phone.FillAsync(dataItem.phone.ToString());
                await Page.WaitForTimeoutAsync(3000);
            }
        }

        [Test]
        public async Task ParamertizeCsvData()
        {
            Console.WriteLine("Executing ParamertizeCsvData");
            await Page.GotoAsync("https://testautomationpractice.blogspot.com/");

            ILocator Name = Page.GetByPlaceholder("Enter Name");
            ILocator Email = Page.Locator("#email");
            ILocator Phone = Page.GetByRole(AriaRole.Textbox, new() { Name = "Phone" });

            string folderPath = "C:\\Users\\Lenovo\\OneDrive\\Desktop\\Class Programs\\Playwright_CS\\PlaywrightTests\\";
            string csvFilePath = Path.Combine(folderPath, "TestData.csv");

            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<TestDataItem>().ToList()!;

                foreach (var record in records)
                {
                    await Name.ClearAsync();
                    await Name.FillAsync(record.Name!);
                    await Email.ClearAsync();
                    await Email.FillAsync(record.Email!);
                    await Phone.ClearAsync();
                    await Phone.FillAsync(record.Phone!);
                    await Page.WaitForTimeoutAsync(3000);
                }
            }
        }
    }

    public class TestDataItem
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}