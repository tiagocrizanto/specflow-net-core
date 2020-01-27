using BDD.NetCore.XUnit.Domain.ValueObjects;
using System;

namespace BDD.NetCore.XUnit.Domain
{
    public class ContaCorrente
    {
        private decimal Saldo { get; set; }
        private decimal SaldoBloqueado { get; set; }
        private decimal SaldoDisponivel { get; set; }
        public string Numero { get; private set; }
        public bool Ativa { get; private set; }
        private Guid ContaId { get; set; }

        public ContaCorrente(Guid contaId)
        {
            ContaId = contaId;
        }

        protected ContaCorrente()
        {

        }

        public RetornoTransacao Depositar(decimal valor)
        {
            Saldo += valor;
            return new RetornoTransacao("Deposito efetuado com sucesso!", RetornoTransacao.TipoRetorno.Sucesso);
        }

        public decimal ConsultarSaldo()
        {
            return ComporSaldoDisponivel();
        }

        private decimal ComporSaldoDisponivel()
        {
            SaldoDisponivel = Saldo - SaldoBloqueado;
            return SaldoDisponivel;
        }

        public RetornoTransacao SacarDinheiro(decimal valor)
        {
            if (valor < 0)
                throw new Exception("Saque não pode ser de valor negativo");

            if (valor > ComporSaldoDisponivel())
                return new RetornoTransacao("Saldo inferior ao saque", RetornoTransacao.TipoRetorno.Erro);

            Saldo -= valor;
            return new RetornoTransacao("Saque efetuado com sucesso!", RetornoTransacao.TipoRetorno.Sucesso);
        }

        public bool EhValido()
        {
            return true;
        }

        public static class ContaCorrenteFactory
        {
            public static ContaCorrente NovaContaCorrente(Guid id, string numero, bool ativa)
            {
                return new ContaCorrente()
                {
                    ContaId = id,
                    Numero = numero,
                    Ativa = ativa
                };

                // Metodos de validacao
            }
        }
    }
}
