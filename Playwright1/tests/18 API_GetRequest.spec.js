import { expect, test } from '@playwright/test';

test('get api request', async ({ request }) => {

    //Send the GET request to the API endpoint 
    const response = await request.get("https://jsonplaceholder.typicode.com/users");

    console.log(await response.status());
    //console.log(await response.text());
    await expect(response.status()).toBe(200);

    const data = await response.json();
    expect(data[0]).toHaveProperty('id');
    expect(data[0]).toHaveProperty('name');
    expect(data[0]).toHaveProperty('username');

    expect(data[0].name).toBe("Leanne Graham");
    const headers = await response.headers();
    expect(headers['content-type']).toContain('application/json');

})