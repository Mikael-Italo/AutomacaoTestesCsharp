namespace SwagLabsWithSpecFlow.PageObjects
{
    public class BasePage
    {
        private IWebDriver driver = Utils.Utils.driver!;

        protected IWebElement inputUsername => driver.FindElement(By.XPath("//input[contains(@id,'user-name')]"));
        protected IWebElement inputPassword => driver.FindElement(By.XPath("//input[contains(@id,'password')]"));






    }
}
