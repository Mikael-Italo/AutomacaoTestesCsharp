namespace SwagLabsWithSpecFlow
{
    [Binding]
    public class Hooks : Utils
    {
        private ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void setUp()
        {
            loadPage();
        }

        [AfterScenario]
        [Obsolete]
        public void tearDown()
        {
            print(_scenarioContext.ScenarioInfo.Title);
            gerarRelatorio();
            close();
        }
    }
}
