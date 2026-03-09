import { test, expect } from '@playwright/test'

test('tooltip test', async ({ page }) => {
    await page.goto("https://parabank.parasoft.com/parabank/index.htm");
    console.log("Page opened successfully");

    //Find the source, target elements to drag and drop
    await page.waitForTimeout(2000);

    const parabankImg = await page.locator("//img[@alt='ParaBank']");
    await parabankImg.hover();
    await page.waitForTimeout(2000);
    expect(parabankImg).toHaveAttribute('title', 'ParaBank');

    await page.waitForTimeout(3000);
})

test('extract attribute value test', async ({ page }) => {
    await page.goto("https://www.bing.com/");
    console.log("Page opened successfully");
    await page.waitForTimeout(2000);

    const searchTxtBox = await page.locator("#sb_form_q");
    const txtToEnter = "mango";
    await searchTxtBox.fill(txtToEnter);
    await searchTxtBox.press("Tab");
    await page.waitForTimeout(2000);

    const valueFromElement = await searchTxtBox.getAttribute("value");
    expect(txtToEnter).toEqual(valueFromElement);
    console.log("the text entered into the search and value attribute extracted are same");

    await page.waitForTimeout(3000);
})
