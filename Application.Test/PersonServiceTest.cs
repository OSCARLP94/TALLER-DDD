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
    public class PersonServiceTest
    {
        private Mock<IPersonRepository> _mockRepository;
        private IPersonService _service;
        Mock<IUnitOfWork> _mockUnitWork;
        List<Person> listPerson;

        [SetUp]
        public void Initialize()
        {
            _mockRepository = new Mock<IPersonRepository>();
            _mockUnitWork = new Mock<IUnitOfWork>();
            _service = new PersonService(_mockUnitWork.Object, _mockRepository.Object);
            listPerson = new List<Person>() {
               new Person() { Id = "1", Cedula = "121324", Nombre="Carol", Apellido="Araias", Nick="Empresa", Clave="123$1231$#", Permiso=true, Rol="Catador"},
               new Person() { Id = "2", Cedula= "5435343", Nombre="Isaias", Apellido="Escobar", Permiso=false, Rol="Asociado" }
            };
        }

        [Test]
        public void Person_Get_All()
        {
            //Arrange
            _mockRepository.Setup(x => x.GetAll()).Returns(listPerson);

            //Act
            List<Person> results = _service.GetAll() as List<Person>;

            //Assert
            Assert.IsNotNull(results);
            Assert.AreEqual(2, results.Count);
        }

        [Test]
        public void Can_Add_Person_Asociado()
        {
            //Arrange
            string Id = "43";
            Person emp = new Person() { Cedula = "545343", Nombre = "Maria elena", Apellido = "Escobar", Permiso = false, Rol = "Asociado" };
            _mockRepository.Setup(m => m.Add(emp)).Returns((Person e) =>
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

        [Test]
        public void Can_Add_Person_Catador()
        {
            //Arrange
            string Id = "13";
            Person emp = new Person() { Cedula = "5315343", Nombre = "Alfalfa", Apellido = "Escobar", Nick = "Testea", Clave = "12$1231$#", Permiso = true, Rol = "Catador" };
            _mockRepository.Setup(m => m.Add(emp)).Returns((Person e) =>
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
