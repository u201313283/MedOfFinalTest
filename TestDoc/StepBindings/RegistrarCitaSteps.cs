using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestDoc.StepBindings
{
    [Binding]
    public class RegistrarCitaSteps : IDisposable //Done 50(Click) Done Alert 

    {
        private ChromeDriver chromeDriver;
        public RegistrarCitaSteps() => chromeDriver = new ChromeDriver();

        [Given(@"una petición de registro de una nueva cita")]
        public void GivenUnaPeticionDeRegistroDeUnaNuevaCita()
        {
            //Background :D!
            chromeDriver.Navigate().GoToUrl("http://localhost:8081/");
            chromeDriver.FindElementByName("email").SendKeys("brandonalegriavivanco1998@gmail.com");
            chromeDriver.FindElementByName("password").SendKeys("password");
            chromeDriver.FindElementByName("Login").Click();
            System.Threading.Thread.Sleep(2000);

            //Given
            chromeDriver.FindElementByName("NuevaCita").Click();
        }
        
        [Given(@"los campos del formulario fueron llenados de forma incorrecta")]
        public void GivenLosCamposDelFormularioFueronLlenadosDeFormaIncorrecta()
        {
            chromeDriver.FindElementByName("Motivo").SendKeys("Covid");
            chromeDriver.FindElementByName("Descripcion").SendKeys("Posible covid");
            chromeDriver.FindElementByName("Sintomas").SendKeys("Tos, Fiebre");
            chromeDriver.FindElementByName("Fecha").SendKeys("2020-11-11");
            chromeDriver.FindElementByName("Hora").SendKeys("09:30"); //Posible problema
            System.Threading.Thread.Sleep(5000); //Esperamos para dar click en el de paciente
        }
        
        [When(@"el usuario haga click en el botón CREAR CITA")]
        public void WhenElUsuarioHagaClickEnElBotonCREARCITA()
        {
            chromeDriver.FindElementByName("CrearCita").Click();
            System.Threading.Thread.Sleep(3000); //Esperamos para dar click en el de paciente
        }
        
        [Then(@"el sistema ingresará la información de la nueva cita a la base de datos")]
        public void ThenElSistemaIngresaraLaInformacionDeLaNuevaCitaALaBaseDeDatos()
        {
            string finalText = chromeDriver.FindElementByName("Alerta").Text;
            Assert.AreEqual(finalText, "Se CREÓ la Cita.");
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
