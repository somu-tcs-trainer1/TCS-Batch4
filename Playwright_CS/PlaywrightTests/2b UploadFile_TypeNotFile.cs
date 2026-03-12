using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class UploadFileTypeNotFile : PageTest
{
    [Test]
    public async Task UploadSingleFileTypeNotFileTest()
    {
        Console.WriteLine("Executing UploadFileTypeNotFileTest");
        await Page.GotoAsync("https://www.ilovepdf.com/word_to_pdf");

        string fileDirPath = "C:\\Users\\Lenovo\\OneDrive\\Desktop\\TCS Latest\\";
        string file1 = "Can we make a CSharp property private.docx";

        //SINGLE FILE UPLOAD
        //Store waiting for event in a infer type, click on the button and then upload file
        var fileChooser = await Page.RunAndWaitForFileChooserAsync(async () =>
        {
            await Page.GetByTitle("Add more files").ClickAsync();
        });
        await fileChooser.SetFilesAsync(fileDirPath + file1);

        await Expect(Page.Locator("#fileGroups div:nth-child(1) div.file__info span")).ToHaveTextAsync(file1);
        Console.WriteLine($"Verified {file1} is listed on the page after upload action");

        await Page.WaitForTimeoutAsync(3000);
    }

    [Test]
    public async Task UploadMultipleFileTypeNotFileTest()
    {
        Console.WriteLine("Executing UploadFileTypeNotFileTest");
        await Page.GotoAsync("https://www.ilovepdf.com/word_to_pdf");

        string fileDirPath = "C:\\Users\\Lenovo\\OneDrive\\Desktop\\TCS Latest\\";
        string file1 = "Can we make a CSharp property private.docx";
        string file2 = "Mid-Assessment 1 Qs.docx";
        string file3 = "Why string in JS is primitive and not in C.docx";
        string[] uploadFiles = {fileDirPath+file1, fileDirPath+file2, fileDirPath+file3};

        //MULTIPLE FILE UPLOAD
        //Store waiting for event in a infer type, click on the button and then upload file
        var fileChooser = await Page.RunAndWaitForFileChooserAsync(async () =>
        {
            await Page.GetByTitle("Add more files").ClickAsync();
        });
        await fileChooser.SetFilesAsync(uploadFiles);

        await Expect(Page.Locator("#fileGroups div:nth-child(1) div.file__info span")).ToHaveTextAsync(file1);
        Console.WriteLine($"Verified {file1} is listed on the page after upload action");

        await Expect(Page.Locator("#fileGroups div:nth-child(2) div.file__info span")).ToHaveTextAsync(file2);
        Console.WriteLine($"Verified {file2} is listed on the page after upload action");

        await Expect(Page.Locator("#fileGroups div:nth-child(3) div.file__info span")).ToHaveTextAsync(file3);
        Console.WriteLine($"Verified {file3} is listed on the page after upload action");

        await Page.WaitForTimeoutAsync(3000);
    }
}