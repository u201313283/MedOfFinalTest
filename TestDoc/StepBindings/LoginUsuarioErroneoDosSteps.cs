using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestDoc.StepBindings
{
    [Binding]
    public class LoginUsuarioErroneoDosSteps : IDisposable //Done 50 Done
    {
        private ChromeDriver chromeDriver;
        public LoginUsuarioErroneoDosSteps() => chromeDriver = new ChromeDriver();
        [Given(@"(.*) intentos seguidos de logueo con correo y contraseña inválidos")]
        public void GivenIntentosSeguidosDeLogueoConCorreoYContrasenaInvalidos(int p0)
        {
            chromeDriver.Navigate().GoToUrl("http://localhost:8081/");
            chromeDriver.FindElementByName("email").SendKeys("brandonalegriavivanco1998@gmail.com");
            chromeDriver.FindElementByName("password").SendKeys("randompassword");
        }
        
        [When(@"el usuario  clickee en el botón ENTRAR")]
        public void WhenElUsuarioClickeeEnElBotonENTRAR()
        {
            chromeDriver.FindElementByName("Login").Click();
            System.Threading.Thread.Sleep(2000);
            chromeDriver.FindElementByName("Login").Click();
            System.Threading.Thread.Sleep(2000);
            chromeDriver.FindElementByName("Login").Click();
            System.Threading.Thread.Sleep(2000);
        }
        
        [Then(@"el sistema bloqueará la cuenta por (.*) minutos")]
        public void ThenElSistemaBloquearaLaCuentaPorMinutos(int p0)
        {
            System.Threading.Thread.Sleep(2000);
            string finalText = chromeDriver.FindElementByName("FuerzaBruta").Text;
            Assert.AreEqual(finalText, "LO SENTIMOS, EXCEDIÓ EL LÍMITE DE INTENTOS. INTENTE DE NUEVO EN 30 MINUTOS");
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
