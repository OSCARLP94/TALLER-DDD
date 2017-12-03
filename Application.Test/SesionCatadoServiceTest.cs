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
    public class SesionCatadoServiceTest
    {
        private Mock<ISesionCatadoRepository> _mockRepository;
        private ISesionCatadoService _service;
        Mock<IUnitOfWork> _mockUnitWork;
        List<SesionCatado> listSesionCatado;

        [SetUp]
        public void Initialize()
        {
            _mockRepository = new Mock<ISesionCatadoRepository>();
            _mockUnitWork = new Mock<IUnitOfWork>();
            _service = new SesionCatadoService(_mockUnitWork.Object, _mockRepository.Object);
            listSesionCatado = new List<SesionCatado>() {
               new SesionCatado() { Id = "1", FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0), Descripcion="", IdCiudad="311", Identificador="Digitos", Protocolo="Arabica", CantidadMuestras= 1 , IdPerson="201", Estado="Incompleto"},
               new SesionCatado() { Id = "2", FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0), Descripcion="", IdCiudad="313", Identificador="Letras", Protocolo="Arabica", CantidadMuestras= 1, IdPerson="201", Estado="Incompleto" }
            };
        }

        [Test]
        public void SesionCatado_Get_All()
        {
            //Arrange
            _mockRepository.Setup(x => x.GetAll()).Returns(listSesionCatado);

            //Act
            List<SesionCatado> results = _service.GetAll() as List<SesionCatado>;

            //Assert
            Assert.IsNotNull(results);
            Assert.AreEqual(2, results.Count);
        }

        [Test]
        public void Can_Add_SesionCatado()
        {
            //Arrange
            string Id = "3";
            SesionCatado emp = new SesionCatado() { FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0), IdCiudad = "311", Identificador = "Digitos", Protocolo = "Arabica", CantidadMuestras = 1, IdPerson = "201", Estado = "Incompleto" };
            _mockRepository.Setup(m => m.Add(emp)).Returns((SesionCatado e) =>
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
