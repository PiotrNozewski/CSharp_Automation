using Microsoft.Playwright;

namespace AutoExe5.Pages;

public class RegisterUserWithExistingMail
{
    private IPage _page;
    public RegisterUserWithExistingMail(IPage page) => _page = page;
    private ILocator HomePage => _page.Locator("div[class='item active'] img[alt='demo website for practice']");
    private ILocator SignupLoginLink => _page.Locator("a[href='/login']");
    private ILocator NewUserSignup => _page.Locator("div[class='signup-form'] h2");
    private ILocator RegisterUsernameTxt => _page.Locator("input[placeholder='Name']");
    private ILocator RegisterPasswordTxt => _page.Locator("input[data-qa='signup-email']");
    private ILocator SignupButton => _page.Locator("button[data-qa='signup-button']");

    private ILocator EmailAddressAlreadyExist => _page.Locator(
        "body > section:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1) > form:nth-child(2) > p:nth-child(5)");
    
    public async Task<bool> IsHomePageExist() => await HomePage.IsVisibleAsync();
    public async Task ClickSignupLogin() => await SignupLoginLink.ClickAsync();
    public async Task<bool> IsNewUserSignupExist() => await NewUserSignup.IsVisibleAsync();
    public async Task Signup(string username, string  email)
    {
        await RegisterUsernameTxt.FillAsync(username);
        await RegisterPasswordTxt.FillAsync(email);
        await SignupButton.ClickAsync();
    }
    public async Task<bool> IsEmailAddressAlreadyExistExist() => await EmailAddressAlreadyExist.IsVisibleAsync();
}