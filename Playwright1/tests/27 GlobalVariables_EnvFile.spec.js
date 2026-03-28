import { test } from '@playwright/test';

test('use global vars from env file', async ({ page }) => {
    await page.goto("/");
    console.log("Page opened successfully");

    await page.getByPlaceholder("Enter Name").fill(process.env.NAME);
    await page.locator("#email").fill(process.env.EMAIL);
    await page.getByRole("textbox", { name: 'Phone' }).fill(process.env.PHONE);

    await page.waitForTimeout(3000);
})