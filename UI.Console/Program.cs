using Application.Implements;
using Domain.Entities;
using Infraestructura.Data.Base;
using Infraestructure.Data;
using Infraestructure.Data.Repositories;
using SirccELC.Infraestructura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleArchContext context = new SampleArchContext();

            CiudadService service = new CiudadService(new UnitOfWork(context), new CiudadRepository(context));

            Ciudad country = new Ciudad() { Nombre = "Colombia" };

            service.Create(country);

            List<Ciudad> countries=service.GetAll().ToList();

            foreach (var item in countries)
            {
                System.Console.WriteLine(item.Name);
            }

            System.Console.ReadKey();
        }
    }
}
