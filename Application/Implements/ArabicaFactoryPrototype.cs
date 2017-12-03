using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Implements
{
    public class ArabicaFactoryPrototype : Arabica
    {        
        public ArabicaFactoryPrototype()
        {
            
        }
        public Arabica CloneArabica()
        {
            Arabica arabica = new Arabica();
            arabica.Calificacion = 82.5;
            arabica.Tueste = 3;
            arabica.TotalAcidez = 7.5;
            arabica.TotalCuerpo = 7.5;
            arabica.TotalFragancia = 7.5;
            arabica.TotalSabor = 7.5;
            arabica.TotalSaborBoca = 7.5;
            arabica.TotalBalance = 7.5;
            arabica.TotalGeneral = 7.5;
            arabica.TotalDulzor = 10;
            arabica.Dulzor1 = true;
            arabica.Dulzor2 = true;
            arabica.Dulzor3 = true;
            arabica.Dulzor4 = true;
            arabica.Dulzor5 = true;
            arabica.TotalUniformidad = 10;
            arabica.Uniformidad1 = true;
            arabica.Uniformidad2 = true;
            arabica.Uniformidad3 = true;
            arabica.Uniformidad4 = true;
            arabica.Uniformidad5 = true;
            arabica.TotalTaza = 10;
            arabica.Taza1 = true;
            arabica.Taza2 = true;
            arabica.Taza3 = true;
            arabica.Taza4 = true;
            arabica.Taza5 = true;
            arabica.Defectos = 0;
            return arabica;
        }
    }
}
