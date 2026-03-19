import { test } from '@playwright/test';

test('get all links from a page', async ({ page }) => {
    await page.goto("https://demowebshop.tricentis.com/");
    console.log("Page opened successfully");

    // const registerLink = await page.getByRole("link", {name: 'Register'} );
    // console.log("The register link value:", registerLink);

    const links = await page.getByRole("link").all();
     console.log("The number of links on this page are: ", links.length);
    // console.log("The links list :", links.textContent());
    // const linksCount = await links.count();
    // console.log("The number of links on this page are: "+linksCount)
    await page.waitForTimeout(3000);

    
    console.log("List of all links in the page: ");
    // const allLinks = await links.all();
    for(const link of links){
        console.log(await link.getAttribute("href"));
        // if(await link.textContent() != '' || await link.textContent() != null){
        //      console.log(await link.textContent());
            
        // }
    }
        
})

