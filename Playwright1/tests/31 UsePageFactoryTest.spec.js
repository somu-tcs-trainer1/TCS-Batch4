import { test } from '@playwright/test';
import { PageFactory } from './30 PageFactory';

test('use pagefactory with automation site', async({page}) =>{
    const factory = new PageFactory(page);

    const automation = factory.createPage("automationSite");
    await automation.launch()
    await automation.fillBasicForm("Anand Kumar", "anandkumar21@example.com", "1234567890");

    const todo = factory.createPage("todo");
    await todo.goto();
    await todo.addToDo("1. Shop for Grocery");
    await todo.addToDo("2. Complete Living Room Cleaning");

    await page.waitForTimeout(5000);
});