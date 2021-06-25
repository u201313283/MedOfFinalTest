using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestDoc.StepBindings
{
    [Binding]
    public class ModificarDiagnosticoSteps : IDisposable //Done 50
    {
        private ChromeDriver chromeDriver;
        public ModificarDiagnosticoSteps() => chromeDriver = new ChromeDriver();
        [Given(@"una petición de edición de los datos de un diagnóstico")]
        public void GivenUnaPeticionDeEdicionDeLosDatosDeUnDiagnostico()
        {
            /*
            //Background :D!
            chromeDriver.Navigate().GoToUrl("http://localhost:8081/");
            chromeDriver.FindElementByName("email").SendKeys("brandonalegriavivanco1998@gmail.com");
            chromeDriver.FindElementByName("password").SendKeys("password");
            chromeDriver.FindElementByName("Login").Click();
            System.Threading.Thread.Sleep(5000);

            //Given
            chromeDriver.FindElementByName("IniciarCita").Click();*/

            chromeDriver.Navigate().GoToUrl("http://localhost:8081/citas/cita/2070");
        }
        
        [When(@"el usuario de click en la cita a la que pertenece el diagnostico")]
        public void WhenElUsuarioDeClickEnLaCitaALaQuePerteneceElDiagnostico()
        {
            chromeDriver.FindElementByName("Observacion").SendKeys(" y problemas pulmonares");
            System.Threading.Thread.Sleep(5000);
            chromeDriver.FindElementByName("Guardar").Click();
            System.Threading.Thread.Sleep(2000);

        }
        
        [Then(@"el sistema verificará que la cita haya finalizado y llenará un formulario modificable con los datos del diagnóstico y detectará que fueron modificados con datos correctos, acto seguido los modificará en la base de datos")]
        public void ThenElSistemaVerificaraQueLaCitaHayaFinalizadoYLlenaraUnFormularioModificableConLosDatosDelDiagnosticoYDetectaraQueFueronModificadosConDatosCorrectosActoSeguidoLosModificaraEnLaBaseDeDatos()
        {
            string finalText = chromeDriver.FindElementByName("Alerta").Text;
            Assert.AreEqual(finalText, "Se ACTUALIZÓ el Diagnostico.");
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
