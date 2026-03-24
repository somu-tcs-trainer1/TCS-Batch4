import { expect, test } from '@playwright/test';

test('put api request', async ({ request }) => {

    //URL for post request
    const url = "https://jsonplaceholder.typicode.com/posts/99";
    //payload for post request
    const requestBody = {
    "userId": 112,
    "title": "test request on 24032026002",
    "body": "body field value for test request on 24032026002"
  }

    //Send the POST request to the API endpoint 
    const response = await request.put(url, {data: requestBody});
    console.log(await response.text());
    expect(response.status()).toEqual(200);

    const responseData = await response.json();
    expect(responseData.title).toBe("test request on 24032026002");
    expect(responseData.body).toBe("body field value for test request on 24032026002");
})
