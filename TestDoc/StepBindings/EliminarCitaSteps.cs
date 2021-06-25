using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestDoc.StepBindings
{
    [Binding]
    public class EliminarCitaSteps : IDisposable //Done 50
    {
        private ChromeDriver chromeDriver;
        public EliminarCitaSteps() => chromeDriver = new ChromeDriver();

        [Given(@"una petición de la eliminación de una cita")]
        public void GivenUnaPeticionDeLaEliminacionDeUnaCita()
        {
            //Background :D!
            chromeDriver.Navigate().GoToUrl("http://localhost:8081/");
            chromeDriver.FindElementByName("email").SendKeys("brandonalegriavivanco1998@gmail.com");
            chromeDriver.FindElementByName("password").SendKeys("password");
            chromeDriver.FindElementByName("Login").Click();
            System.Threading.Thread.Sleep(5000);

            // => Esperamos que de click en la cita
        }

        [When(@"cuando el usuario haga click en el botón ELIMINAR CITA")]
        public void WhenCuandoElUsuarioHagaClickEnElBotonELIMINARCITA()
        {
            chromeDriver.FindElementByName("EliminarCita").Click();
        }
        
        [Then(@"el sistema verificará que la cita se haya realizado y procederá a eliminar la cita de forma lógica")]
        public void ThenElSistemaVerificaraQueLaCitaSeHayaRealizadoYProcederaAEliminarLaCitaDeFormaLogica()
        {
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
