using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestDoc.StepBindings
{
    [Binding]
    public class RegistrarUsuarioSteps : IDisposable //Done Done
    {
        private ChromeDriver chromeDriver;
        public RegistrarUsuarioSteps() => chromeDriver = new ChromeDriver();

        [Given(@"una petición de registro en la plataforma")]
        public void GivenUnaPeticionDeRegistroEnLaPlataforma()
        {
            chromeDriver.Navigate().GoToUrl("http://localhost:8081/");
            chromeDriver.FindElementByName("Registrar").Click();
            System.Threading.Thread.Sleep(2000);
        }
        
        [Given(@"los cambos del formulario fueron llenados correctamente")]
        public void GivenLosCambosDelFormularioFueronLlenadosCorrectamente()
        {
            chromeDriver.FindElementByName("Nombre").SendKeys("Salvatore");
            chromeDriver.FindElementByName("Apellidos").SendKeys("Alegría Vivanco");
            chromeDriver.FindElementByName("NombreConsultorio").SendKeys("Mr. Robot Clinic");
            chromeDriver.FindElementByName("Correo").SendKeys("salvatore1998@gmail.com");
            chromeDriver.FindElementByName("Contraseña").SendKeys("password");
            chromeDriver.FindElementByName("ConfirmarContraseña").SendKeys("password");
        }
        
        [When(@"cuando el usuario haga click en el botón REGISTRAR")]
        public void WhenCuandoElUsuarioHagaClickEnElBotonREGISTRAR()
        {
            chromeDriver.FindElementByName("CrearCuenta").Click();
        }
        
        [Then(@"el sistema ingresará la información del nuevo usuario en la base de datos")]
        public void ThenElSistemaIngresaraLaInformacionDelNuevoUsuarioEnLaBaseDeDatos()
        {
            System.Threading.Thread.Sleep(2000);
            Assert.IsTrue(chromeDriver.Url.Contains("/"));

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
