using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;

namespace PlaywrightTests
{
    [TestFixture]
    public class PageFactoryTest : PageTest
    {
        [Test]
        public async Task FactoryTest()
        {
            var factory = new PageFactory(Page);

            // Get TodoPage from factory
            var todoPage = factory.Create<TodoPage>();
            await todoPage.GotoAsync();
            await todoPage.AddToDoAsync("Learn Playwright .NET");

            // Get AutomationSitePage from factory
            var autoPage = factory.Create<AutomationSitePage>();
            await autoPage.Launch();
            await autoPage.FillBasicForm("John Doe", "john@example.com", "1234567890");
        }
    }
}