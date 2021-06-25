using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestDoc.StepBindings
{
    [Binding]
    public class VisualizarHorarioSteps : IDisposable //Done Done
    {
        private ChromeDriver chromeDriver;
        public VisualizarHorarioSteps() => chromeDriver = new ChromeDriver();

        [Given(@"la acción de login correcto")]
        public void GivenLaAccionDeLoginCorrecto()
        {
            chromeDriver.Navigate().GoToUrl("http://localhost:8081/");
            chromeDriver.FindElementByName("email").SendKeys("brandonalegriavivanco1998@gmail.com");
            chromeDriver.FindElementByName("password").SendKeys("password");
            chromeDriver.FindElementByName("Login").Click();
            System.Threading.Thread.Sleep(2000);
        }
        
        [When(@"el usuario sea redireccionado a la vista de citas")]
        public void WhenElUsuarioSeaRedireccionadoALaVistaDeCitas()
        {
            System.Threading.Thread.Sleep(2000);
        }
        
        [Then(@"el sistema verificará que el usuario tenga citas programadas y no hayan sido canceladas, mostrará un calendario con las citas en formato día/semana/mes")]
        public void ThenElSistemaVerificaraQueElUsuarioTengaCitasProgramadasYNoHayanSidoCanceladasMostraraUnCalendarioConLasCitasEnFormatoDiaSemanaMes()
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
