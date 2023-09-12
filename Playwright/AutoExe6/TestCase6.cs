using AutoExe6.Pages;
using Microsoft.Playwright.NUnit;


namespace AutoExe6;

public class Tests : PageTest
{
    [Test]
    public async Task MyTest()
    {
        var page = await Browser.NewPageAsync();

        ContactUsForm contactUsForm = new ContactUsForm(page);

        await page.GotoAsync("https://automationexercise.com/");

        var isHomePageExist = await contactUsForm.IsHomePageExist();
        Assert.IsTrue(isHomePageExist);

        await contactUsForm.ClickContactUs();

        var isGetInTouchExist = await contactUsForm.IsGetInTouchExist();
        Assert.IsTrue(isGetInTouchExist);

        await contactUsForm.GetInTouchForm("Piotr", "pionoz@gmail.com", "problem");
      
        
        
        
        
        
   
    }
}