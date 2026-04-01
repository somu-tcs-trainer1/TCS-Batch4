
class CommonFunctions {
    constructor(page, testInfo) {
        this.page = page;
        this.testInfo = testInfo;
    }

    async waitForVisible(locator, timeout) {
        const startTime = Date.now();
        while (Date.now() - startTime < timeout) {
            try {
                if (locator.isVisible()) {
                    return;
                }
            } catch (err) {

            }
            await new Promise(resolve => setTimeout(resolve, 100)); //Set to poll after 100 millisec
        }
        throw new Error("Element not visible within the specified timeout provided");
    }

    async scroll(locator, message) {
        console.log(message);
        try {
            const timeout = 5000; //Time out value in millisec
            await this.waitForVisible(locator, timeout); //Wait for the element to become visible
            const element = await locator.evaluateHandle((el) => el); //Get the element handle
            await element.scrollIntoViewIfNeeded(); //scroll the element            
        } catch (err) {
            console.log("Error occured while scrolling to the object");
        }
    }

    async clickOnObject(locator, message) {
        console.log(message);
        try {
            const timeout = 5000; //Time out value in millisec
            await this.waitForVisible(locator, timeout); //Wait for the element to become visible
            // const element = await locator.evaluateHandle((el) => el); //Get the element handle
            await locator.click({ force: true });
        } catch (err) {
            console.log("Error occured while clicking on the object");
        }
    }

    async fillObject(locator, value, message) {
        console.log(message);
        try {
            await locator.waitFor();
            this.clickOnObject(locator, message);
            await locator.waitFor();
            await locator.fill(value, { force: true });
        } catch (err) {
            console.log("Error occured while filling text into the object", err);
        }
    }

    /**
            This functions is used to hover on  the element
            @param -locator
            @param -message
        */
    async hoverOnObject(locator, message) {
        try {
            await locator.waitFor();
            await locator.hover();
            log.info(`${message} is hovered successfully`);
        } catch (err) {
            console.error("Error occurred while hovering over the object", err);
        }
    }

    async isEnabled(locator, message) {
        try {
            await locator.waitFor();
            await locator.isEnabled();
            log.info(`${message} is enabled`);
        } catch (err) {
            console.error("Error occurred while checking if the element is enabled", err);
        }
    }

    async isDisabled(locator, message) {
        try {
            await locator.waitFor();
            await locator.isEnabled();
            log.info(`${message} is disabled`);
        } catch (err) {
            console.error("Error occurred while checking if the element is disabled", err);
        }
    }

    /**
         This functions is used to clear the text
         @param -locator (field name)
         @param -message
     */
    async clearText(locator, message) {
        try {
            await locator.waitFor({ state: 'visible' }); // Wait for the locator element to be visible
            await this.clickOnObject(locator, message); // Click on the locator element
            await locator.fill(''); // Clear the text by filling an empty value
            log.info(message + ' text is cleared');
        } catch (err) {
            console.error('Error occurred while clearing the text', err);
        }
    }

    async getText(locator) {
        try {
            await locator.waitFor();
            this.hoverOnObject(locator, message);
            await locator.getText();
            log.info(`Text obtained from ${locator} successfully`);
        } catch (err) {
            console.error("Error occurred while getting the text", err);
        }
    }

    async getAttribute(locator, attrName) {
        try {
            await locator.waitFor();
            await locator.getAttribute(attrName);
            log.info(`Attribute obtained from ${locator} successfully`);
        } catch (err) {
            console.error("Error occurred while getting the attribute", err);
        }
    }

    async scrollIntoViewElement(locator, message) {
        try {
            await page.scrollTo(0, 0);
            await page.scrollIntoView(locator);
            log.info(`${message} element is scrolled into view successfully`);
        } catch (err) {
            console.error("Error occurred while scrolling the element into view", err);
        }
    }

    async keyboardActions(buttonName) {
        try {
            await this.page.keyboard.press(buttonName);
            log.info(`Keyboard action "${buttonName}" performed successfully`);
        } catch (err) {
            console.error("Error occurred while performing keyboard action", err);
        }
    }

    async keyboardActionsOnLocator(buttonName, locator) {
        try {
            await locator.waitFor();
            this.hoverOnObject(locator);
            await locator.press(buttonName)
            log.info(`Keyboard action "${buttonName}" on locator performed successfully`);
        } catch (err) {
            console.error("Error occurred while performing keyboard action", err);
        }
    }

    async uploadImage(locator, filePathData) {
        try {
            const fileChooserPromise = this.page.waitForEvent('filechooser');
            await locator.click();
            const fileChooser = await fileChooserPromise;
            await fileChooser.setFiles(filePathData);
            log.info(`Uploaded image with value successfully`);
        } catch (err) {
            console.error("Error occurred while uploading the image", err);
        }
    }

    async isCheckboxChecked(locator) {
        try {
            const isChecked = await page.$eval(locator, input => locator.checked);
            console.info(`Checkbox is checked`);
            return isChecked;
        } catch (err) {
            console.error("Error occurred while checking if the checkbox is checked", err);
        }
    }

    async waitForTime(locator, message) {
        try {
            await locator.waitFor({ timeout: 1800000 });
            log.info(`${message} element waited successfully`);
        } catch (err) {
            console.error("Timeout occurred while waiting for element", err);
        }
    }

    async selectDropdownOption(locator, value, message) {
        try {
            await page.locator().selectOption(value);
            console.info(`${message} selected option "${value}" from ${locator} successfully`);
        } catch (err) {
            console.error("Error occurred while selecting the dropdown option", err);
        }
    }

    async reloadPageWhenSelectorVisible(page, locator) {
        try {
            await locator.waitFor({ state: 'visible' });
            await page.reload();
            console.info('Page reloaded successfully');
        } catch (err) {
            console.error(err);
            console.log('Page reload failed', err);
        }
    }

}