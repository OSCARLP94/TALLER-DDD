using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Implements
{
    public class MuestraFactoryPrototype : Muestra, ICloneable
    {
        public MuestraFactoryPrototype()
        {

        }
        public object Clone()
        {
            Muestra muestra = new Muestra();
            //muestra.IdSesionCatado = this.IdSesionCatado;
            muestra.Estado = this.Estado;
            muestra.Especie = this.Especie;
            return muestra;
        }
    }
}
