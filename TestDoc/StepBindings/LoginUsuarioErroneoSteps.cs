using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestDoc.StepBindings
{
    [Binding]
    public class LoginUsuarioStepsErroneo : IDisposable //Done Done
    {
        private ChromeDriver chromeDriver;
        public LoginUsuarioStepsErroneo() => chromeDriver = new ChromeDriver();

        [Given(@"un intento de logueo con correo y contraseña inválidos")]
        public void GivenUnIntentoDeLogueoConCorreoYContrasenaInvalidos()
        {
            chromeDriver.Navigate().GoToUrl("http://localhost:8081/");
            chromeDriver.FindElementByName("email").SendKeys("brandonalegriavivanco1998@gmail.com");
            chromeDriver.FindElementByName("password").SendKeys("randompassword");
        }
        
        [When(@"el usuario haga click en el botón ENTRAR")]
        public void WhenElUsuarioHagaClickEnElBotonENTRAR()
        {
            chromeDriver.FindElementByName("Login").Click();
        }
        
        [Then(@"el sistema notificará que el correo/contraseña son incorrectos")]
        public void ThenElSistemaNotificaraQueElCorreoContrasenaSonIncorrectos()
        {
            System.Threading.Thread.Sleep(2000);
            Assert.IsFalse(chromeDriver.Url.Contains("citas"));
        }

        public void Dispose()
        {
            if (chromeDriver != null)
            {
                chromeDriver.Dispose();
                chromeDriver = null;
            }
        }
    }
}
