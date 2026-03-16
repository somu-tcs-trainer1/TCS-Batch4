import { test } from '@playwright/test';
import { AutomationSitePage } from './10a TestAutomationSitePage';


test('fill form with pom', async ({ page }) => {
    const automationPage = new AutomationSitePage(page);
    await automationPage.launch();
    await automationPage.fillBasicForm("Raju", "Raj234@email.com", "1111222233");

    await page.waitForTimeout(3000);
})
