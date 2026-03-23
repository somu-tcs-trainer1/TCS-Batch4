const { Given, When, Then, Before, After, setDefaultTimeout } = require("@cucumber/cucumber");
const { chromium, expect } = require("@playwright/test");
const { Page } = require("playwright");
setDefaultTimeout(60 * 1000);

let page, browser;

Before(async function () {
    browser = await chromium.launch({ headless: false });
    const context = await browser.newContext();
    page = await context.newPage();
})

Given('I am on the page "{string}"', async function (url) {
    await page.goto(url);
});

When('I want to enter {int}', async function (empID) {
    // When('I want to enter {float}', async function (float) {
    console.log(empID);
    
});

After(async function () {
    await browser.close();
})

