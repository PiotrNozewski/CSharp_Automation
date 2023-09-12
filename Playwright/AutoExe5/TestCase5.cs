using AutoExe5.Pages;
using Microsoft.Playwright.NUnit;

namespace AutoExe5;

public class Tests : PageTest
{
    [Test]
    public async Task MyTest()
    {
        var page = await Browser.NewPageAsync();

        RegisterUserWithExistingMail registerUserWithExistingMail = new RegisterUserWithExistingMail(page);

        await page.GotoAsync("https://automationexercise.com/");

        var isExist0 = await registerUserWithExistingMail.IsHomePageExist();
        Assert.IsTrue(isExist0);

        await registerUserWithExistingMail.ClickSignupLogin();

        var isExist1 = await registerUserWithExistingMail.IsNewUserSignupExist();
        Assert.IsTrue(isExist1);

        await registerUserWithExistingMail.Signup("Piotr", "pionoz@gmail.com");

        var isExist2 = await registerUserWithExistingMail.IsEmailAddressAlreadyExistExist();
        Assert.IsTrue(isExist2);
    }
}