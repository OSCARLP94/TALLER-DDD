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
    public class ArabicaRepositoryTestWithDB
    {
        SampleArchContextTest databaseContext;
        ArabicaRepository objRepo;

        [SetUp]
        public void Initialize()
        {
           
            Console.WriteLine("Inicializando");
            databaseContext = new SampleArchContextTest();
            objRepo = new ArabicaRepository(databaseContext);
        }

        [Test]
        public void Arabica_Repository_Get_ALL()
        {
            Console.WriteLine("Ejecutando ALL");

            //Act
            var result = objRepo.GetAll().ToList();

            //Assert

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("1", result[0].IdMuestra);
            Assert.AreEqual("2", result[1].IdMuestra);
        }

        [Test]
        public void Arabica_Repository_Create()
        {
            Console.WriteLine("Ejecutando NEW");
            //Arrange
            Arabica c = new Arabica() { Id = "3", IdMuestra = "2", Calificacion = 92.5, TotalAcidez = 7.5, TotalCuerpo = 7.5, TotalBalance = 7.5, TotalDulzor = 10, Dulzor1 = true, Dulzor2 = true, Dulzor3 = true, Dulzor4 = true, Dulzor5 = true, TotalFragancia = 7.5, TotalGeneral = 7.5, TotalSabor = 7.5, TotalSaborBoca = 7.5, TotalTaza = 0, Taza1 = false, Taza2 = false, Taza3 = false, Taza4 = false, Taza5 = false, Tueste = 3, TotalUniformidad = 0, Uniformidad1 = false, Uniformidad2 = false, Uniformidad3 = false, Uniformidad4 = false, Uniformidad5 = false };

            //Act
            objRepo.Add(c);
            databaseContext.SaveChanges();

            var lst = objRepo.GetAll().ToList();

            //Assert

            Assert.AreEqual(3, lst.Count);
            Assert.AreEqual("2", lst.Last().IdMuestra);

            objRepo.Delete(c);
            databaseContext.SaveChanges();

        }
    }
}


