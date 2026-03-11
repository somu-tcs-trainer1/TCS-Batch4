import { test, expect } from '@playwright/test'

test('drag test', async ({ page }) => {
    await page.goto("https://jqueryui.com/draggable/");
    console.log("Page opened successfully");

    //Find the source, target elements to drag and drop
    await page.waitForTimeout(2000);
    const sourceElement = await page.frameLocator('.demo-frame').getByText("Drag me around");
    
    await sourceElement.dragTo(sourceElement, {
    targetPosition: { x: 125, y: 87 },
    force: true
    });
    await page.waitForTimeout(3000);
})
