using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs
{
    internal class Utils
    {

        #region Browser

        public static IWebDriver getBrowserLocal(IWebDriver driver, String browser)
        {
            switch (browser)
            {
                case "Internet Explorer":
                    driver = new OpenQA.Selenium.IE.InternetExplorerDriver();
                    driver.Manage().Window.Maximize();
                    break;

                case "Chrome":
                    driver = new OpenQA.Selenium.Chrome.ChromeDriver();
                    driver.Manage().Window.Maximize();
                    break;

                default:
                    driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    break ;

            }
            return driver;
        }


        public static IWebDriver getBrowserRemote(IWebDriver driver, String uri)
        {
            FirefoxOptions cap_firefox = new FirefoxOptions();
            //ChromeOptions cap_chrome = new ChromeOptions();
            driver = new RemoteWebDriver(new Uri(uri), cap_firefox);

            return driver;
        }

        #endregion


        #region JavaScript
        public static void executeJS(IWebDriver driver, String script)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
            js.ExecuteScript(script);
        }
        #endregion

        #region Espera
        public void EsperaExplicita(IWebDriver driver, String Xpath)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(Xpath)));
        }
        #endregion
    }
}
