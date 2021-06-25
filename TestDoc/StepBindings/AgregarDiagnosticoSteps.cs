using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestDoc.StepBindings
{
    [Binding]
    public class AgregarDiagnosticoSteps : IDisposable //Done 50
    {
        private ChromeDriver chromeDriver;
        public AgregarDiagnosticoSteps() => chromeDriver = new ChromeDriver();

        [Given(@"una petición de registro de un diagnostico para una cita")]
        public void GivenUnaPeticionDeRegistroDeUnDiagnosticoParaUnaCita()
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
            chromeDriver.Navigate().GoToUrl("http://localhost:8081/citas/cita/2061"); //cambiar el 2061
        }
        
        [Given(@"teniendo los campos del formulario llenados correctamentes")]
        public void GivenTeniendoLosCamposDelFormularioLlenadosCorrectamentes()
        {
            chromeDriver.FindElementByName("Observacion").SendKeys("Posiblemente tenga covid");
            System.Threading.Thread.Sleep(4000);
            chromeDriver.FindElementByName("Frecuencia").SendKeys("8");
            chromeDriver.FindElementByName("Duracion").SendKeys("3");
            System.Threading.Thread.Sleep(4000);
        }
        
        [When(@"el usuario haga click en el botón CREAR DIAGNOSTICO")]
        public void WhenElUsuarioHagaClickEnElBotonCREARDIAGNOSTICO()
        {
            chromeDriver.FindElementByName("Guardar").Click();
            System.Threading.Thread.Sleep(2000);
        }
        
        [Then(@"el sistema ingresará la información del nuevo diagnostico en la base de datos\.")]
        public void ThenElSistemaIngresaraLaInformacionDelNuevoDiagnosticoEnLaBaseDeDatos_()
        {
            string finalText = chromeDriver.FindElementByName("Alerta").Text;
            Assert.AreEqual(finalText, "Se CREÓ la Receta.");
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
