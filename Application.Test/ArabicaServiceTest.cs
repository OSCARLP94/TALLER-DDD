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
    public class ArabicaServiceTest
    {
        private Mock<IArabicaRepository> _mockRepository;
        private IArabicaService _service;
        Mock<IUnitOfWork> _mockUnitWork;
        List<Arabica> listArabica;

        [SetUp]
        public void Initialize()
        {
            _mockRepository = new Mock<IArabicaRepository>();
            _mockUnitWork = new Mock<IUnitOfWork>();
            _service = new ArabicaService(_mockUnitWork.Object, _mockRepository.Object);
            listArabica = new List<Arabica>() {
               new Arabica() { Id = "1", IdMuestra="1",Calificacion=92.5, TotalAcidez=7.5, TotalCuerpo=7.5, TotalBalance=7.5, TotalDulzor=10, Dulzor1= true, Dulzor2=true, Dulzor3= true, Dulzor4= true, Dulzor5= true , TotalFragancia=7.5, TotalGeneral= 7.5, TotalSabor= 7.5, TotalSaborBoca= 7.5, TotalTaza= 0, Taza1=false, Taza2=false, Taza3= false, Taza4=false, Taza5=false, Tueste= 3, TotalUniformidad=0, Uniformidad1=false, Uniformidad2=false, Uniformidad3= false, Uniformidad4=false, Uniformidad5=false },
               new Arabica() { Id = "2",IdMuestra="2", Calificacion=92.5, TotalAcidez=7.5, TotalCuerpo=7.5, TotalBalance=7.5, TotalDulzor=10, Dulzor1= true, Dulzor2=true, Dulzor3= true, Dulzor4= true, Dulzor5= true , TotalFragancia=7.5, TotalGeneral= 7.5, TotalSabor= 7.5, TotalSaborBoca= 7.5, TotalTaza= 0, Taza1=false, Taza2=false, Taza3= false, Taza4=false, Taza5=false, Tueste= 3, TotalUniformidad=0, Uniformidad1=false, Uniformidad2=false, Uniformidad3= false, Uniformidad4=false, Uniformidad5=false}
            };
        }

        [Test]
        public void Arabica_Get_All()
        {
            //Arrange
            _mockRepository.Setup(x => x.GetAll()).Returns(listArabica);

            //Act
            List<Arabica> results = _service.GetAll() as List<Arabica>;

            //Assert
            Assert.IsNotNull(results);
            Assert.AreEqual(2, results.Count);
        }

        [Test]
        public void Can_Add_Arabica()
        {
            //Arrange
            string Id = "3";
            Arabica emp = new Arabica() { IdMuestra = "2", Calificacion = 92.5, TotalAcidez = 7.5, TotalCuerpo = 7.5, TotalBalance = 7.5, TotalDulzor = 10, Dulzor1 = true, Dulzor2 = true, Dulzor3 = true, Dulzor4 = true, Dulzor5 = true, TotalFragancia = 7.5, TotalGeneral = 7.5, TotalSabor = 7.5, TotalSaborBoca = 7.5, TotalTaza = 0, Taza1 = false, Taza2 = false, Taza3 = false, Taza4 = false, Taza5 = false, Tueste = 3, TotalUniformidad = 0, Uniformidad1 = false, Uniformidad2 = false, Uniformidad3 = false, Uniformidad4 = false, Uniformidad5 = false };
            _mockRepository.Setup(m => m.Add(emp)).Returns((Arabica e) =>
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

