﻿Feature: Login


@LoginComSuceso
Scenario: Realizar com sucesso o Login 
	Given que o usuario esteja na pagina de login
	And inserir o usuario como "standard_user"
	And inserir a senha como "secret_sauce"
	When clicar no botao login
	Then o usuario acessa a tela inicial do site