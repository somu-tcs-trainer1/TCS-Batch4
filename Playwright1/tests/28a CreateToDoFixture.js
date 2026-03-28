const {test: base} = require('@playwright/test');
const {TodoPage} = require('./28 FixtureExamplePage');

//Extending the base test to include custom fixture
exports.test = base.extend({
    todoPage: async ({page}, use) => {
        //Set up / Instantiate the POM and navigate to the page
        const todoPage = new TodoPage(page);
        await todoPage.goto();
        //Use: passes the fixture to the test
        await use(todoPage);

        await todoPage.removeAll();
    }
})

exports.expect = base.expect;