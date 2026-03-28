// import { expect, test } from '@playwright/test';

// export default function playwrightParallelPageTest() {
//     test('has title - Playwright Parallel Page', async ({ page }) => {
//         await page.goto('https://playwright.dev/docs/test-parallel');
//         // Expect a title "to contain" a substring.
//         await expect(page).toHaveTitle(/Parallelism/);
//         console.log("Playwright Parallel Page opened successfully");
//     });
// }

export default function playwrightParallelPageTest(test, expect) {
    test('has title - Playwright Parallel Page', async ({ page }) => {
        await page.goto('https://playwright.dev/docs/test-parallel');
        await expect(page).toHaveTitle(/Parallelism/);
        console.log("Playwright Parallel Page opened successfully");
    });
}
