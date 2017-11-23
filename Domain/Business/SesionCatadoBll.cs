using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Business
{
    public class SesionCatadoBll
    {
        public string ValidateCreate(SesionCatado entity)
        {
            if (entity.CantidadMuestras<0 || entity.CantidadMuestras>15)
            {
                return "Error. # Muestras fuera de rango";
            }
            if(entity.Protocolo != "Arabica")
            {
                return "Error. Protocolo invalido";
            }
            if (entity.Identificador!= "Digitos" && entity.Identificador !="Letras")
            {
                return "Error. Identificador invalido";
            }
            if (entity.Estado!="Incompleto")
            {
                return "Error. Estado inicial incorrecto";
            }
            return "Ok";
        }
        public string ValidateDelete(SesionCatado entity, string idUser)
        {
            if (entity.Estado == "Completo")
            {
                return "Error. Sesion está completa";
            }
            if(entity.IdPerson != idUser)
            {
                return "Error. No tiene permiso sobre esta sesion";
            }
            return "Ok";
        }

        public string ValidateUpdate(SesionCatado current, SesionCatado entity)
        {
            if (current.CantidadMuestras!=entity.CantidadMuestras)
            {
                return "Error. # Muestras deben permanecer constante";
            }
            if (entity.Identificador != "Digitos" && entity.Identificador != "Letras")
            {
                return "Error. Identificador invalido";
            }
            if (entity.Estado != "Incompleto" && entity.Estado != "Completo")
            {
                return "Error. Estado incorrecto";
            }
            if (entity.Estado== "Completo")
            {
                return "Error. Ya no se puede modificar la sesion";
            }
            return "Ok";
        }
        
    }
}
