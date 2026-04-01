export class RegisterPage{
    constructor(page){
        this.page = page;
        this.commonLocator = (id) => page.locator(`input#${id}`);
        this.gender_male_RadioBtn = page.locator("input#gender-male")
        this.gender_female_RadioBtn = page.locator("input#gender-female");
        this.firstNameTxtBox = page.locator("input#FirstName");
        this.lastNameTxtBox = page.locator("input#LastName");
        this.emailTxtBox = page.locator("input#Email");
        this.passwordTxtBox = page.locator("input#Password");
        this.confirmPasswordTxtBox = page.locator("input#ConfirmPassword");
        this.registerBtn = this.commonLocator("register-button"); 
        //this.registerBtn = page.locator("input#register-button");
    }

    async fillRegisterForm(fname, lname, email, pswd, gender){
        if(gender == "male"){
            await this.gender_male_RadioBtn.click();
        }else{
            await this.gender_female_RadioBtn.click();
        }
        await this.firstNameTxtBox.clear();
        await this.firstNameTxtBox.fill(fname);
        await this.lastNameTxtBox.clear();
        await this.lastNameTxtBox.fill(lname);
        await this.emailTxtBox.clear();
        await this.emailTxtBox.fill(email);

        await this.passwordTxtBox.clear();
        await this.passwordTxtBox.fill(pswd);
        await this.confirmPasswordTxtBox.clear();
        await this.confirmPasswordTxtBox.fill(pswd);
        await this.page.waitForTimeout(2000);
        //await this.registerBtn.click();
        //await this.page.waitForTimeout(2000);
    }
}