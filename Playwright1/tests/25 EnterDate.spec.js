import { test } from '@playwright/test';

test('fill dates in form', async ({ page }) => {
    await page.goto("https://testautomationpractice.blogspot.com/");
    console.log("Page opened successfully");

    await page.locator("//input[@id='datepicker']").scrollIntoViewIfNeeded();
    await page.locator("//input[@id='datepicker']").fill("27/03/2026");
    await page.locator("//input[@id='datepicker']").click();
    await page.waitForTimeout(3000);
    await page.locator("//input[@id='start-date']").scrollIntoViewIfNeeded();
    await page.locator("//input[@id='start-date']").pressSequentially("27032026");
    await page.locator("//input[@id='end-date']").pressSequentially("28032026");

    await page.waitForTimeout(3000);
})