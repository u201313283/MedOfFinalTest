using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace TestDoc.StepBindings 
{
    [Binding]
    public class RegistrarPacienteSteps : IDisposable //Done
    {
        private ChromeDriver chromeDriver;
        public RegistrarPacienteSteps() => chromeDriver = new ChromeDriver();

        private LoginUsuarioSteps loginUsuarioSteps = new LoginUsuarioSteps();


        [Given(@"Login exitoso")]
        public void GivenLoginExitoso()
        {
            chromeDriver.Navigate().GoToUrl("http://localhost:8081/");
            chromeDriver.FindElementByName("email").SendKeys("brandonalegriavivanco1998@gmail.com");
            chromeDriver.FindElementByName("password").SendKeys("password");
            chromeDriver.FindElementByName("Login").Click();
            System.Threading.Thread.Sleep(2000);
        }
        
        [Given(@"una petición de registro de paciente")]
        public void GivenUnaPeticionDeRegistroDePaciente()
        {
            chromeDriver.FindElementByName("pacientes").Click();
            System.Threading.Thread.Sleep(1000);
            chromeDriver.FindElementByName("nuevoPaciente").Click();
            System.Threading.Thread.Sleep(1000);
        }
        
        [Given(@"los campos del formulario fueron llenados correctamente")]
        public void GivenLosCamposDelFormularioFueronLlenadosCorrectamente()
        {
            
            chromeDriver.FindElementByName("nombres").SendKeys("Fulano");
            chromeDriver.FindElementByName("apellidoPaterno").SendKeys("Marquez");
            chromeDriver.FindElementByName("apellidoMaterno").SendKeys("Estrada");
            chromeDriver.FindElementByName("nDocumento").SendKeys("71428997");
            chromeDriver.FindElementByName("direccion").SendKeys("Lima");
            chromeDriver.FindElementByName("fecha").SendKeys("1998-11-18");
            chromeDriver.FindElementByName("telefono").SendKeys("3454746");
            chromeDriver.FindElementByName("celular").SendKeys("994395477");
            chromeDriver.FindElementByName("correo").SendKeys("stormfury1998@gmail.com");

        }
        
        [When(@"el usuario haga click en el botón REGISTRAR")]
        public void WhenElUsuarioHagaClickEnElBotonREGISTRAR()
        {
            chromeDriver.FindElementByName("registrarPaciente").Click();
        }
        
        [Then(@"el sistema ingresará la información del nuevo paciente en la base de datos")]
        public void ThenElSistemaIngresaraLaInformacionDelNuevoPacienteEnLaBaseDeDatos()
        {
            System.Threading.Thread.Sleep(2000);
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
