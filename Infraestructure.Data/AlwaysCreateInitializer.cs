using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data
{
    public class AlwaysCreateInitializer : DropCreateDatabaseAlways<CataneiContext>
    {
        protected override void Seed(CataneiContext context)
        {
            var listPais = new List<Pais>() {
               new Pais() { Id = 1, Nombre = "Colombia" },
            };

            var listDepartamento = new List<Departamento>()
            {
                new Departamento {Id="201", Nombre = "Antioquia", IdPais=1},
                new Departamento {Id="202", Nombre = "Caldas", IdPais=1},
                new Departamento {Id="203", Nombre = "Bogotá D.C.", IdPais=1},
                new Departamento {Id="204", Nombre = "Bolívar", IdPais=1},
                new Departamento {Id="205", Nombre = "Córdoba", IdPais=1},
                new Departamento {Id="206", Nombre = "San Andrés y Providencia", IdPais=1},
                new Departamento {Id="208", Nombre = "Sucre", IdPais=1},
                new Departamento {Id="209", Nombre = "Atlántico", IdPais=1},
                new Departamento {Id="210", Nombre = "Boyacá", IdPais=1},
                new Departamento {Id="211", Nombre = "Arauca", IdPais=1},
                new Departamento {Id="212", Nombre = "Casanare", IdPais=1},
                new Departamento {Id="213", Nombre = "Cauca", IdPais=1},
                new Departamento {Id="214", Nombre = "Valle del Cauca", IdPais=1},
                new Departamento {Id="215", Nombre = "Chocó", IdPais=1},
                new Departamento {Id="216", Nombre = "Nariño", IdPais=1},
                new Departamento {Id="217", Nombre = "Quindío", IdPais=1},
                new Departamento {Id="218", Nombre = "Risaralda", IdPais=1},
                new Departamento {Id="219", Nombre = "Caquetá", IdPais=1},
                new Departamento {Id="220", Nombre = "Amazonas", IdPais=1},
                new Departamento {Id="221", Nombre = "Guainía", IdPais=1},
                new Departamento {Id="222", Nombre = "Guaviare", IdPais=1},
                new Departamento {Id="223", Nombre = "Vaupés", IdPais=1},
                new Departamento {Id="224", Nombre = "Putumayo", IdPais=1},
                new Departamento {Id="225", Nombre = "Cundinamarca", IdPais=1},
                new Departamento {Id="226", Nombre = "Meta", IdPais=1},
                new Departamento {Id="227", Nombre = "Vichada", IdPais=1},
                new Departamento {Id="228", Nombre = "Magdalena", IdPais=1},
                new Departamento {Id="229", Nombre = "Cesar", IdPais=1},
                new Departamento {Id="230", Nombre = "La Guajira", IdPais=1},
                new Departamento {Id="231", Nombre = "Santander", IdPais=1},
                new Departamento {Id="232", Nombre = "Norte de Santander", IdPais=1},
                new Departamento {Id="233", Nombre = "Tolima", IdPais=1},
                new Departamento {Id="234", Nombre = "Huila", IdPais=1}
            };

            var listCiudad = new List<Ciudad>()
            {
                    new Ciudad {Id="311", Nombre = "Valledupar", Laboratorio = true,IdDepartamento="229"},
                    new Ciudad {Id="312", Nombre = "Aguachica", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="313", Nombre = "Agustín Codazzi", Laboratorio = true,IdDepartamento="229"},
                    new Ciudad {Id="314", Nombre = "Astrea", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="315", Nombre = "Becerril", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="316", Nombre = "Bosconia", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="317", Nombre = "Chimichagua", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="318", Nombre = "Chiriguaná", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="319", Nombre = "Curumaní", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="320", Nombre = "El Copey", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="321", Nombre = "El Paso", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="322", Nombre = "Gamarra", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="323", Nombre = "González", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="324", Nombre = "La Gloria", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="325", Nombre = "La Jagua de Ibirico", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="326", Nombre = "Manaure Balcón del Cesar", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="327", Nombre = "Pailitas", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="328", Nombre = "Pelaya", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="329", Nombre = "Pueblo Bello", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="330", Nombre = "Río de Oro", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="331", Nombre = "La Paz", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="332", Nombre = "San Alberto", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="333", Nombre = "San Diego", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="334", Nombre = "San Martín", Laboratorio = false,IdDepartamento="229"},
                    new Ciudad {Id="335", Nombre = "Tamalameque", Laboratorio = false,IdDepartamento="229"},
            };

            var listPerson = new List<Person>()
            {
                new Person {Id="101", Cedula="1062500", Nombre="Admin", Apellido="Anei", Telefono="5768461", Correo="anei@hotmail.com", Nick = "Admin", Clave="123456", Permiso=true, Rol="Administrador"},
                new Person {Id="201", Cedula="1062601", Nombre="Empresa", Apellido="Anei", Telefono="5768471", Correo="anei2@hotmail.com",  Nick = "Empresa", Clave="123456", Permiso=true, Rol="Catador"},

                new Person { Id = "301", Cedula = "106234500", Nombre = "Oscar Orlando", Apellido = "Lozano Wilches", Telefono = "5768461",Correo= "Orlando@hotmail.com", Permiso=false, Rol= "Asociado"},
            };

            var listSesion = new List<SesionCatado>()
            {
                new SesionCatado() { Id = "1", FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0), Descripcion="", IdCiudad="311", Identificador="Digitos", Protocolo="Arabica", CantidadMuestras= 1 , IdPerson="201", Estado="Incompleto"},
               new SesionCatado() { Id = "2", FechaInicio = new DateTime(2008, 6, 1, 7, 47, 0), Descripcion="", IdCiudad="313", Identificador="Letras", Protocolo="Arabica", CantidadMuestras= 1, IdPerson="201", Estado="Incompleto" }
            };

            var listMuestra = new List<Muestra>()
            {
               new Muestra() { Id = "1", Descripcion="test", Identificador=1, Especie="Arabica", AnioCosecha="2010", IdSesionCatado="1", IdPerson="301", Estado="Incompleto"},
               new Muestra() { Id = "2", Identificador=1, Especie="Arabica",Humedad=20, Region="313", IdPerson="301", IdSesionCatado="2", Estado="Incompleto" }
            };

            var listArabica = new List<Arabica>()
            {
                new Arabica() { Id = "1", IdMuestra="1",Calificacion=62.5, TotalAcidez=7.5, TotalCuerpo=7.5, TotalBalance=7.5, TotalDulzor=10, Dulzor1= true, Dulzor2=true, Dulzor3= true, Dulzor4= true, Dulzor5= true , TotalFragancia=7.5, TotalGeneral= 7.5, TotalSabor= 7.5, TotalSaborBoca= 7.5, TotalTaza= 0, Taza1=false, Taza2=false, Taza3= false, Taza4=false, Taza5=false, Tueste= 3, TotalUniformidad=0, Uniformidad1=false, Uniformidad2=false, Uniformidad3= false, Uniformidad4=false, Uniformidad5=false },
               new Arabica() { Id = "2",IdMuestra="2", Calificacion=60.5, TotalAcidez=7.5, TotalCuerpo=7.5, TotalBalance=7.5, TotalDulzor=0, Dulzor1= false, Dulzor2=false, Dulzor3= false, Dulzor4= false, Dulzor5= false , TotalFragancia=7.5, TotalGeneral= 7.5, TotalSabor= 7.5, TotalSaborBoca= 7.5, TotalTaza= 8, Taza1=true, Taza2=true, Taza3= true, Taza4=true, Taza5=false, Tueste= 3, TotalUniformidad=0, Uniformidad1=false, Uniformidad2=false, Uniformidad3= false, Uniformidad4=false, Uniformidad5=false}
            };

            context.Pais.AddRange(listPais);
            context.Departamento.AddRange(listDepartamento);
            context.Ciudad.AddRange(listCiudad);
            context.Person.AddRange(listPerson);
            context.SesionCatado.AddRange(listSesion);
            context.Muestra.AddRange(listMuestra);
            context.Arabica.AddRange(listArabica);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
