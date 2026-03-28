// import { expect, test } from '@playwright/test';

// export default function automationTestingPageTest() {
//     test('has title - Automation Testing Page', async ({ page }) => {
//         await page.goto("https://testautomationpractice.blogspot.com/");
//         // Expect a title "to contain" a substring.
//         await expect(page).toHaveTitle('Automation Testing Practice');
//         console.log("Automation Testing Page opened successfully");
//     });
// }

export default function automationTestingPageTest(test, expect) {
    test('has title - Automation Testing Page', async ({ page }) => {
        await page.goto("https://testautomationpractice.blogspot.com/");
        // Expect a title "to contain" a substring.
        await expect(page).toHaveTitle('Automation Testing Practice');
        console.log("Automation Testing Page opened successfully");
    });
}