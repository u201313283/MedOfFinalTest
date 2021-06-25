using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestDoc.StepBindings
{
    [Binding]
    public class DescargarCitasSteps : IDisposable //Done
    {
        private ChromeDriver chromeDriver;
        public DescargarCitasSteps() => chromeDriver = new ChromeDriver();

        [Given(@"una petición de descarga del cronograma diario de citas")]
        public void GivenUnaPeticionDeDescargaDelCronogramaDiarioDeCitas()
        {
            chromeDriver.Navigate().GoToUrl("http://localhost:8081/");
            chromeDriver.FindElementByName("email").SendKeys("brandonalegriavivanco1998@gmail.com");
            chromeDriver.FindElementByName("password").SendKeys("password");
            chromeDriver.FindElementByName("Login").Click();
            System.Threading.Thread.Sleep(2000);
        }
        
        [When(@"el usuario de click en el botón DESCARGAR")]
        public void WhenElUsuarioDeClickEnElBotonDESCARGAR()
        {
            chromeDriver.FindElementByName("DescargarCita").Click();
        }
        
        [Then(@"el sistema verificará que tenga citas programadas y escribirá un archivo descargable con las citas diarias")]
        public void ThenElSistemaVerificaraQueTengaCitasProgramadasYEscribiraUnArchivoDescargableConLasCitasDiarias()
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
