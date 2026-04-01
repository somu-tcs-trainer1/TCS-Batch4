// import { page } from "@playwright/test";
export class AutomationSitePage{
    
    constructor(page){
        this.page = page;
        this.nameTxtbox = this.page.getByPlaceholder("Enter Name");
        this.emailTxtbox = this.page.locator("#email");
        this.phoneTxtbox = this.page.getByRole("textbox", { name: 'Phone' });
    }

    async launch(){
        await this.page.goto("https://testautomationpractice.blogspot.com/");
    }

    async fillBasicForm(name, email, phone){
        await this.nameTxtbox.clear();
        await this.nameTxtbox.fill(name);
        await this.emailTxtbox.clear();
        await this.emailTxtbox.fill(email);
        await this.phoneTxtbox.clear();
        await this.phoneTxtbox.fill(phone);
        await this.page.waitForTimeout(2000);
    }
}