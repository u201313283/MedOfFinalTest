using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestDoc.StepBindings
{
    [Binding]
    public class LoginUsuarioSteps : IDisposable //Done Done
    {
        private ChromeDriver chromeDriver;
        public LoginUsuarioSteps() => chromeDriver = new ChromeDriver();

        [Given(@"un intento de logueo con correo y contraseña válidos")]
        public void GivenUnIntentoDeLogueoConYValidos()
        {
            chromeDriver.Navigate().GoToUrl("http://localhost:8081/");
            chromeDriver.FindElementByName("email").SendKeys("brandonalegriavivanco1998@gmail.com");
            chromeDriver.FindElementByName("password").SendKeys("password");
        }
        
        [When(@"el usuario dé click en el botón ENTRAR")]
        public void WhenElUsuarioDeClickEnElBotonENTRAR()
        {
            chromeDriver.FindElementByName("Login").Click();
        }
        
        [Then(@"el sistema lo redireccionará a su vista de citas")]
        public void ThenElSistemaLoRedireccionaraASuVistaDeCitas()
        {
            System.Threading.Thread.Sleep(2000);
            Assert.IsTrue(chromeDriver.Url.Contains("citas"));
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
