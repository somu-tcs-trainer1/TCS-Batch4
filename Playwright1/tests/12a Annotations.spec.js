import { test } from '@playwright/test';

// test.describe('test suite / group', async ({page}) => {
    test.describe('test suite / group', () => {
      test.describe.configure({ mode: 'serial' });
    //   page.locator("").click();
    // test.skip('test1 inside test suite @smoke @regression', { tag: '@smoke' }, async ({ page }) => {
    //     console.log("test1 inside test suite");
    // });

    // test.fail('test2 inside test suite @regression', async ({ page }) => {
    //     console.log("test2 inside test suite");
    // });

    // test.fixme('test3 inside test suite', async ({ page }) => {
    //     console.log("test3 inside test suite");
    // });

    test('test4 inside test suite @smoke @regression', { tag: '@smoke' }, async ({ page }) => {
        console.log("test4 inside test suite");
    });

    test('test5 inside test suite @smoke', { tag: '@smoke' }, async ({ page }) => {
        console.log("test5 inside test suite");
    });

    // test.only('test6 inside test suite', async ({ page }) => {
    //     console.log("test6 - only annotation");
    // });

    // test.only('test7 inside test suite', async ({ page }) => {
    //     console.log("test7 - only annotation");
    // });

    // test.slow('test8 inside test suite @smoke @regression', { tag: '@smoke' }, async ({ page }) => {
    //     console.log("test8 - slow annotation");
    // });

    test.beforeAll('BeforeAll test', async () => {
     test('test inside before all', async ({ page }) => {
        console.log("inside before all");
    });

        console.log("BeforeAll test");
    });

    test.beforeEach('beforeEach Test', async ({page}) => {
        console.log("beforeEach Test");
    });

    test.afterAll('afterAll test', async () => {
        console.log("afterAll test");
    });

    test.afterEach('afterEach test', async ({page}) => {
        console.log("afterEach test");
    });


});
