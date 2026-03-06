// using Microsoft.Playwright;
// using System;
// using System.Threading.Tasks;
// class Program
// {
//     // Synchronous entry point calls an async method
//     public static void Main()
//     {
//         Main1Async().GetAwaiter().GetResult();
//     }
//     // Your async code lives here
//     private static async Task Main1Async()
//     {
//         using var playwright = await Playwright.CreateAsync();
//         await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
//         {
//             Headless = false // set true for CI
//         });
//         var context = await browser.NewContextAsync();
//         var page = await context.NewPageAsync();
//         await page.GotoAsync("https://playwright.dev/dotnet/");
//         await page.ScreenshotAsync(new() { Path = "screenshot.png", FullPage = true });
//         Console.WriteLine("Done! Saved screenshot.png");
//     }
// }

// // using Microsoft.Playwright;
// // class Playwright1
// // {
// //     public static async Task Main(string[] args)
// //     {

// //         using var playwright = await Playwright.CreateAsync();
// //         await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
// //         {
// //             Headless = false // set true for CI
// //         });
// //         var context = await browser.NewContextAsync();
// //         var page = await context.NewPageAsync();
// //         await page.GotoAsync("https://playwright.dev/dotnet/");
// //         await page.ScreenshotAsync(new() { Path = "screenshot.png", FullPage = true });
// //         Console.WriteLine("Done! Saved screenshot.png");
// //     }
// // }

// // using System.Text.RegularExpressions;
// // using System.Threading.Tasks;
// // using Microsoft.Playwright;
// // // using Microsoft.Playwright.NUnit;
// // // using NUnit.Framework;
// // public class Playwright1
// // {
// //     static async Task Main(string[] args)
// //     {
// //         ExampleTest3 test3 = new ExampleTest3();
// //         await test3.HasTitle3();
// //         await test3.GetStartedLink3();
// //     }
// // }

// // public class ExampleTest3 : PageTest
// // {
// //     public async Task HasTitle3()
// //     {
// //         await Page.GotoAsync("https://playwright.dev");

// //         // Expect a title "to contain" a substring.
// //         await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));
// //     }

// //     public async Task GetStartedLink3()
// //     {
// //         await Page.GotoAsync("https://playwright.dev");

// //         // Click the get started link.
// //         await Page.GetByRole(AriaRole.Link, new() { Name = "Get started" }).ClickAsync();

// //         // Expects page to have a heading with the name of Installation.
// //         await Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "Installation" })).ToBeVisibleAsync();
// //     } 
// // }