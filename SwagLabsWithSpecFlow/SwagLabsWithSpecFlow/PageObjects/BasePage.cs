namespace SwagLabsWithSpecFlow
{
    public class BasePage
    {
        private IWebDriver _driver;
        public BasePage(IWebDriver driver) => _driver = driver;

        protected IWebElement inputUsername => _driver.FindElement(By.XPath("//input[contains(@id,'user-name')]"));
        protected IWebElement inputPassword => _driver.FindElement(By.XPath("//input[contains(@id,'password')]"));
        protected IWebElement btnLogin => _driver.FindElement(By.XPath("//input[contains(@id,'login-button')]"));
        protected IWebElement divAppLogo => _driver.FindElement(By.XPath("//div[contains(@class,'app_logo')]"));
        protected IWebElement h3error => _driver.FindElement(By.XPath("//h3[contains(@data-test,'error')]"));





    }
}
