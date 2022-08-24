namespace SwagLabsWithSpecFlow.StepDefinitions
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
            Utils.Utils.loadPage();
        }

        [AfterScenario]
        [Obsolete]
        public void tearDown()
        {
            Utils.Utils.print(_scenarioContext.ScenarioInfo.Title);
            Utils.Utils.gerarRelatorio();
            Utils.Utils.close();
        }
    }
}
