using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Business
{
    public class PersonaBll
    {
        public string ValidateCatador(Person entity)
        {
            if (entity.Nick.Length < 5 || entity.Nick.Length > 30)
            {
                return "Error. Nick necesita entre 5 a 30 caracteres";
            }

            if (entity.Clave.Length < 6 || entity.Clave.Length > 30)
            {
                return "Error. Contraseña necesita entre 5 a 30 caracteres";
            }

            if (entity.Nick.Any(ch => !Char.IsLetterOrDigit(ch)))
            {
                return "Error. No se admiten caracteres especiales #$%&/()=?¡*[]...";
            }
            return "Ok";
        }

        public string ValidatePersona(Person entity, IEnumerable<Person> personas)
        {
           
            var personaRepetido = personas.FirstOrDefault(o => o.Cedula == entity.Cedula || (o.Nombre == entity.Nombre && o.Apellido == entity.Apellido));
            if (entity.Rol!="Asociado" && entity.Rol !="Particular" && entity.Rol !="Catador")
            {
                return "Error. Rol de persona incorrecto";
            }
            if (personaRepetido != null)
            {
                return "Error. Ya existe la persona " + personaRepetido.Nombre + " " + personaRepetido.Apellido + ", C.C: " + personaRepetido.Cedula;
            }

            return "Ok";
        }
    }
}
