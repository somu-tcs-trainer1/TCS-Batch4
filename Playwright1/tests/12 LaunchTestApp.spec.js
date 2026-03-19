import { test } from '@playwright/test';

// test.beforeEach()

test('launch test app', async ({ page }) => {
    await page.goto("https://www.demoblaze.com/");
    console.log("Page opened successfully");

    // await page.locator('#country').selectOption('India');

    await page.waitForTimeout(3000);
})