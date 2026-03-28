const {test, expect} = require("./28a CreateToDoFixture");

test('todofxiture test', async( { todoPage, page }) => {
    await todoPage.addToDo('1. Buy groceries for this week');
    await todoPage.addToDo('2. Book tickets for the music concert');

    const todoItemsList = await todoPage.todoItems.all();
    await expect(todoItemsList).toContainText(["Buy groceries"]);
    await page.waitForTimeout(5000);
})