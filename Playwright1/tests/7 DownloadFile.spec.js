import { test, expect } from '@playwright/test'

test('download file test', async ({ page }) => {
    await page.goto("https://www.microsoft.com/en-in/microsoft-teams/download-app");
    console.log("Page opened successfully");

    //FILE DOWNLOAD
    await page.waitForTimeout(2000);
    const downloadButton = await page.getByRole("link", {name: "Download Microsoft Teams for Windows"});
    
    // Start waiting for download before clicking. Note no await.
    const downloadPromise = page.waitForEvent('download');
    await downloadButton.click();
    const download = await downloadPromise;

    // Wait for the download process to complete and save the downloaded file somewhere.
    await download.saveAs("C:\\Users\\Lenovo\\OneDrive\\Desktop\\Class Programs\\Playwright1\\tests\\DownloadedFiles\\" + download.suggestedFilename());

    await page.waitForTimeout(3000);
})