using Microsoft.Playwright;
using System;

public class PageFactory
{
    private readonly IPage _page;

    public PageFactory(IPage _page) => this._page = _page;

    /// <summary>
    /// Automatically creates any page class that has a constructor accepting IPage.
    /// </summary>
    public T Create<T>() where T : class
    {
        // Dynamically calls the constructor: new T(page)
        return (T)Activator.CreateInstance(typeof(T), _page)!;
    }

    // public String method1()
    // {
    //     return;
    // }
}




// using System.Threading.Tasks;
// using Microsoft.Playwright;

// public class PageFactory
// {
//     private readonly IPage _page;

//     public PageFactory(IPage page) => _page = page;

//     // Returns the specific page instance
//     public T Create<T>() where T : class
//     {
//         return typeof(T) switch
//         {
//             Type t when t == typeof(TodoPage) => new TodoPage(_page) as T,
//             Type t when t == typeof(AutomationSitePage) => new AutomationSitePage(_page) as T,
//             _ => throw new ArgumentException($"Page type {typeof(T).Name} is not supported.")
//         };
//     }
// }

