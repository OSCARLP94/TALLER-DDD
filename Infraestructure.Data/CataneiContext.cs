using Domain.Entities;
using Infraestructura.Data.Base;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data
{
    public class CataneiContext : DbContextBase
    {
        public CataneiContext(): base("Name=CataneiContext")
        {
            //Create database always, even If exists
            Database.SetInitializer<CataneiContext>(new AlwaysCreateInitializer());
        }
        protected CataneiContext(DbConnection connection)
          : base(connection)
        {

        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Vereda> Vereda { get; set; }
        public DbSet<Finca> Finca { get; set; }
        public DbSet<SesionCatado> SesionCatado { get; set; }
        public DbSet<Muestra> Muestra { get; set; }
        public DbSet<Arabica> Arabica { get; set; }
        public DbSet<Descriptor> Descriptor { get; set; }
        public DbSet<ArabicaDescriptor> ArabicaDescriptor { get; set; }     
    }

}
