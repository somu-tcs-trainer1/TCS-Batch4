import {test, expect} from '@playwright/test'

// test.beforeEach()

test('fill the form', async ({page}) => {
    await page.goto("https://testautomationpractice.blogspot.com/");
    console.log("Page opened successfully");

    await page.getByPlaceholder("Enter Name").fill("Sample Name");

    await page.locator("#email").fill("sample_email@example.com");

    await page.getByRole("textbox", {name : 'Phone'}).fill('1234567890');

    await page.getByRole('textbox', {name : 'Address'}).fill('4th Street, First Down, Umbrella Avenue, RajNagar ');

    await page.getByLabel('Female').check();

    await page.getByLabel('Tuesday').check();
    await page.getByLabel('Wednesday').check();

    await page.locator('#country').selectOption('India');

    await page.waitForTimeout(3000);
})