import { expect, test } from '@playwright/test';

test('assertions test', async ({ page }) => {
    await page.goto("https://testautomationpractice.blogspot.com/");
    console.log("Page opened successfully");
    await expect(page).toHaveTitle('Automation Testing Practice');
    await expect(page).toHaveURL('https://testautomationpractice.blogspot.com/');

    await expect(page.getByPlaceholder("Enter Name")).toBeVisible();
    await expect(page.getByPlaceholder("Enter Name")).toBeEditable();
    await page.getByPlaceholder("Enter Name").fill("Sample Name");

    await page.locator("#email").fill("sample_email@example.com");
    await page.getByRole("textbox", { name: 'Phone' }).fill('1234567890');
    await page.getByRole('textbox', { name: 'Address' }).fill('4th Street, First Down, Umbrella Avenue, RajNagar ');

    await expect(page.getByLabel('Female')).toBeEnabled();    
    await page.getByLabel('Female').check();
    await expect(page.getByLabel('Female')).toBeChecked();

    await expect(page.getByLabel('Tuesday')).toBeEnabled();    
    await page.getByLabel('Tuesday').check();
    await expect(page.getByLabel('Tuesday')).toBeChecked();

    await expect(page.locator("//div[@id='header-inner']/div/h1")).toHaveText("Automation Testing Practice");
    await expect(page.locator("//div[@id='header-inner']/div/h1")).toContainText("Automation Testing Practice");
    await expect(page.locator("//div[@id='header-inner']/div/h1")).toHaveClass("title");

    const headerTxt = await page.locator("//div[@id='header-inner']/div/h1").textContent();
    console.log("Header Text value: ", headerTxt);
    expect(headerTxt.trim() == "Automation Testing Practice").toBeTruthy();

    await page.waitForTimeout(3000);
})