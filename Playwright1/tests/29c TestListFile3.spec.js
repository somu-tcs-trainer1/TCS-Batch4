// import { expect, test } from '@playwright/test';

// export default function demoWebShopPageTest() {
//     test('has title - Demo Web Shop Page', async ({ page }) => {
//         await page.goto("https://demowebshop.tricentis.com/");
//         // Expect a title "to contain" a substring.
//         await expect(page).toHaveTitle('Demo Web Shop');
//         console.log("Demo Web Shop Page opened successfully");
//     });
// }

export default function demoWebShopPageTest(test, expect) {
    test('has title - Demo Web Shop Page', async ({ page }) => {
        await page.goto("https://demowebshop.tricentis.com/");
        // Expect a title "to contain" a substring.
        await expect(page).toHaveTitle('Demo Web Shop');
        console.log("Demo Web Shop Page opened successfully");
    });
}
