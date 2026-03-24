import { expect, test } from '@playwright/test';

test('Retries test', async({page}) => {
    await page.goto('https://testautomationpractice.blogspot.com/');
    await expect(page).toHaveTitle("Automation Testing Practice Here");
})