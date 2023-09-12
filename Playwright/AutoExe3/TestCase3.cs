using AutoExe3.Pages;
using Microsoft.Playwright.NUnit;

namespace AutoExe3;

public class Tests : PageTest
{
    [Test]
    public async Task MyTest()
    {
        var page = await Browser.NewPageAsync();

        LoginUserWithIncorrectDetails loginUserWithIncorrectDetails = new LoginUserWithIncorrectDetails(page);

        await page.GotoAsync("https://automationexercise.com/");

        var isExist0 = await loginUserWithIncorrectDetails.IsHomePageExist();
        Assert.IsTrue(isExist0);

        await loginUserWithIncorrectDetails.ClickSignupLogin();

        var isExist1 = await loginUserWithIncorrectDetails.IsLoginToYourAccountExist();
        Assert.IsTrue(isExist1);

        await loginUserWithIncorrectDetails.Login("pn@gmail.com", "qwe1234");

        var isExist2 = await loginUserWithIncorrectDetails.IsYourEmailOrPasswordIsIncorrectExist();
        Assert.IsTrue(isExist2);
        }
}