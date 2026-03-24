import { expect, test } from '@playwright/test';

test('post api request', async ({ request }) => {

    //URL for post request
    const url = "https://jsonplaceholder.typicode.com/posts";
    //payload for post request
    const requestBody = {
    "userId": 111,
    "title": "sample test request from Soma Shekhar 24032026001",
    "body": "sample body field value for test request from Soma Shekhar 24032026001"
  }

    //Send the POST request to the API endpoint 
    const response = await request.post(url, {data: requestBody});
    console.log(await response.text());
    expect(response.status()).toEqual(201);

    const responseData = await response.json();
    expect(responseData.title).toBe("sample test request from Soma Shekhar 24032026001");
    expect(responseData.body).toBe("sample body field value for test request from Soma Shekhar 24032026001");
})

test('post api request with Auth', async ({ request }) => {

    //URL for post request
    const url = "https://jsonplaceholder.typicode.com/posts";
    //payload for post request
    const requestBody = {
    "userId": 112,
    "title": "sample test request from Soma Shekhar 24032026002",
    "body": "sample body field value for test request from Soma Shekhar 24032026002"
  }

  const headersContent = {
                            'Content-Type': 'application/json',
                            'Authorization': 'Bearer YOUR_ACCESS_TOKEN'
                        }

    //Send the POST request to the API endpoint 
    const response = await request.post(url, 
                    {
                        data: requestBody, 
                        headers: headersContent,                        
                    },
                );
    
    console.log(await response.text());
    expect(response.status()).toEqual(201);

    const responseData = await response.json();
    expect(responseData.title).toBe("sample test request from Soma Shekhar 24032026002");
    expect(responseData.body).toBe("sample body field value for test request from Soma Shekhar 24032026002");
})