using System;
using TechTalk.SpecFlow;

namespace BDD.NetCore.XUnit
{
    [Binding]
    public class LoginDeUsuarioSteps
    {
        [Given(@"Dado um usuario")]
        public void DadoDadoUmUsuario()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"que esteja ativo")]
        public void DadoQueEstejaAtivo()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Informa o usuario e senha")]
        public void QuandoInformaOUsuarioESenha(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"O usuario esta autorizado a acessar o sistema")]
        public void EntaoOUsuarioEstaAutorizadoAAcessarOSistema()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"O usuario nao esta autorizado a acessar o sistema")]
        public void EntaoOUsuarioNaoEstaAutorizadoAAcessarOSistema()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
