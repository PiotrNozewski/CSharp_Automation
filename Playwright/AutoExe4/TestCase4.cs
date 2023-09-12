using AutoExe4.Pages;
using Microsoft.Playwright.NUnit;

namespace AutoExe4;

public class Tests : PageTest
{
    [Test]
    public async Task MyTest()
    {
        var page = await Browser.NewPageAsync();

        LogoutUser logoutUser = new LogoutUser(page);
        
        await page.GotoAsync("https://automationexercise.com/");

        var isExist0 = await logoutUser.IsHomePageExist();
        Assert.IsTrue(isExist0);

        await logoutUser.ClickSignupLogin();

        var IsExist1 = await logoutUser.IsLoginToYourAccountExist();
        Assert.IsTrue(IsExist1);

        await logoutUser.Login("pionoz@gmail.com", "qwe123");

        var isExist2 = await logoutUser.IsLoggedInAsUsernameExist();
        Assert.IsTrue(isExist2);

        await logoutUser.ClickLogout();

        var IsExist3= await logoutUser.IsLoginToYourAccount2Exist();
        Assert.IsTrue(IsExist3);


    }
}