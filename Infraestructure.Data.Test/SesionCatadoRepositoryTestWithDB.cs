using Domain.Entities;
using Infraestructure.Data.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data.Test
{
    [TestFixture]
    public class SesionCatadoRepositoryTestWithDB
    {
        CataneiContextTest databaseContext;
        SesionCatadoRepository objRepo;

        [SetUp]
        public void Initialize()
        {
            Console.WriteLine("Inicializando");
            databaseContext = new CataneiContextTest();
            objRepo = new SesionCatadoRepository(databaseContext);
        }

        [Test]
        public void SesionCatado_Repository_Get_ALL()
        {
            Console.WriteLine("Ejecutando ALL");

            //Act
            var result = objRepo.GetAll().ToList();

            //Assert

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("Digitos", result[0].Identificador);
            Assert.AreEqual("Letras", result[1].Identificador);
        }

        [Test]
        public void SesionCatado_Repository_Create()
        {
            Console.WriteLine("Ejecutando NEW");
            //Arrange
            SesionCatado c = new SesionCatado() {Id="3", FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0), IdCiudad = "311", Identificador = "Digitos", Protocolo = "Arabica", CantidadMuestras = 1, IdPerson = "201", Estado = "Incompleto" };

            //Act
            objRepo.Add(c);
            databaseContext.SaveChanges();

            var lst = objRepo.GetAll().ToList();

            //Assert

            Assert.AreEqual(3, lst.Count);
            Assert.AreEqual("Digitos", lst.Last().Identificador);

            objRepo.Delete(c);
            databaseContext.SaveChanges();

        }
    }
}
