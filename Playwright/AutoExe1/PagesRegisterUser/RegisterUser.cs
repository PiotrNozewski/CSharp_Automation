using Microsoft.Playwright;

namespace AutoExe1.Pages;

public class RegisterUser
{ 
    private IPage _page;
    public RegisterUser(IPage page) => _page = page;
    private ILocator HomePage => _page.Locator("div[class='item active'] img[alt='demo website for practice']");
    private ILocator SignupLoginLink => _page.Locator("a[href='/login']");
    private ILocator NewUserSignup => _page.Locator("div[class='signup-form'] h2");
    private ILocator RegisterUsernameTxt => _page.Locator("input[placeholder='Name']");
    private ILocator RegisterPasswordTxt => _page.Locator("input[data-qa='signup-email']");
    private ILocator SignupBtn => _page.Locator("button[data-qa='signup-button']");
    private ILocator EnterAccountInformation => _page.Locator("//b[normalize-space()='Enter Account Information']");
    private ILocator MrBtn => _page.Locator("//input[@id='id_gender1']");
    private ILocator NameTxT => _page.Locator("#name");
    private ILocator PasswordTxt => _page.Locator("#password");
    private ILocator DOBD => _page.Locator("#days");
    private ILocator DOBM => _page.Locator("#months");
    private ILocator DOBY => _page.Locator("#years");
    private ILocator Newsletter => _page.Locator("#newsletter");
    private ILocator SpecialOffers => _page.Locator("#optin");
    private ILocator FirstNameTxt => _page.Locator("#first_name");
    private ILocator LastNameTxt => _page.Locator("#last_name");
    private ILocator CompanyTxt =>   _page.Locator("#company");
    private ILocator AddressTxt =>_page.Locator("#address1");
    private ILocator Address2Txt =>   _page.Locator("#address2");
    private ILocator StateTxt => _page.Locator("#state");
    private ILocator CityTxt => _page.Locator("#city");
    private ILocator ZipcodeTxt => _page.Locator("#zipcode");
    private ILocator MobileNumberTxt => _page.Locator("#mobile_number");
    private ILocator CreateAccountBtn => _page.Locator("button[data-qa='create-account']");
    private ILocator AccountCreated => _page.Locator("h2[class='title text-center'] b");
    private ILocator ContinueBtn => _page.Locator(".btn.btn-primary");
    private ILocator LoggedInAsUsername => _page.Locator("li:nth-child(10) a:nth-child(1)");
    private ILocator DeleteAccountLink => _page.Locator("a[href='/delete_account']");
    private ILocator AccountDeleted => _page.Locator("h2[class='title text-center'] b");
    public async Task<bool> IsHomePageExist() => await HomePage.IsVisibleAsync();
    public async Task ClickSignupLogin() => await SignupLoginLink.ClickAsync();
    public async Task<bool> IsNewUserSignupExist() => await NewUserSignup.IsVisibleAsync();
    public async Task Signup(string username, string  email)
    {
        await RegisterUsernameTxt.FillAsync(username);
        await RegisterPasswordTxt.FillAsync(email);
        await SignupBtn.ClickAsync();
    }
    public async Task<bool> IsEnterAccountInformationExist() => await EnterAccountInformation.IsVisibleAsync();
    public async Task ClickMr() => await MrBtn.ClickAsync();
    public async Task AccountAddressInformationForm(string name, string password, string dobd, string dobm, string doby, string firstName, string lastName,
        string company, string address, string address2, string state, string city, string zipcode, string mobileNumber)
    {
        await NameTxT.FillAsync(name);
        await PasswordTxt.FillAsync(password);
        await DOBD.ClickAsync();
        await DOBM.ClickAsync();
        await DOBY.ClickAsync();
        await Newsletter.ClickAsync();
        await SpecialOffers.ClickAsync();
        await FirstNameTxt.FillAsync(firstName);
        await LastNameTxt.FillAsync(lastName);
        await CompanyTxt.FillAsync(company);
        await AddressTxt.FillAsync(address);
        await Address2Txt.FillAsync(address2);
        await StateTxt.FillAsync(state);
        await CityTxt.FillAsync(city);
        await ZipcodeTxt.FillAsync(zipcode);
        await MobileNumberTxt.FillAsync(mobileNumber);
        await CreateAccountBtn.ClickAsync();
    }
    public async Task<bool> IsAccountCreatedExist() => await AccountCreated.IsVisibleAsync();
    public async Task ClickContinue() => await ContinueBtn.ClickAsync();
    public async Task<bool> IsLoggedInAsUsernameExist() => await LoggedInAsUsername.IsVisibleAsync();
    public async Task DeleteAccount() => await DeleteAccountLink.ClickAsync();
    public async Task<bool> IsAccountDeletedExist() => await AccountDeleted.IsVisibleAsync();
    public async Task ClickContinue2() => await ContinueBtn.ClickAsync();
}