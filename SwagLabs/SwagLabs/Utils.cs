using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
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

        public static RemoteWebDriver getBrowserLocal(RemoteWebDriver driver, String browser)
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


        public static RemoteWebDriver getBrowserRemote(RemoteWebDriver driver)
        {
            FirefoxOptions cap_firefox = new FirefoxOptions();
            //ChromeOptions cap_chrome = new ChromeOptions();
            driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4444/wd/hub"), cap_firefox);

            return driver;
        }

        public static RemoteWebDriver getBrowserMobile(RemoteWebDriver driver)
        {
            DesiredCapabilities cap_android= new DesiredCapabilities();
            cap_android.SetCapability("deviceName","emulator-5554");
            cap_android.SetCapability("browserName", "Chrome");
            driver = new AndroidDriver<IWebElement>(new Uri("http://localhost:4723/wd/hub"), cap_android);

            return driver;
        }
        #endregion


        #region JavaScript
        public static void executeJS(RemoteWebDriver driver, String script)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
            js.ExecuteScript(script);
        }
        #endregion
    }
}
