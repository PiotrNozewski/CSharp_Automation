using AutoExe1.Pages;
using Microsoft.Playwright.NUnit;

namespace AutoExe1;

public class Tests : PageTest
{
    [Test]
    public async Task MyTest()
    {
        var page = await Browser.NewPageAsync();

        RegisterUser registerPage = new RegisterUser(page);

        await page.GotoAsync("https://automationexercise.com/");

        var isExist0 = await registerPage.IsHomePageExist();
        Assert.IsTrue(isExist0);

        await registerPage.ClickSignupLogin();

        var isExist1 = await registerPage.IsNewUserSignupExist();
        Assert.IsTrue(isExist1);

        await registerPage.Signup("Piotr", "pn@gmail.com");

        var isExist2 = await registerPage.IsEnterAccountInformationExist();
        Assert.IsTrue(isExist2);

        await registerPage.ClickMr();

        await registerPage.AccountAddressInformationForm("Piotrek", "qwe123", "16", "March", "1993", "Piotr",
            "Nozewski", "PowerChina", "Imagined", "One", "mazovian", "Warsaw", "03-226", "123456789");

        var isExist3 = await registerPage.IsAccountCreatedExist();
        Assert.IsTrue(isExist3);

        await registerPage.ClickContinue();

        var isExist4 = await registerPage.IsLoggedInAsUsernameExist();
        Assert.IsTrue(isExist4);

        await registerPage.DeleteAccount();

        var isExist5 = await registerPage.IsAccountDeletedExist();
        Assert.IsTrue(isExist5);
        
        await registerPage.ClickContinue2();
    }
}
