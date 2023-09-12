using Microsoft.Playwright;

namespace AutoExe2.Pages;

public class LoginUserWithCorrectDetails
{
    private IPage _page;
    public LoginUserWithCorrectDetails(IPage page) => _page = page;
    private ILocator HomePage => _page.Locator("div[class='item active'] img[alt='demo website for practice']");
    private ILocator SignupLoginLink => _page.Locator("a[href='/login']");
    private ILocator LoginToYourAccount => _page.Locator("div[class='login-form'] h2");
    private ILocator LoginUsernameTxt => _page.Locator("input[data-qa='login-email']");
    private ILocator LoginPasswordTxt => _page.Locator("input[placeholder='Password']");
    private ILocator LoginButton => _page.Locator("button[data-qa='login-button']");
    private ILocator LoggedInAsUsername => _page.Locator("li:nth-child(10) a:nth-child(1)");
    public async Task<bool> IsHomePageExist() => await HomePage.IsVisibleAsync();
    public async Task ClickSignupLogin() => await SignupLoginLink.ClickAsync();
    public async Task<bool> IsLoginToYourAccountExist() => await LoginToYourAccount.IsVisibleAsync();
    public async Task Login(string email, string  password)
    {
        await LoginUsernameTxt.FillAsync(email);
        await LoginPasswordTxt.FillAsync(password);
        await LoginButton.ClickAsync();
    }
    public async Task<bool> IsLoggedInAsUsernameExist() => await LoggedInAsUsername.IsVisibleAsync();
}
    
    