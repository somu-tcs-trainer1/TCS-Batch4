using NPOI.SS.UserModel;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Globalization;

public class ExcelReader
{
    public static List<Dictionary<string, string>> ReadData(string filePath, string sheetName)
    {
        var dataList = new List<Dictionary<string, string>>();

        using(FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            IWorkbook workbook = WorkbookFactory.Create(fs);
            ISheet sheet = workbook.GetSheet(sheetName);

            IRow headerRow = sheet.GetRow(0);
            int cellCount = headerRow.LastCellNum;

            for(int i=sheet.FirstRowNum+1; i<=sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);
                if(row == null) continue;

                var rowData = new Dictionary<string, string>();
                for(int j=0; j<cellCount; j++)
                {
                    string? key = headerRow.GetCell(j).ToString();
                    string? value = row.GetCell(j).ToString();
                    rowData[key!] = value!;
                }
                dataList.Add(rowData);
            }
        }
        return dataList; 
    }
}

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class ParamterizingTest : PageTest
{
    [Test]
    public async Task ParamertizeExcelData()
    {
        string filePath = "C:\\Users\\Lenovo\\OneDrive\\Desktop\\Class Programs\\Playwright_CS\\PlaywrightTests\\ExcelTestData.xlsx";
        var testData = ExcelReader.ReadData(filePath, "TestData");

        Console.WriteLine("Executing ParamertizeJsonData");
        await Page.GotoAsync("https://testautomationpractice.blogspot.com/");
        ILocator Name = Page.GetByPlaceholder("Enter Name");
        ILocator Email = Page.Locator("#email");
        ILocator Phone = Page.GetByRole(AriaRole.Textbox, new() { Name = "Phone" });

        foreach(var data in testData)
        {
            await Name.ClearAsync();
            await Name.FillAsync(data["Name"]);
            await Email.ClearAsync();
            await Email.FillAsync(data["Email"]);
            await Phone.ClearAsync();
            await Phone.FillAsync(data["Phone"]);
            await Page.WaitForTimeoutAsync(3000);
        }
    }
}