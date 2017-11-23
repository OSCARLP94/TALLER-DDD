using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Implements
{
    public class ArabicaFactoryPrototype : Arabica, ICloneable
    {        
        public ArabicaFactoryPrototype()
        {
            this.Calificacion = 82.5;
            this.Tueste = 3;
            this.TotalAcidez = 7.5;
            this.TotalCuerpo = 7.5;
            this.TotalFragancia = 7.5;
            this.TotalSabor = 7.5;
            this.TotalSaborBoca = 7.5;
            this.TotalBalance = 7.5;
            this.TotalGeneral = 7.5;
            this.TotalDulzor = 10;
            this.Dulzor1 = true;
            this.Dulzor2 = true;
            this.Dulzor3 = true;
            this.Dulzor4 = true;
            this.Dulzor5 = true;
            this.TotalUniformidad = 10;
            this.Uniformidad1 = true;
            this.Uniformidad2 = true;
            this.Uniformidad3 = true;
            this.Uniformidad4 = true;
            this.Uniformidad5 = true;
            this.TotalTaza = 10;
            this.Taza1 = true;
            this.Taza2 = true;
            this.Taza3 = true;
            this.Taza4 = true;
            this.Taza5 = true;
            this.Defectos = 0;
        }
        public object Clone()
        {
            return this.MemberwiseClone() as Arabica;
        }
    }
}
