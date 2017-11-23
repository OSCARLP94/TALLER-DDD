using Domain.Business;
using Domain.Entities;
using Domain.Business;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Test
{
    [TestFixture]
    public class PersonBllTest
    {
        PersonaBll personaBll;
        [SetUp]
        public void Initialize()
        {
            personaBll = new PersonaBll();
        }

        //###### CATADOR ######
        [Test]
        public void Persona_Nick_Incorrecto()
        {
            Person entity = new Person()
            {
                Id = "1234",
                Cedula = "1065",
                Nombre = "Oscar",
                Apellido = "Lozano",
                Telefono = "5858585",
                Correo = "oscarlozano@hotmail.com",
                Direccion = "Av. Siempre Viva",
                Nick = "Osc",
                Clave = "23456789",
                Permiso = false,
                Rol = "Catador",
            };
            //Act-> Actuar
            string resultado = personaBll.ValidateCatador(entity);
            //Assert->Afirmar
            Assert.AreEqual("Error. Nick necesita entre 5 a 30 caracteres", resultado);
        }

        [Test]
        public void Persona_Contraseña_Incorrecto()
        {
            Person entity = new Person()
            {
                Id = "1234",
                Cedula = "1065",
                Nombre = "Oscar",
                Apellido = "Lozano",
                Telefono = "5858585",
                Correo = "oscarlozano@hotmail.com",
                Direccion = "Av. Siempre Viva",
                Nick = "OscarL",
                Clave = "2345",
                Permiso = false,
                Rol = "Catador",
            };
            //Act-> Actuar
            string resultado = personaBll.ValidateCatador(entity);
            //Assert->Afirmar
            Assert.AreEqual("Error. Contraseña necesita entre 5 a 30 caracteres", resultado);
        }

        [Test]
        public void Persona_Nick_Con_Caracteres()
        {
            Person entity = new Person()
            {
                Id = "1234",
                Cedula = "1065",
                Nombre = "Oscar",
                Apellido = "Lozano",
                Telefono = "5858585",
                Correo = "oscarlozano@hotmail.com",
                Direccion = "Av. Siempre Viva",
                Nick = "Osc@K",
                Clave = "23456789",
                Permiso = false,
                Rol = "Catador",
            };
            //Act-> Actuar
            string resultado = personaBll.ValidateCatador(entity);
            //Assert->Afirmar
            Assert.AreEqual("Error. No se admiten caracteres especiales #$%&/()=?¡*[]...", resultado);
        }

        [Test]
        public void Persona_Catador_Ok()
        {
            Person entity = new Person()
            {
                Id = "1234",
                Cedula = "1065",
                Nombre = "Oscar",
                Apellido = "Lozano",
                Telefono = "5858585",
                Correo = "oscarlozano@hotmail.com",
                Direccion = "Av. Siempre Viva",
                Nick = "OscarL",
                Clave = "23456789",
                Permiso = false,
                Rol = "Catador",
            };
            //Act-> Actuar
            string resultado = personaBll.ValidateCatador(entity);
            //Assert->Afirmar
            Assert.AreEqual("Ok", resultado);
        }

    }
}
