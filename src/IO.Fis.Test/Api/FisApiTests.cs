using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;
using IO.Fis.Client;
using IO.Fis.Api;
using IO.Fis.Model;

namespace IO.Fis.Test
{
    [TestFixture]
    public class FisApiTests
    {
        private string xApiKey;
        private string username;
        private string password;

        private FisApi apiTest;
        [SetUp]
        public void Init()
        {
            string basePath = "the_url/v1-1/fis/persona";
            this.xApiKey = "your_api_key";
            this.username = "your_username";
            this.password = "your_passwords";
            this.apiTest = new FisApi(basePath);
        }

        
        [Test]
        public void GetScoreTest()
        {

            PersonaPeticion request = new PersonaPeticion();
            DomicilioPeticion domicilio = new DomicilioPeticion();
            
            request.PrimerNombre ="LLLLLLLL";
            request.ApellidoPaterno ="LLLLLLLL";
            request.ApellidoMaterno ="LLLLLLLL";
            request.FechaNacimiento ="NN-NN-NNNN";
            request.Nacionalidad = CatalogoNacionalidad.MX;
            request.RFC ="LLLLNNNNNN";
            request.CURP ="LLLLLLLLLLLLLLLLLL";

            domicilio.Direccion = "LLLLLLLL LL";
            domicilio.ColoniaPoblacion = "LLLLLLLL";
            domicilio.Ciudad = "LLLLLLLL";
            domicilio.Estado = CatalogoEstados.DF;
            domicilio.DelegacionMunicipio = "LLLLLLLL";
            domicilio.CP = "NNNNN";
            domicilio.NumeroTelefono = "5555555555";

            request.Domicilio = domicilio;

            var response = this.apiTest.GetFis(this.xApiKey, this.username, this.password, request);
            Assert.IsInstanceOf<Respuesta> (response, "response is Respuesta");
            Console.WriteLine(response);
        }

    }
}
