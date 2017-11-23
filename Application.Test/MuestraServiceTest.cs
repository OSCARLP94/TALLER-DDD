using Application.Abstracts;
using Application.Implements;
using Domain.Abstracts;
using Domain.Entities;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Application.Test
{
    [TestFixture]
    public class MuestraServiceTest
    {
        private Mock<IMuestraRepository> _mockRepository;
        private IMuestraService _service;
        Mock<IUnitOfWork> _mockUnitWork;
        List<Muestra> listMuestra;

        [SetUp]
        public void Initialize()
        {
            _mockRepository = new Mock<IMuestraRepository>();
            _mockUnitWork = new Mock<IUnitOfWork>();
            _service = new MuestraService(_mockUnitWork.Object, _mockRepository.Object);
            listMuestra = new List<Muestra>() {
               new Muestra() { Id = "1", Descripcion="test", Identificador="1", Especie="Arabica", AnioCosecha="2010", IdSesionCatado="1", IdPerson="301", Estado="Incompleto"},
               new Muestra() { Id = "2", Identificador="A", Especie="Arabica",Humedad=20, Region="313", IdPerson="301", IdSesionCatado="2", Estado="Incompleto" }
            };
        }

        [Test]
        public void Muestra_Get_All()
        {
            //Arrange
            _mockRepository.Setup(x => x.GetAll()).Returns(listMuestra);

            //Act
            List<Muestra> results = _service.GetAll() as List<Muestra>;

            //Assert
            Assert.IsNotNull(results);
            Assert.AreEqual(2, results.Count);
        }

        [Test]
        public void Can_Add_Muestra()
        {
            //Arrange
            string Id = "3";
            Muestra emp = new Muestra() { Identificador = "A", Especie = "Arabica", Humedad = 20, Region = "313", IdSesionCatado = "2", IdPerson = "301", Estado = "Incompleto" };
            _mockRepository.Setup(m => m.Add(emp)).Returns((Muestra e) =>
            {
                e.Id = Id;
                return e;
            });

            //Act
            _service.Create(emp);

            //Assert
            Assert.AreEqual(Id, emp.Id);
            _mockUnitWork.Verify(m => m.Commit(), Times.Once);
        }
    }
}
