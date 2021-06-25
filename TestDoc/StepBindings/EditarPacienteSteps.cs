using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestDoc.StepBindings
{
    [Binding]
    public class EditarPacienteSteps : IDisposable //Done 50
    {
        private ChromeDriver chromeDriver;
        public EditarPacienteSteps() => chromeDriver = new ChromeDriver();

        [Given(@"una petición de edición de los datos de un paciente")]
        public void GivenUnaPeticionDeEdicionDeLosDatosDeUnPaciente()
        {
            chromeDriver.Navigate().GoToUrl("http://localhost:8081/");
            chromeDriver.FindElementByName("email").SendKeys("brandonalegriavivanco1998@gmail.com");
            chromeDriver.FindElementByName("password").SendKeys("password");
            chromeDriver.FindElementByName("Login").Click();
            System.Threading.Thread.Sleep(2000);

            chromeDriver.FindElementByName("pacientes").Click();
        }
        
        [When(@"el usuario de click en el botón EDITAR")]
        public void WhenElUsuarioDeClickEnElBotonEDITAR()
        {
            //Esperamos al click
            System.Threading.Thread.Sleep(2000);
            //Escribe solo
            chromeDriver.FindElementByName("apellidoPaterno").SendKeys(" Giga");
            System.Threading.Thread.Sleep(2000);
            chromeDriver.FindElementByName("registrarPaciente").Click();
        }
        
        [Then(@"el sistema llenará un formulario modificable con los datos del paciente y validará que los datos hayan sido modificados y estén completados correctamente y serán ingresados a la base de datos")]
        public void ThenElSistemaLlenaraUnFormularioModificableConLosDatosDelPacienteYValidaraQueLosDatosHayanSidoModificadosYEstenCompletadosCorrectamenteYSeranIngresadosALaBaseDeDatos()
        {
            System.Threading.Thread.Sleep(2000);
            Assert.IsTrue(chromeDriver.Url.Contains("pacientes"));
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
