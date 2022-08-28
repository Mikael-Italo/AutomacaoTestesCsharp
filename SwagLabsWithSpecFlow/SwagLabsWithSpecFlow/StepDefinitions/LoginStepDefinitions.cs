namespace SwagLabsWithSpecFlow
{
    [Binding]
    public class LoginStepDefinitions
    {
        private LoginPage? lp;

//Login_com_sucesso
        [Given(@"que o usuario esteja na pagina de login")]
        public void GivenQueOUsuarioEstejaNaPaginaDeLogin()
        {
            lp = new LoginPage(Utils.driver!);
            Utils.wait(3);
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

//Login invalido
        [Then(@"deve-se exibir a mensagem informando Login Invalido")]
        public void ThenDeve_SeExibirAMensagemInformandoLoginInvalido()
        {
            lp!.validationLoginInvalid();
        }

    }
}
