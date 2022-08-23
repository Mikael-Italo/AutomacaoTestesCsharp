using OpenQA.Selenium;

namespace SwagLabsWithSpecFlow.StepDefinitions
{
    [Binding]
    public class Hooks
    {

        [BeforeScenario]
        public void setUp()
        {
            Utils.Utils.loadPage();
        }

        [AfterScenario]
        public void tearDown()
        {
            Utils.Utils.close();
        }
    }
}
