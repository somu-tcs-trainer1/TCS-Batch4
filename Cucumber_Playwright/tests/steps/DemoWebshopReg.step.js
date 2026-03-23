/*
const { Given, When, Then, Before, After, setDefaultTimeout} = require("@cucumber/cucumber");
const { chromium, expect } = require("@playwright/test");
const { Page } = require("playwright");
setDefaultTimeout(60*1000);

let page, browser;

Before(async function () {
    browser = await chromium.launch({headless: false});
    const context = await browser.newContext();
    page = await context.newPage();
})

Given('I am on demowebshop register page', async function () {
    await page.goto("https://demowebshop.tricentis.com/register");
    
});

When('I fill the mandatory fields', async function () {
    await page.locator("input#gender-male").click();
    // await page.locator("input#gender-female");
    await page.locator("input#FirstName").fill("Shekhar_FirstName1");
    await page.locator("input#LastName").fill("Shekhar_LastName1");
    await page.locator("input#Email").fill("TestEmail2303001@example.com");
    await page.locator("input#Password").fill("Password@123");
    await page.locator("input#ConfirmPassword").fill("Password@123");    
});

When('I click on Register', async function () {
    await page.locator("input#register-button").click();    
});

Then('I should see the message for succesful user registration', async function () {
        
});

Then('the successful user is already logged in', async function () {
        
});


// Given('I am on demowebshop register page', async function () {
//     // Write code here that turns the phrase above into concrete actions
    
// });

When('I don\'t fill all the mandatory fields', async function () {
    // Write code here that turns the phrase above into concrete actions
    
});

// When('I click on Register', async function () {
//     // Write code here that turns the phrase above into concrete actions
    
// });

Then('I should see the error message asking to enter all mandatory details', async function () {
    // Write code here that turns the phrase above into concrete actions
    
});

After(async function () {
    await browser.close();
})
    */