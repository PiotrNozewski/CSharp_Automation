using Microsoft.Playwright;
using NUnit.Framework.Internal;

namespace AutoExe6.Pages;

public class ContactUsForm
{
    private IPage _page;
    public ContactUsForm(IPage page) => _page = page;
    private ILocator HomePage => _page.Locator("div[class='item active'] img[alt='demo website for practice']");
    private ILocator ContactUsLink => _page.Locator("a[href='/contact_us']");
    private ILocator GetInTouch => _page.Locator("div[class='contact-form'] h2[class='title text-center']");
    private ILocator NameTxt => _page.Locator("input[placeholder='Name']");
    private ILocator EmailTxt => _page.Locator("input[placeholder='Email']");
    private ILocator SubjectTxt => _page.Locator("input[placeholder='Subject']");
    private ILocator SubmitBtn => _page.Locator("input[value='Submit']");
    
    public async Task<bool> IsHomePageExist() => await HomePage.IsVisibleAsync();
    public async Task ClickContactUs() => await ContactUsLink.ClickAsync();
    public async Task<bool> IsGetInTouchExist() => await GetInTouch.IsVisibleAsync();
    public async Task GetInTouchForm(string name, string email, string subject)
    {
        await NameTxt.FillAsync(name);
        await EmailTxt.FillAsync(email);
        await SubjectTxt.FillAsync(subject);
        await SubmitBtn.ClickAsync();
    }
   
    




}