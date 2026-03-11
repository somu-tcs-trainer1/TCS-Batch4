import { test, expect } from '@playwright/test'

// test.beforeEach()

test('take screenshot test', async ({ page }) => {
    await page.goto("https://parabank.parasoft.com/parabank/index.htm");
    console.log("Page opened successfully");
    await page.waitForTimeout(2000);

    const filepath = "C:\\Users\\Lenovo\\OneDrive\\Desktop\\Class Programs\\Playwright1\\tests\\DownloadedFiles\\"
    await page.screenshot({path: filepath+ "VisiblePageScreenshot.png"});
    await page.screenshot({path: filepath+ "fullPageScreenshot.png", fullPage: true});
    //await page.getByPlaceholder("Enter Name").fill("Sample Name");

    //const element = await page.locator("//div[@id='headerPanel']/ul/li/a[@href='index.htm']");
    const element = await page.locator("//div[@id='headerPanel']/ul[2]/li[1]/a");
    
    await element.screenshot({path: filepath+"elementScrshot.png"});
    await page.waitForTimeout(3000);
})