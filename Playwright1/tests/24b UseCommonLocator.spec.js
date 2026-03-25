import { test } from '@playwright/test';
import { RegisterPage } from './24 CommonLocator';

//let registerPage;

test('register a new user using common locator', async({page}) => {
    const registerPage = new RegisterPage(page);
    await page.goto("https://demowebshop.tricentis.com/register");
    await registerPage.fillRegisterForm("fnameUser4", "male");
    await registerPage.printMultipleCommonLocator();
    await page.waitForTimeout(3000);
});