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

        public static void print(String title)
        {
            ((ITakesScreenshot)driver!).
                GetScreenshot().
                SaveAsFile(@"C:\Users\SSD DESKTOP\Documents\Visual Studio 2022\Projects\SwagLabsWithSpecFlow\SwagLabsWithSpecFlow\TestResultsLivingDoc\Screen\" + title + ".png",
                ScreenshotImageFormat.Png);
        }

        public static void gerarRelatorio()
        {
            System.Diagnostics.Process.Start(@"C:\Users\SSD DESKTOP\Documents\Visual Studio 2022\Projects\SwagLabsWithSpecFlow\SwagLabsWithSpecFlow\TestResultsLivingDoc\comando.bat");
        }
        #endregion
    }
}


