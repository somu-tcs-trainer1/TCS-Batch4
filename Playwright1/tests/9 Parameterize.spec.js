import { test, expect } from '@playwright/test'
import * as fs from 'fs'
import * as path from "path"
import { parse } from "csv-parse/sync"
import * as XLSX from "xlsx"

test('parameterize using excel', async ({ page }) => {
    await page.goto("https://testautomationpractice.blogspot.com/");
    console.log("Page opened successfully");

    const nameTxtbox = await page.getByPlaceholder("Enter Name");
    const emailTxtbox = await page.locator("#email");
    const phoneTxtbox = await page.getByRole("textbox", { name: 'Phone' });

    const xlFilePath = path.join(__dirname, "ExcelTestData.xlsx");
    const workbook = XLSX.readFile(xlFilePath);
    const SheetName = workbook.SheetNames[0];
    const sheet = workbook.Sheets[SheetName];

    for (let index = 2; index < 5; index++) {
        const name = sheet[`A${index}`].v;
        const email = sheet[`B${index}`].v;
        const phone = String(sheet[`C${index}`].v);
        console.log("Name from excel: ", name);
        console.log("Email from excel: ", email);
        console.log("Phone from excel: ", phone);
        await nameTxtbox.clear();
        await nameTxtbox.fill(name);

        await emailTxtbox.clear();
        await emailTxtbox.fill(email);

        await phoneTxtbox.clear();
        await phoneTxtbox.fill(phone);
        await page.waitForTimeout(2000);
    }
})


test('parameterize using csv', async ({ page }) => {
    await page.goto("https://testautomationpractice.blogspot.com/");
    console.log("Page opened successfully");

    const nameTxtbox = await page.getByPlaceholder("Enter Name");
    const emailTxtbox = await page.locator("#email");
    const phoneTxtbox = await page.getByRole("textbox", { name: 'Phone' });

    const csvFilePath = path.join(__dirname, "TestData.csv");
    const csvData = fs.readFileSync(csvFilePath, "utf-8");
    const testData = parse(csvData, { columns: true, skip_empty_lines: true });

    for (const data of testData) {
        await nameTxtbox.clear();
        await nameTxtbox.fill(data.name);

        await emailTxtbox.clear();
        await emailTxtbox.fill(data.email);

        await phoneTxtbox.clear();
        await phoneTxtbox.fill(data.phone);
        await page.waitForTimeout(2000);
    }
})

test('parameterize using json', async ({ page }) => {
    await page.goto("https://testautomationpractice.blogspot.com/");
    console.log("Page opened successfully");

    const nameTxtbox = await page.getByPlaceholder("Enter Name");
    const emailTxtbox = await page.locator("#email");
    const phoneTxtbox = await page.getByRole("textbox", { name: 'Phone' });

    const jsonFilePath = path.join(__dirname, "testdata.json");
    const testData = JSON.parse(fs.readFileSync(jsonFilePath, "utf-8"));

    for (const data of testData) {
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
    for (const name of names) {
        await nameTxtbox.clear();
        await nameTxtbox.fill(name);
        await page.waitForTimeout(1000);
    }
    await page.waitForTimeout(3000);
})

