import { test, expect } from '@playwright/test'

test('extract text test', async ({ page }) => {
    await page.goto("https://playwright.dev/");
    console.log("Page opened successfully");
    //Find the source, target elements to drag and drop
    await page.waitForTimeout(2000);

    const elementToExtractText = await page.locator("//div[@id='__docusaurus_skipToContent_fallback']/main/section[1]/div[1]/div/div[1]/h3");;
    let elementInntext = await elementToExtractText.innerText();
    console.log("The text of the element using INNERTEXT :"+elementInntext);

    let elementTextContent = await elementToExtractText.textContent();
    console.log("The text of the element using TEXTCONTENT :"+elementTextContent);

    const elementToExtractText2 = await page.locator("//div[@id='__docusaurus_skipToContent_fallback']/main/section[1]/div[1]/div/div[1]/div/p[1]");
    let elementInntext2 = await elementToExtractText2.innerText();
    console.log("The text of the element using INNERTEXT :"+elementInntext2);

    let elementTextContent2 = await elementToExtractText2.textContent();
    console.log("The text of the element using TEXTCONTENT :"+elementTextContent2);

    await page.waitForTimeout(3000);
})
