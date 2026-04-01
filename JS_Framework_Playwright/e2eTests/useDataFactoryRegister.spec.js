const {test, expect } = require('@playwright/test');
const DataFactory = require('../Utils/DataFactory');
import { RegisterPage } from "../pages/RegisterPage";

//Load the data dynamically from the file
// const users = DataFactory.getTestData("DataFiles/UserData.xlsx");
// const users = DataFactory.getTestData("DataFiles/UserData.csv");
const users = DataFactory.getTestData("DataFiles/UserData.json");

test.describe('Data-Driven test using excel', () =>{
    for(const user of users){
        test(`Fill the form data on Register page for ${user.FirstName}`, async({page}) =>{
        const registerPage = new RegisterPage(page);
        await page.goto("/register");
        await registerPage.fillRegisterForm(user.FirstName, user.LastName, user.Email, 
            user.Password, user.Gender);
        await page.waitForTimeout(3000);
        })
    }

})