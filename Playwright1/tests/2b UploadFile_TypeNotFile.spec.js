import { test, expect } from '@playwright/test'

test('upload when type not file test', async ({ page }) => {
    await page.goto("https://www.ilovepdf.com/word_to_pdf");
    console.log("Page opened successfully");

    const fileDirPath = "C:\\Users\\Lenovo\\OneDrive\\Desktop\\TCS Latest\\"
    const file1 = "Can we make a CSharp property private.docx";
    const file2 = "Mid-Assessment 1 Qs.docx";
    const file3 = "Why string in JS is primitive and not in C.docx";

    /*
    //SINGLE FILE UPLOAD
    //Store waiting for event in a constant, click on the button and then upload file
    const fileChooserPromise = page.waitForEvent('filechooser');
    page.getByTitle("Add more files").click();
    const filechooser = await fileChooserPromise;
    await filechooser.setFiles(fileDirPath+file1);
*/

    //MULTIPLE FILE UPLOAD
    const fileChooserPromise = page.waitForEvent('filechooser');
    page.getByTitle("Add more files").click();
    const filechooser = await fileChooserPromise;
    await filechooser.setFiles([fileDirPath+file1, fileDirPath+file2, fileDirPath+file3]);

    //Assertion that uploaded file name appears on the page
    await expect(page.locator("#fileGroups div:nth-child(1) div.file__info span")).toHaveText(file1);
    console.log(`Verified ${file1} is listed on the page after upload action`);

    await expect(page.locator("#fileGroups div:nth-child(2) div.file__info span")).toHaveText(file2);
    console.log(`Verified ${file2} is listed on the page after upload action`);

    await expect(page.locator("#fileGroups div:nth-child(3) div.file__info span")).toHaveText(file3);
    console.log(`Verified ${file3} is listed on the page after upload action`);

    await page.waitForTimeout(3000);
})