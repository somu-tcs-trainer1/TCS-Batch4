using Microsoft.Playwright;

public class TodoPage
{
    private readonly IPage _page;
    private readonly ILocator _inputBox;
    private readonly ILocator _todoItems;

    public TodoPage(IPage page)
    {
        _page = page;
        _inputBox = _page.Locator("input.new-todo");
        _todoItems = _page.GetByTestId("todo-item");
    }

    public async Task GotoAsync() => await _page.GotoAsync("https://demo.playwright.dev/todomvc/");

    public async Task AddToDoAsync(string text)
    {
        await _inputBox.FillAsync(text);
        await _inputBox.PressAsync("Enter");
    }

    public async Task RemoveAsync(string text)
    {
        var todo = _todoItems.Filter(new() { HasText = text });
        await todo.HoverAsync();
        await todo.GetByLabel("Delete").ClickAsync();
    }
}
