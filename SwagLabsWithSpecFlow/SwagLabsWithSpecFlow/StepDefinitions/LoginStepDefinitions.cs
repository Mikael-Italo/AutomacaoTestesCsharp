namespace SwagLabsWithSpecFlow.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private LoginPage? lp;

        [Given(@"que o usuario esteja na pagina de login")]
        public void GivenQueOUsuarioEstejaNaPaginaDeLogin()
        {
            lp = new LoginPage();
        }

        [Given(@"inserir o usuario como ""([^""]*)""")]
        public void GivenInserirOUsuarioComo(string p0)
        {
            lp!.sendUsername(p0);
        }

        [Given(@"inserir a senha como ""([^""]*)""")]
        public void GivenInserirASenhaComo(string p0)
        {
            lp!.sendPassword(p0);
        }

        [When(@"clicar no botao login")]
        public void WhenClicarNoBotaoLogin()
        {
            lp!.clickLogin();
        }

        [Then(@"o usuario acessa a tela inicial do site")]
        public void ThenOUsuarioAcessaATelaInicialDoSite()
        {
            lp!.validationLoginSucess();
        }
    }
}
