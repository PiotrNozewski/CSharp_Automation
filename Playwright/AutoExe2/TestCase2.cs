using AutoExe2.Pages;
using Microsoft.Playwright.NUnit;

namespace AutoExe2;

public class Tests : PageTest
{
    [Test]
    public async Task MyTest()
    {
        var page = await Browser.NewPageAsync();

        LoginUserWithCorrectDetails loginUserWithCorrectDetails =
            new LoginUserWithCorrectDetails(page);
        
        await page.GotoAsync("https://automationexercise.com/");

        var isExist0 = await loginUserWithCorrectDetails.IsHomePageExist();
        Assert.IsTrue(isExist0);

        await loginUserWithCorrectDetails.ClickSignupLogin();

        var IsExist1 = await loginUserWithCorrectDetails.IsLoginToYourAccountExist();
        Assert.IsTrue(IsExist1);

        await loginUserWithCorrectDetails.Login("pionoz@gmail.com", "qwe123");

        var isExist2 = await loginUserWithCorrectDetails.IsLoggedInAsUsernameExist();
        Assert.IsTrue(isExist2);
        
    }
}