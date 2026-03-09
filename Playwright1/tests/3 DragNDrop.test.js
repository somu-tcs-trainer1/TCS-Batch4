import { test, expect } from '@playwright/test'

test('drag and drop test', async ({ page }) => {
    await page.goto("https://jqueryui.com/droppable/");
    console.log("Page opened successfully");

    //Find the source, target elements to drag and drop
    await page.waitForTimeout(2000);

    const sourceElement = await page.frameLocator('.demo-frame').getByText("Drag me to my target");
    const targetElement = await page.frameLocator('.demo-frame').getByText("Drop here");
    
    await sourceElement.dragTo(targetElement);
    await page.waitForTimeout(3000);
})

test('drag and drop test2', async ({ page }) => {
    await page.goto("https://jqueryui.com/droppable/");
    console.log("Page opened successfully");

    //Find the source, target elements to drag and drop
    await page.waitForTimeout(2000);

    const frame = page.frameLocator("//iframe[@src='/resources/demos/droppable/default.html']");

    const sourceElement = await frame.getByText("Drag me to my target");
    const targetElement = await frame.getByText("Drop here");
    
    await sourceElement.dragTo(targetElement);
    await page.waitForTimeout(3000);
})