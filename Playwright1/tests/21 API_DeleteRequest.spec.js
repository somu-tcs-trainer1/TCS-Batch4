import { expect, test } from '@playwright/test';

test('delete api request', async ({ request }) => {

    //Send the GET request to the API endpoint 
    const response = await request.delete("https://jsonplaceholder.typicode.com/posts/99");

    console.log(await response.status());
    //console.log(await response.text());
    await expect(response.status()).toBe(200);

});
