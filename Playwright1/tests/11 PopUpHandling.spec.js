import { test } from '@playwright/test';

test('Handling pop-up with accept', async ({ page }) => {
    await page.goto("https://testautomationpractice.blogspot.com/");
    console.log("Page opened successfully");
    await page.waitForTimeout(2000);

    await page.getByText("Confirmation Alert").scrollIntoViewIfNeeded();
    page.on('dialog', async dialog => {
        await page.waitForTimeout(2000);
        console.log("The message inside the dialog box is: ", dialog.message());
        await dialog.accept();
    });
    await page.getByText("Confirmation Alert").click();

    await page.waitForTimeout(2000);
    await page.locator("//button[@name='start']").click();

    await page.waitForTimeout(3000);
})


test('Handling pop-up with dismiss', async ({ page }) => {
    await page.goto("https://testautomationpractice.blogspot.com/");
    console.log("Page opened successfully");
    await page.waitForTimeout(2000);

    await page.getByText("Confirmation Alert").scrollIntoViewIfNeeded();
    page.on('dialog', async dialog => {
        await page.waitForTimeout(2000);
        console.log("The message inside the dialog box is: ", dialog.message());
        await dialog.dismiss();
    });
    await page.getByText("Confirmation Alert").click();

    await page.waitForTimeout(2000);
    await page.locator("//button[@name='start']").click();

    await page.waitForTimeout(3000);
    await page.close();
})

test('Handling pop-up with prompt', async ({ page }) => {
    await page.goto("https://testautomationpractice.blogspot.com/");
    console.log("Page opened successfully");
    await page.waitForTimeout(2000);

    await page.getByText("Prompt Alert").scrollIntoViewIfNeeded();
    page.once('dialog', async dialog => {
        await page.waitForTimeout(2000);
        // Verify the dialog type (optional, but good practice)
        if (await dialog.type() === 'prompt') {
            console.log(`Dialog message: ${dialog.message()}`);
            // Enter text into the prompt's input field and accept it
            // await dialog.accept("UserName", "Password");
            await dialog.accept("UserName");
            await page.waitForTimeout(2000);
        } else {
            // Handle other dialog types (alert, confirm)
            await dialog.accept();
            await page.waitForTimeout(2000);
        }
    });

    await page.getByText("Prompt Alert").click();
    await page.waitForTimeout(2000);
    await page.locator("//button[@name='start']").click();

    await page.waitForTimeout(3000);
    await page.close();
});