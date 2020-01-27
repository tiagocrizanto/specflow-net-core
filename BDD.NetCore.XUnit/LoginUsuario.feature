Funcionalidade: Login de usuário
	dado que um usuário loga no sistema X e é um usuário válio

@TestesAceitacaoContaCorrente

Cenário: Login usuario valido
	Dado Dado um usuario
	E que esteja ativo
	Quando Informa o usuario e senha
	       | Usuario | Senha |
	       | user    | 1234  |
	Então O usuario esta autorizado a acessar o sistema

Cenário: Login usuario senha invalida
	Dado Dado um usuario
	E que esteja ativo
	Quando Informa o usuario e senha
	       | Usuario | Senha |
	       | user    | abcd  |
	Então O usuario nao esta autorizado a acessar o sistema