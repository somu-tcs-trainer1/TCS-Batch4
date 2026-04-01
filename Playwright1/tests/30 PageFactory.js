import { AutomationSitePage } from './10a TestAutomationSitePage';
import { TodoPage } from './28 FixtureExamplePage';

export class PageFactory{
    constructor(page){
        this.page = page;
    }

    createPage(pageName){
        switch(pageName.toLowerCase()){
            case 'automationsite':
                return new AutomationSitePage(this.page);
            case 'todo':
                return new TodoPage(this.page);
            default:
                throw new Error(`page type ${pageName} is not incorrect or is not supported`);
        }
    }
}