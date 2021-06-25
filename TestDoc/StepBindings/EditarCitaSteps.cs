using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestDoc.StepBindings
{
    [Binding]
    public class EditarCitaSteps : IDisposable //Done 50(Click) Done Alert 
    {
        private ChromeDriver chromeDriver;
        public EditarCitaSteps() => chromeDriver = new ChromeDriver();

        [Given(@"una petición de edición de una cita programada")]
        public void GivenUnaPeticionDeEdicionDeUnaCitaProgramada()
        {
            //Background :D!
            chromeDriver.Navigate().GoToUrl("http://localhost:8081/");
            chromeDriver.FindElementByName("email").SendKeys("brandonalegriavivanco1998@gmail.com");
            chromeDriver.FindElementByName("password").SendKeys("password");
            chromeDriver.FindElementByName("Login").Click();
            System.Threading.Thread.Sleep(10000);

            // => Esperamos que de click en la cita
        }

        [When(@"el usuario de click en el botón EDITAR CITA")]
        public void WhenElUsuarioDeClickEnElBotonEDITARCITA()
        {
            chromeDriver.FindElementByName("Descripcion").SendKeys("o resfriado común");
            //Given  => Esperamos que de click en la cita
            chromeDriver.FindElementByName("CrearCita").Click();
            System.Threading.Thread.Sleep(2000);
        }
        
        [Then(@"el sistema validará que la cita aún no se haya dado y mostrará un formulario con lleno con los datos modificables de la cita para su edición")]
        public void ThenElSistemaValidaraQueLaCitaAunNoSeHayaDadoYMostraraUnFormularioConLlenoConLosDatosModificablesDeLaCitaParaSuEdicion()
        {
            string finalText = chromeDriver.FindElementByName("Alerta").Text;
            Console.Write("\n" + finalText);
            Assert.AreEqual(finalText, "Se EDITÓ la Cita.");
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
