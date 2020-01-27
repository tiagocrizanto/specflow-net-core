using System;

namespace BDD.NetCore.XUnit.Domain.ValueObjects
{
    public class RetornoTransacao
    {
        public Guid NumeroTransacao { get; private set; }
        public string Mensagem { get; private set; }
        public TipoRetorno Retorno { get; private set; }

        public RetornoTransacao(string mensagem, TipoRetorno retorno)
        {
            NumeroTransacao = Guid.NewGuid();
            Mensagem = mensagem;
            Retorno = retorno;
        }

        public enum TipoRetorno
        {
            Sucesso = 0,
            Erro = 1,
            Violacao = 2
        }
    }
}
