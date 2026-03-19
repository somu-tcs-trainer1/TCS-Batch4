import { test } from '@playwright/test';

test('get cssproperty of an element', async ({ page }) => {
    await page.goto("https://demowebshop.tricentis.com/");
    console.log("Page opened successfully");

    const registerLink = await page.locator("//a[@href='/register']")
    const txtColor = await registerLink.evaluate((ev) => {
        // return window.getComputedStyle(ev).getPropertyValue('color');
        return window.getComputedStyle(ev).getPropertyValue('background-color');
    })
    console.log("The color or the registerLink on the page is: ", txtColor);
    await page.waitForTimeout(2000);

})

