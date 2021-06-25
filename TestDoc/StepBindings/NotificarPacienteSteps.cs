using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestDoc.StepBindings
{
    [Binding]
    public class NotificarPacienteSteps  : IDisposable //Done 50
    {
        private ChromeDriver chromeDriver;
        public NotificarPacienteSteps() => chromeDriver = new ChromeDriver();

        [Given(@"la petición de notificarle al paciente su cita programada")]
        public void GivenLaPeticionDeNotificarleAlPacienteSuCitaProgramada()
        {
            //Background :D!
            chromeDriver.Navigate().GoToUrl("http://localhost:8081/");
            chromeDriver.FindElementByName("email").SendKeys("brandonalegriavivanco1998@gmail.com");
            chromeDriver.FindElementByName("password").SendKeys("password");
            chromeDriver.FindElementByName("Login").Click();
            System.Threading.Thread.Sleep(5000);

            //Deberia hacerle click en la cita, pero no se puede actualmente por efectos de vuejs, así que le damos click manual


        }
        
        [When(@"el usuario de click en el botón NOTIFICAR")]
        public void WhenElUsuarioDeClickEnElBotonNOTIFICAR()
        {
            chromeDriver.FindElementByName("NotificarPaciente").Click();
        }
        
        [Then(@"el sistema validará que la cita no haya empezado y enviará un correo al paciente indicando la fecha y hora de su cita, notificando al médico que el correo fue enviado con éxito")]
        public void ThenElSistemaValidaraQueLaCitaNoHayaEmpezadoYEnviaraUnCorreoAlPacienteIndicandoLaFechaYHoraDeSuCitaNotificandoAlMedicoQueElCorreoFueEnviadoConExito()
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
