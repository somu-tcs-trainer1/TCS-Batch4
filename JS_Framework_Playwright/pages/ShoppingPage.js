export class LoginPage{
    constructor(page){
        this.page = page;
        this.commonLocator = (id) => page.locator(`input#${id}`);
        //this.emailTxtBox = page.locator("input#Email");
        // this.passwordTxtBox = page.locator("input#Password");  
    }

    async searchForProduct(productName){
        if((email != null || email != undefined) && (pswd != null || pswd != undefined)){
        await this.emailTxtBox.clear();
        await this.emailTxtBox.fill(email);
        await this.passwordTxtBox.clear();
        await this.passwordTxtBox.fill(pswd);
        // await expect(this.emailTxtBox)
        await this.loginBtn.click();
        }else{
            new Error("the email or pswd fields are empty")
        }

        await this.page.waitForTimeout(2000);
    }
}