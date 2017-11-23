using Domain.Entities;
using Infraestructure.Data.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data.Test
{
    //[TestFixture]
    //public class PersonRepositoryTest
    //{
    //    DbConnection connection;
    //    SampleArchContextTest databaseContext;
    //    PersonRepository objRepo;

    //    [SetUp]
    //    public void Initialize()
    //    {
    //        connection = Effort.DbConnectionFactory.CreateTransient();
    //        databaseContext = new SampleArchContextTest(connection);
    //        objRepo = new PersonRepository(databaseContext);
    //    }

    //    [Test]
    //    public void Person_Repository_Get_ALL()
    //    {
    //        //Act
    //        var result = objRepo.GetAll().ToList();

    //        //Assert

    //        Assert.IsNotNull(result);
    //        Assert.AreEqual(4, result.Count);
    //        Assert.AreEqual("Admin", result[0].Nick);
    //        Assert.AreEqual("Empresa", result[1].Nick);
    //    }

    //    [Test]
    //    public void Person_Repository_Create()
    //    {
    //        //Arrange
    //        Person c = new Person() { Id = "2", Cedula = "5435343", Nombre = "Isaias", Apellido = "Escobar", Permiso = false, Rol = "Asociado" };

    //        //Act
    //        objRepo.Add(c);
    //        databaseContext.SaveChanges();

    //        var lst = objRepo.GetAll().ToList();

    //        //Assert

    //        Assert.AreEqual(3, lst.Count);
    //        Assert.AreEqual("Isaias", lst.Last().Nombre);
    //    }
    //}
}
