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
    public class PersonRepositoryTestWithDB
    {
        SampleArchContextTest databaseContext;
        PersonRepository objRepo;

        [SetUp]
        public void Initialize()
        {
            Console.WriteLine("Inicializando");
            databaseContext = new SampleArchContextTest();
            objRepo = new PersonRepository(databaseContext);
        }

        [Test]
        public void Person_Repository_Get_ALL()
        {
            Console.WriteLine("Ejecutando ALL");

            //Act
            var result = objRepo.GetAll().ToList();

            //Assert

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("Admin", result[0].Nombre);
            Assert.AreEqual("Empresa", result[1].Nombre);
        }

        [Test]
        public void Person_Repository_Create()
        {
            Console.WriteLine("Ejecutando NEW");
            //Arrange
            Person c = new Person() { Id="302", Cedula = "5435343", Nombre = "Isaias", Apellido = "Escobar", Permiso = false, Rol = "Asociado" };

            //Act
            objRepo.Add(c);
            databaseContext.SaveChanges();

            var lst = objRepo.GetAll().ToList();

            //Assert

            Assert.AreEqual(4, lst.Count);
            Assert.AreEqual("Isaias", lst.Last().Nombre);

            objRepo.Delete(c);
            databaseContext.SaveChanges();

        }
    }
}


