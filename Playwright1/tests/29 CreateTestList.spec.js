// import { test } from '@playwright/test';

// import playwrightParallelPageTest from './29a TestListFile1.spec';
// import automationTestingPageTest from './29b TestListFile2.spec';
// // import demoWebShopPageTest from './29c TestListFile3.spec';

// test.describe('Test List Suite', () => {
//     test.describe.configure({ mode: 'serial' });
//     playwrightParallelPageTest();
//     automationTestingPageTest();
//     // demoWebShopPageTest();
// })

import { expect, test } from '@playwright/test';
import playwrightParallelPageTest from './29a TestListFile1';
import automationTestingPageTest from './29b TestListFile2';
import demoWebShopPageTest from './29c TestListFile3';

test.describe('Test List Suite', () => {
    test.describe.configure({ mode: 'serial' });

    // Pass the test and expect objects into your helper functions
    playwrightParallelPageTest(test, expect);
    automationTestingPageTest(test, expect);
    demoWebShopPageTest(test, expect);
});