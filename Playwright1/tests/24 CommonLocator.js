export class RegisterPage{
    constructor(page){
        this.page = page;
        this.commonLocator = (id) => page.locator(`input#${id}`);
        this.commonLocatorMultiple = (...args) => page.locator(`//div[@id='${args[0]}'/span[${args[1]}]/input[${args[2]}]`);
        this.emailTxtBox = this.commonLocatorMultiple("MyID", 3, 1);
        this.commonLocatorString = (...args) => (`//div[@id='${args[0]}'/span[${args[1]}]/input[${args[2]}]`);
        this.gender_male_RadioBtn = this.commonLocator("gender-male");
        this.gender_female_RadioBtn = this.commonLocator("gender-female");
        this.firstNameTxtBox = this.commonLocator("FirstName");
        this.lastNameTxtBox = this.commonLocator("LastName");
    }

    async fillRegisterForm(fname, gender){
        if(gender == "male"){
            await this.gender_male_RadioBtn.click();
        }else{
            await this.gender_female_RadioBtn.click();
        }
        await this.commonLocator("FirstName").fill(fname);
    }

    async printMultipleCommonLocator(){
        console.log(this.commonLocatorString("MyID", 3, 1));
        // let x = "abc";
        // x.t
    }
}

// const name1 = "Rajesh";
// const message = `Hello ${name1}`

// console.log(message);

// const locator1 = page.locator(`//input[@name=${name2}`);

// const commonLocator = (name3) => page.locator(`//input[@name=${name3}`);
// const myLocator = commonLocator("Rajesh");
// commonLocator("Rajesh").fill("");