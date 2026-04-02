using Microsoft.Playwright;
using System;
using System.Threading.Tasks;

namespace PlaywrightTests.Pages
{
    public class RegisterPage
    {
        private readonly IPage _page;

        public RegisterPage(IPage page)
        {
            _page = page;
        }

        // Helper for basic ID-based locators
        private ILocator CommonLocator(string id) => _page.Locator($"input#{id}");

        // Rewritten to use params object[] to mimic JS (...args)
        // This handles dynamic xpath generation from a variable number of inputs
        private ILocator CommonLocatorMultiple(params object[] args)
        {
            // Accessing args by index just like in your JS code:
            // args[0] = id, args[1] = spanIndex, args[2] = inputIndex
            return _page.Locator($"//div[@id='{args[0]}']/span[{args[1]}]/input[{args[2]}]");
        }

        private string CommonLocatorString(params object[] args)
        {
            return $"//div[@id='{args[0]}']/span[{args[1]}]/input[{args[2]}]";
        }

        // Properties calling the params methods
        public ILocator EmailTxtBox => CommonLocatorMultiple("MyID", 3, 1);
        public ILocator GenderMaleRadioBtn => CommonLocator("gender-male");
        public ILocator GenderFemaleRadioBtn => CommonLocator("gender-female");
        public ILocator FirstNameTxtBox => CommonLocator("FirstName");
        public ILocator LastNameTxtBox => CommonLocator("LastName");

        public async Task FillRegisterForm(string fname, string gender)
        {
            if (gender.ToLower() == "male")
            {
                await GenderMaleRadioBtn.ClickAsync();
            }
            else
            {
                await GenderFemaleRadioBtn.ClickAsync();
            }
            
            // Reusing helper logic directly
            await CommonLocator("FirstName").FillAsync(fname);
        }

        public void PrintMultipleCommonLocator()
        {
            // You can pass arguments individually; 'params' wraps them into the array for you
            Console.WriteLine(CommonLocatorString("MyID", 3, 1));
        }
    }
}
