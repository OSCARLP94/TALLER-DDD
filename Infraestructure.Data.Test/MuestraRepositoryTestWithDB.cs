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
    public class MuestraRepositoryTestWithDB
    {
        SampleArchContextTest databaseContext;
        MuestraRepository objRepo;

        [SetUp]
        public void Initialize()
        {
            Console.WriteLine("Inicializando");
            databaseContext = new SampleArchContextTest();
            objRepo = new MuestraRepository(databaseContext);
        }

        [Test]
        public void Muestra_Repository_Get_ALL()
        {
            Console.WriteLine("Ejecutando ALL");

            //Act
            var result = objRepo.GetAll().ToList();

            //Assert

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("1", result[0].IdSesionCatado);
            Assert.AreEqual("2", result[1].IdSesionCatado);
        }

        [Test]
        public void Muestra_Repository_Create()
        {
            Console.WriteLine("Ejecutando NEW");
            //Arrange
            Muestra c = new Muestra() { Id = "3", Descripcion = "test2", Identificador = "1", Especie = "Arabica", AnioCosecha = "2010", IdSesionCatado = "1", IdPerson = "301", Estado = "Incompleto" };

            //Act
            objRepo.Add(c);
            databaseContext.SaveChanges();

            var lst = objRepo.GetAll().ToList();

            //Assert

            Assert.AreEqual(3, lst.Count);
            Assert.AreEqual("1", lst.Last().IdSesionCatado);

            objRepo.Delete(c);
            databaseContext.SaveChanges();

        }
    }
}



