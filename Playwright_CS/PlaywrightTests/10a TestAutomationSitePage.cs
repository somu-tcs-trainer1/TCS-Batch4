using System.Threading.Tasks;
using Microsoft.Playwright;

public class AutomationSitePage
{
    private readonly IPage _page;
    private readonly ILocator? _nameTxtbox;
    private readonly ILocator? _emailTxtbox;
    private readonly ILocator? _phoneTxtbox;


    public AutomationSitePage(IPage page)
    {
        _page = page;
        _nameTxtbox = page.GetByPlaceholder("Enter Name");
        _emailTxtbox = page.Locator("#email");
        _phoneTxtbox = page.GetByRole(AriaRole.Textbox, new() { Name = "Phone" });
    }

    public async Task Launch()
    {
        await _page.GotoAsync("https://testautomationpractice.blogspot.com/");
    }

    public async Task FillBasicForm(String name, String email, String phone)
    {
        await _nameTxtbox.ClearAsync();
        await _nameTxtbox.FillAsync(name);
        await _emailTxtbox.ClearAsync();
        await _emailTxtbox.FillAsync(email);
        await _phoneTxtbox.ClearAsync();
        await _phoneTxtbox.FillAsync(phone);        
    }
}