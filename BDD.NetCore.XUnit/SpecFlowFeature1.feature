Funcionalidade: Operacoes em Conta Corre
	Uma conta corrente passa por diversas operações envolvendo transações financeiras

@TestesAceitacaoContaCorrent

Cenário: Deposito em Conta
	Dado Uma conta corrente
	E que esteja ativa
	Quando For realizado o deposito de um valor
	       | Valor |
	       | 500   |
	Então O saldo disponivel deve ser o saldo atual mais o valor depositado
	E Deve retornar uma transacao com um numero de identificacao