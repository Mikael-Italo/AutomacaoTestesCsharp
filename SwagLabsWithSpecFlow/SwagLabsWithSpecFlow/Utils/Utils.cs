using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SwagLabsWithSpecFlow.Utils
{
    public class Utils
    {
        public static IWebDriver? driver;

        #region DriverUpDown
        public static void loadPage()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            driver = new ChromeDriver(options);

            driver!.Manage().Window.Maximize();
            driver!.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            driver!.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver!.Navigate().GoToUrl("https://www.saucedemo.com/"); 
        }

        public static void close()
        {
            driver!.Quit();    
        }
        #endregion

        #region Metodos Utils
        public static void waitElement(String xpathElement)
        {
            WebDriverWait wait = new WebDriverWait(driver!, TimeSpan.FromSeconds(10));
            wait.Until((d) => d.FindElement(By.XPath(xpathElement)) != null);
        }
        #endregion
    }
}


