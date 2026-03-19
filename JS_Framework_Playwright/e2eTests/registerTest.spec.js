import { test } from "@playwright/test";
import { RegisterPage } from "../pages/RegisterPage";

//let registerPage;

test('register a new user', async({page}) => {
    const registerPage = new RegisterPage(page);
    await page.goto("/register");
    await registerPage.fillRegisterForm("fnameUser4", "lnameUser4", "shekhar_user4@example.com", "Password@123", "male");
    await page.waitForTimeout(3000);
});