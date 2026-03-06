import {test, expect} from '@playwright/test'

test('upload file test', async ({page}) => {
    await page.goto("https://testautomationpractice.blogspot.com/");
    console.log("Page opened successfully");

    //SINGLE FILE UPLOAD
    await page.waitForTimeout(2000);
    const uploadFileElement1 = await page.locator("//input[@id='singleFileInput']");
    await uploadFileElement1.scrollIntoViewIfNeeded();

    await page.waitForTimeout(3000);
    await uploadFileElement1.setInputFiles("C:\\Users\\Lenovo\\OneDrive\\Desktop\\TCS Latest\\Task Class in CSharp.docx");
    await page.getByText("Upload Single File").click();
    await page.waitForTimeout(2000);
    
    //MULTIPLE FILE UPLOAD
    const file1 = "C:\\Users\\Lenovo\\OneDrive\\Desktop\\TCS Latest\\Class Notes\\Day 3.txt";
    const file2 = "C:\\Users\\Lenovo\\OneDrive\\Desktop\\TCS Latest\\Class Notes\\Day 5.txt";
    const file3 = "C:\\Users\\Lenovo\\OneDrive\\Desktop\\TCS Latest\\Class Notes\\Day 6.txt";
    await page.waitForTimeout(2000);
    const uploadFileElement2 = await page.locator("//input[@id='multipleFilesInput']");
    await uploadFileElement2.setInputFiles([file1, file2, file3]);
    await page.getByText("Upload Multiple Files").click();


    await page.waitForTimeout(3000);
})