import { test } from '@playwright/test';

test('hover multiple layers', async ({ page }) => {
    await page.goto("https://tgsouthernpower.org/");
    console.log("Page opened successfully");

    const mainElement = page.getByRole("link", { name: 'Renewable Energy '});
    await mainElement.waitFor({state: 'visible'});
    await mainElement.hover();
    await page.waitForTimeout(2000);

    await page.getByRole("link", { name: 'Solar Rooftop Netmetering'}).hover();
    await page.waitForTimeout(2000);

    const lastLink = page.getByRole("link", { name: 'Solar Rooftop Net Metering Guidelines'});
    await lastLink.hover();
    await page.waitForTimeout(2000);
    await lastLink.click();

     await page.waitForTimeout(5000);
})