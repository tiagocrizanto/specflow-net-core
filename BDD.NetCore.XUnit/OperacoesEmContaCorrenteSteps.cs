using BDD.NetCore.XUnit.Domain;
using BDD.NetCore.XUnit.Domain.ValueObjects;
using System;
using TechTalk.SpecFlow;
using Xunit;
using static BDD.NetCore.XUnit.Domain.ContaCorrente;

namespace BDD.NetCore.XUnit
{
    [Binding]
    public class OperacoesEmContaCorrenteSteps
    {
        public ContaCorrente Conta;
        public decimal SaldoInicial;
        public decimal Deposito;
        public RetornoTransacao RetornoTransacao;

        public OperacoesEmContaCorrenteSteps()
        {
            Conta = ContaCorrenteFactory.NovaContaCorrente(Guid.NewGuid(), "0001234", true);
        }

        [Given(@"Uma conta corrente")]
        public void DadoUmaContaCorrente()
        {
            Assert.True(Conta != null);
            SaldoInicial = Conta.ConsultarSaldo();
        }
        
        [Given(@"que esteja ativa")]
        public void DadoQueEstejaAtiva()
        {
            Assert.True(Conta.Ativa);
        }
        
        [When(@"For realizado o deposito de um valor")]
        public void QuandoForRealizadoODepositoDeUmValor(Table table)
        {
            Deposito = decimal.Parse(table.Rows[0][0]);
            RetornoTransacao = Conta.Depositar(Deposito);
        }
        
        [Then(@"O saldo disponivel deve ser o saldo atual mais o valor depositado")]
        public void EntaoOSaldoDisponivelDeveSerOSaldoAtualMaisOValorDepositado()
        {
            //O saldo inicial + o depósito deve ser igual ao saldo da sua conta
            Assert.Equal(SaldoInicial + Deposito, Conta.ConsultarSaldo());
        }
        
        [Then(@"Deve retornar uma transacao com um numero de identificacao")]
        public void EntaoDeveRetornarUmaTransacaoComUmNumeroDeIdentificacao()
        {
            Assert.True(RetornoTransacao.NumeroTransacao != null);
            Assert.True(RetornoTransacao.Retorno == RetornoTransacao.TipoRetorno.Sucesso);
        }


        //A diferença entre o teste unitário e este processo é que utilizando BDD você testa todo o processo
        //e não apenas um método específico.
        //Mas não seria redundante? No caso deste processo que é simples, sim. Porém em casos mais complexos pode
        //valer muito a pena.
    }
}
