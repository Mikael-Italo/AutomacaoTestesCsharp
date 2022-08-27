namespace SwagLabsWithSpecFlow
{
    [Binding]
    public class Hooks
    {
        private ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void setUp()
        {
            Utils.loadPage();
        }

        [AfterScenario]
        [Obsolete]
        public void tearDown()
        {
            Utils.print(_scenarioContext.ScenarioInfo.Title);
            Utils.gerarRelatorio();
            Utils.close();
        }
    }
}
