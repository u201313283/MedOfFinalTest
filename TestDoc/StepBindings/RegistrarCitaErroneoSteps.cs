using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestDoc.StepBindings
{
    [Binding]
    public class RegistrarCitaErroneoSteps : IDisposable //Done 50(Click) Done Alert 

    {
        private ChromeDriver chromeDriver;
        public RegistrarCitaErroneoSteps() => chromeDriver = new ChromeDriver();

        [Given(@"una petición de registro de una  cita")]
        public void GivenUnaPeticionDeRegistroDeUnaCita()
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
        
        [Given(@"los campos del formulario fueron llenados incorrectamente")]
        public void GivenLosCamposDelFormularioFueronLlenadosIncorrectamente()
        {
            chromeDriver.FindElementByName("Motivo").SendKeys("Covid");
            chromeDriver.FindElementByName("Descripcion").SendKeys("Posible covid");
            chromeDriver.FindElementByName("Sintomas").SendKeys("Tos, Fiebre");
            chromeDriver.FindElementByName("Fecha").SendKeys("2020-11-111");
            chromeDriver.FindElementByName("Hora").SendKeys("09:30"); //Posible problema
            System.Threading.Thread.Sleep(5000); //Esperamos para dar click en el de paciente
        }
        
        [When(@"el usuario de click en el botón CREAR CITA")]
        public void WhenElUsuarioDeClickEnElBotonCREARCITA()
        {
            chromeDriver.FindElementByName("CrearCita").Click();
            System.Threading.Thread.Sleep(3000); //Esperamos para dar click en el de paciente
        }
        
        [Then(@"el sistema no ingresará la información de la nueva cita a la base de datos, y mostrará al usuario los campos incorrectos")]
        public void ThenElSistemaNoIngresaraLaInformacionDeLaNuevaCitaALaBaseDeDatosYMostraraAlUsuarioLosCamposIncorrectos()
        {
            string finalText = chromeDriver.FindElementByName("Alerta").Text;
            Assert.IsFalse(finalText.Equals("Se CREÓ la Cita."));
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
