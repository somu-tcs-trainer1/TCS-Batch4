import { test, expect } from '@playwright/test'
import * as fs from 'fs'
import * as path from "path"

test('parameterize using json', async ({ page }) => {
    await page.goto("https://testautomationpractice.blogspot.com/");
    console.log("Page opened successfully");

    const nameTxtbox = await page.getByPlaceholder("Enter Name");
    const emailTxtbox = await page.locator("#email");
    const phoneTxtbox = await page.getByRole("textbox", { name: 'Phone' });

    const jsonFilePath = path.join(__dirname, "testdata.json");
    const testData = JSON.parse(fs.readFileSync(jsonFilePath, "utf-8"));

    for(const data of testData){
        await nameTxtbox.clear();
        await nameTxtbox.fill(data.name);
        await emailTxtbox.clear();
        await emailTxtbox.fill(data.email);
        await phoneTxtbox.clear();
        await phoneTxtbox.fill(data.phone);
        await page.waitForTimeout(2000);
    }
})

test('parameterize using array', async ({ page }) => {
    await page.goto("https://testautomationpractice.blogspot.com/");
    console.log("Page opened successfully");

    const names = ["Kailash Reddy", "Rajesh Kumar", "Lalitha Kumari"]
    const nameTxtbox = await page.getByPlaceholder("Enter Name");
    for(const name of names){
        await nameTxtbox.clear();
        await nameTxtbox.fill(name);
        await page.waitForTimeout(1000);
    }
    await page.waitForTimeout(3000);
})

