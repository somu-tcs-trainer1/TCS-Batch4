using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace PlaywrightDemo.Tests
{
    [TestFixture]
    // Sequential Execution: Disables parallel run for this specific class
    [NonParallelizable] 
    public class AdvancedPlaywrightDemo : PageTest
    {
        // --- 1. DATA DRIVEN FROM JSON ---
        // Reads "testdata.json" and yields test cases to the [TestCaseSource]
        public static IEnumerable<TestCaseData> JsonTestData()
        {
            var json = File.ReadAllText("12c UseInAnnotation.json");
            var data = JsonSerializer.Deserialize<List<TestDataModel>>(json)!;
            foreach (var item in data)
            {
                yield return new TestCaseData(item.Url, item.ExpectedHeader)
                    .SetName($"Verify_{item.Name}");
            }
        }

        [Test, Order(1)] // Prioritization: Lower numbers run first
        [Category("Smoke")]
        [Description("Highest priority test to check environment health")]
        [TestCaseSource(nameof(JsonTestData))]
        public async Task DataDrivenTest(string url, string expectedHeader)
        {
            await Page.GotoAsync(url);
            var header = Page.Locator("h1");
            
            // --- NUNIT ASSERTIONS ---
            // NUnit Constraint Model (Classic)
            Assert.That(await header.InnerTextAsync(), Is.EqualTo(expectedHeader));
            // Multi-assertion (keeps running even if one fails)
            Assert.Multiple(() => {
                Assert.That(Page.Url, Does.Contain("http"));
                ClassicAssert.IsNotNull(Page.Context);
            });
        }

        [Test, Order(2), CancelAfter(10_000)]
        // [Timeout(10000)] // Timeout: Fails test if it exceeds 10 seconds
        public async Task TimeoutAndWebAssertionsTest()
        {
            await Page.GotoAsync("https://playwright.dev");
            
            // --- PLAYWRIGHT WEB-FIRST ASSERTIONS (Auto-retrying) ---
            await Expect(Page.GetByRole(AriaRole.Link, new() { Name = "Get started" })).ToBeVisibleAsync();
            await Expect(Page).ToHaveURLAsync(new Regex(".*playwright.dev"));
            
            // Soft Assertion: Test continues even if this fails
            await Expect(Page.Locator(".navbar")).ToHaveClassAsync(new Regex("navbar--fixed-top"));
        }

        [Test, Order(3)]
        [MaxTime(2000)] // MaxTime: Reports failure if test is slow but doesn't kill it
        public async Task PerformanceCheckTest()
        {
            await Page.GotoAsync("https://example.com");
            // Standard NUnit boolean assertion
            ClassicAssert.IsTrue(await Page.Locator("h1").IsVisibleAsync());
        }
    }

    public class TestDataModel { 
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? ExpectedHeader { get; set; }
    }
}
