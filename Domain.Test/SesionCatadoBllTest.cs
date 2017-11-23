using Domain.Business;
using Domain.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Test
{
    [TestFixture]
    public class SesionCatadoBllTest
    {
       SesionCatadoBll sesionCatadoBll;

        [SetUp]
        public void Initialize()
        {
            sesionCatadoBll = new SesionCatadoBll();
        }

        //###### CREATE #######
        [Test]
        public void Sesion_Invalid_Muestras()
        {       
            SesionCatado entity = new SesionCatado()
            {
                Id = "1234",
                FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0),
                Identificador = "Digitos",
                Protocolo = "Arabica",
                CantidadMuestras = 16,
                IdCiudad = "301",
                IdPerson = "201",
               Estado = "Incompleto"
            };
            //Act-> Actuar
            string resultado = sesionCatadoBll.ValidateCreate(entity);
            //Assert->Afirmar
            Assert.AreEqual("Error. # Muestras fuera de rango", resultado);
        }

        [Test]
        public void Sesion_Ivalid_Protocolo()
        {
            SesionCatado entity = new SesionCatado()
            {
                Id = "1234",
                FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0),
                Identificador = "Digitos",
                Protocolo = "Robusta",
                CantidadMuestras = 15,
                IdCiudad = "301",
                IdPerson = "201",
                Estado = "Incompleto"
            };
            //Act-> Actuar
            string resultado = sesionCatadoBll.ValidateCreate(entity);
            //Assert->Afirmar
            Assert.AreEqual("Error. Protocolo invalido", resultado);
        }

        [Test]
        public void Sesion_Ivalid_Idetificador()
        {
            SesionCatado entity = new SesionCatado()
            {
                Id = "1234",
                FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0),
                Identificador = "Simbolos",
                Protocolo = "Arabica",
                CantidadMuestras = 15,
                IdCiudad = "301",
                IdPerson = "201",
                Estado = "Incompleto"
            };
            //Act-> Actuar
            string resultado = sesionCatadoBll.ValidateCreate(entity);
            //Assert->Afirmar
            Assert.AreEqual("Error. Identificador invalido", resultado);
        }

        [Test]
        public void Sesion_Estado_Incorrecto()
        {
            SesionCatado entity = new SesionCatado()
            {
                Id = "1234",
                FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0),
                Identificador = "Digitos",
                Protocolo = "Arabica",
                CantidadMuestras = 15,
                IdCiudad = "301",
                IdPerson = "201",
                Estado = "Vacio"
            };
            //Act-> Actuar
            string resultado = sesionCatadoBll.ValidateCreate(entity);
            //Assert->Afirmar
            Assert.AreEqual("Error. Estado inicial incorrecto", resultado);
        }

        //###### DELETE #######
        [Test]
        public void Sesion_Completa()
        {
            SesionCatado entity = new SesionCatado()
            {
                Id = "1234",
                FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0),
                Identificador = "Digitos",
                Protocolo = "Arabica",
                CantidadMuestras = 15,
                IdCiudad = "301",
                IdPerson = "201",
                Estado = "Completo"
            };
            //Act-> Actuar
            string resultado = sesionCatadoBll.ValidateDelete(entity, "201");
            //Assert->Afirmar
            Assert.AreEqual("Error. Sesion está completa", resultado);
        }

        [Test]
        public void Sesion_Sin_Permiso()
        {
            SesionCatado entity = new SesionCatado()
            {
                Id = "1234",
                FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0),
                Identificador = "Digitos",
                Protocolo = "Arabica",
                CantidadMuestras = 15,
                IdCiudad = "301",
                IdPerson = "201",
                Estado = "Incompleto"
            };
            //Act-> Actuar
            string resultado = sesionCatadoBll.ValidateDelete(entity, "301");
            //Assert->Afirmar
            Assert.AreEqual("Error. No tiene permiso sobre esta sesion", resultado);
        }

        [Test]
        public void Sesion_Ok()
        {
            SesionCatado entity = new SesionCatado()
            {
                Id = "1234",
                FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0),
                Identificador = "Digitos",
                Protocolo = "Arabica",
                CantidadMuestras = 15,
                IdCiudad = "301",
                IdPerson = "201",
                Estado = "Incompleto"
            };
            //Act-> Actuar
            string resultado = sesionCatadoBll.ValidateDelete(entity, "201");
            //Assert->Afirmar
            Assert.AreEqual("Ok", resultado);
        }

        //###### UPDATE #######
        [Test]
        public void Sesion_ConstMuestras()
        {
            SesionCatado current = new SesionCatado()
            {
                Id = "1234",
                FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0),
                Identificador = "Digitos",
                Protocolo = "Arabica",
                CantidadMuestras = 15,
                IdCiudad = "301",
                IdPerson = "201",
                Estado = "Completo"
            };

            SesionCatado entity = new SesionCatado()
            {
                Id = "1234",
                FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0),
                Identificador = "Digitos",
                Protocolo = "Arabica",
                CantidadMuestras = 14,
                IdCiudad = "301",
                IdPerson = "201",
                Estado = "Completo"
            };
            //Act-> Actuar
            string resultado = sesionCatadoBll.ValidateUpdate(current, entity);
            //Assert->Afirmar
            Assert.AreEqual("Error. # Muestras deben permanecer constante", resultado);
        }

        [Test]
        public void Sesion_Invalid_Idenificador()
        {
            SesionCatado entity = new SesionCatado()
            {
                Id = "1234",
                FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0),
                Identificador = "Simbolos",
                Protocolo = "Arabica",
                CantidadMuestras = 15,
                IdCiudad = "301",
                IdPerson = "201",
                Estado = "Incompleto"
            };

            SesionCatado current = new SesionCatado()
            {
                Id = "1234",
                FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0),
                Identificador = "Digitos",
                Protocolo = "Arabica",
                CantidadMuestras = 15,
                IdCiudad = "301",
                IdPerson = "201",
                Estado = "Incompleto"
            };
            //Act-> Actuar
            string resultado = sesionCatadoBll.ValidateUpdate(current, entity);
            //Assert->Afirmar
            Assert.AreEqual("Error. Identificador invalido", resultado);
        }

        [Test]
        public void Sesion_Incorrecto_Estado()
        {
            SesionCatado entity = new SesionCatado()
            {
                Id = "1234",
                FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0),
                Identificador = "Digitos",
                Protocolo = "Arabica",
                CantidadMuestras = 15,
                IdCiudad = "301",
                IdPerson = "201",
                Estado = "Desconocido"
            };

            SesionCatado current = new SesionCatado()
            {
                Id = "1234",
                FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0),
                Identificador = "Digitos",
                Protocolo = "Arabica",
                CantidadMuestras = 15,
                IdCiudad = "301",
                IdPerson = "201",
                Estado = "Incompleto"
            };
            //Act-> Actuar
            string resultado = sesionCatadoBll.ValidateUpdate(current, entity);
            //Assert->Afirmar
            Assert.AreEqual("Error. Estado incorrecto", resultado);
        }

        [Test]
        public void Sesion_NoModificar()
        {
            SesionCatado entity = new SesionCatado()
            {
                Id = "1234",
                FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0),
                Identificador = "Digitos",
                Protocolo = "Arabica",
                CantidadMuestras = 15,
                IdCiudad = "301",
                IdPerson = "201",
                Estado = "Completo"
            };

            SesionCatado current = new SesionCatado()
            {
                Id = "1234",
                FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0),
                Identificador = "Digitos",
                Protocolo = "Arabica",
                CantidadMuestras = 15,
                IdCiudad = "301",
                IdPerson = "201",
                Estado = "Incompleto"
            };
            //Act-> Actuar
            string resultado = sesionCatadoBll.ValidateUpdate(current, entity);
            //Assert->Afirmar
            Assert.AreEqual("Error. Ya no se puede modificar la sesion", resultado);
        }

        [Test]
        public void Sesion_Modificar_Ok()
        {
            SesionCatado entity = new SesionCatado()
            {
                Id = "1234",
                FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0),
                Identificador = "Digitos",
                Protocolo = "Arabica",
                CantidadMuestras = 15,
                IdCiudad = "301",
                IdPerson = "201",
                Estado = "Incompleto"
            };

            SesionCatado current = new SesionCatado()
            {
                Id = "1234",
                FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0),
                Identificador = "Digitos",
                Protocolo = "Arabica",
                CantidadMuestras = 15,
                IdCiudad = "301",
                IdPerson = "201",
                Estado = "Incompleto"
            };
            //Act-> Actuar
            string resultado = sesionCatadoBll.ValidateUpdate(current, entity);
            //Assert->Afirmar
            Assert.AreEqual("Ok", resultado);
        }
    }
}
