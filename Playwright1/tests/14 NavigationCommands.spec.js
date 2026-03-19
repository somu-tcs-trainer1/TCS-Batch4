import { test } from '@playwright/test';

test('navigation commands test', async ({ page }) => {
    await page.goto("https://demowebshop.tricentis.com/");
    console.log("Page opened successfully");

    await page.locator("//a[@href='/register']").click();
    await page.waitForTimeout(2000);

    await page.goBack();
    await page.waitForTimeout(2000);

    await page.goForward();
    await page.waitForTimeout(2000);

    await page.reload();
    await page.waitForTimeout(3000);
})

