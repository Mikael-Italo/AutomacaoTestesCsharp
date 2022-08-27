namespace SwagLabsWithSpecFlow.PageObjects
{
    internal class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver){ }

        //Ação
        public void sendUsername(String username) => inputUsername.SendKeys(username);

        public void sendPassword(String password) => inputPassword.SendKeys(password);

        public void clickLogin() => btnLogin.Click();
        
        //Validação
        public void validationLoginSucess() => divAppLogo.Displayed.Should().BeTrue();

        public void validationLoginInvalid() => (Equals(h3error.Text, "Epic sadface: Username and password do not match any user in this service")).Should().BeTrue();
    }
}
