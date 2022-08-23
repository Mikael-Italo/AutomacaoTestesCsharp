using OpenQA.Selenium;

namespace SwagLabsWithSpecFlow.PageObjects
{
    internal class LoginPage
    {
        private IWebDriver driver = Utils.Utils.driver!;
        public LoginPage(){}

        //Mapeamento
        protected IWebElement inputUsername => driver.FindElement(By.XPath("//input[contains(@id,'user-name')]"));
        protected IWebElement inputPassword => driver.FindElement(By.XPath("//input[contains(@id,'password')]"));
        protected IWebElement btnLogin => driver.FindElement(By.XPath("//input[contains(@id,'login-button')]"));
        protected IWebElement divAppLogo => driver.FindElement(By.XPath("//div[contains(@class,'app_logo')]"));


        //Ação
        public void sendUsername(String username) => inputUsername.SendKeys(username);

        public void sendPassword(String password) => inputPassword.SendKeys(password);

        public void clickLogin() => btnLogin.Click();
        //Validção

        public void validationLoginSucess() => divAppLogo.Displayed.Should().BeTrue();
    }
}
