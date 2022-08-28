Feature: Login


@LoginComSucesso
Scenario: Login_com_sucesso 
![LoginComSucesso](../TestResultsLivingDoc/Screen/Login_com_sucesso.png)
	Given que o usuario esteja na pagina de login
	And inserir o usuario como "standard_user"
	And inserir a senha como "secret_sauce"
	When clicar no botao login
	Then o usuario acessa a tela inicial do site


@LoginInvalido
Scenario: Login_Invalido
![LoginInvalido](../TestResultsLivingDoc/Screen/Login_Invalido.png)
	Given que o usuario esteja na pagina de login
	And inserir o usuario como "invalido"
	And inserir a senha como "invalido123"
	When clicar no botao login
	Then deve-se exibir a mensagem informando Login Invalido