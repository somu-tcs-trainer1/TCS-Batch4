import test from '@playwright/test';

test('Webtable test', async({page}) => {
    await page.goto('https://testautomationpractice.blogspot.com/');

    const table = await page.locator("//table[@name='BookTable']");
    await table.scrollIntoViewIfNeeded();

    const rows = await page.locator("//table[@name='BookTable']/tbody/tr");
    const cols = await page.locator("//table[@name='BookTable']/tbody/tr[2]/td");
    //const cols = await page.locator("//table[@name='BookTable']/tbody/tr[1]/th");

    console.log("The number of rows in the Books table: ", await rows.count());
    console.log("The number of cols in the Books table: ", await cols.count());

    for(let i=1; i < await rows.count(); i++){
        const row = await rows.nth(i);
        const col = await row.locator("td");
        let result = "";
        for(let j=0; j<await cols.count(); j++){
            const value = await col.nth(j).textContent();
            //console.log(value) //print in the same line
            result = result + value + " ";
        }
        console.log(result);
    }
})