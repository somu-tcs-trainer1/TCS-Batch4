using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class UploadFilesTest : PageTest
{
    [Test]
    public async Task FileUploadTest()
    {
        Console.WriteLine("Executing FormFillTest");

        await Page.GotoAsync("https://testautomationpractice.blogspot.com/");

    // var uploadFileElement1 = Page.Locator("//input[@id='singleFileInput']");
    // await uploadFileElement1.scrollIntoViewIfNeeded();
    string file1 = "C:\\Users\\Lenovo\\OneDrive\\Desktop\\TCS Latest\\Class Notes\\Day 3.txt";

    await Page.Locator("//input[@id='singleFileInput']").SetInputFilesAsync(file1);
    await Page.GetByText("Upload Single File").ClickAsync();
    await Page.WaitForTimeoutAsync(3000);
    
    //MULTIPLE FILE UPLOAD
    string file2 = "C:\\Users\\Lenovo\\OneDrive\\Desktop\\TCS Latest\\Class Notes\\Day 5.txt";
    string file3 = "C:\\Users\\Lenovo\\OneDrive\\Desktop\\TCS Latest\\Class Notes\\Day 6.txt";

    await Page.Locator("//input[@id='multipleFilesInput']").SetInputFilesAsync([file1, file2, file3]);
    await Page.GetByText("Upload Multiple Files").ClickAsync();
    await Page.WaitForTimeoutAsync(3000);

    }
}