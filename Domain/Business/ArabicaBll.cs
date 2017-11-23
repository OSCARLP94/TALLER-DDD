using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Business
{
    public class ArabicaBll
    {
        public string EditArabica(Arabica entity)
        {
            if (((entity.Defectos < 0) || (entity.TotalAcidez < 0) || (entity.TotalBalance < 0) || (entity.TotalCuerpo < 0) || (entity.TotalDulzor < 0) || (entity.TotalFragancia < 0) || (entity.TotalGeneral < 0) || (entity.TotalSabor < 0)
               || (entity.TotalSaborBoca < 0) || (entity.TotalTaza < 0) || (entity.TotalUniformidad < 0)) || ((entity.TotalAcidez > 10) || (entity.TotalBalance > 10) || (entity.TotalCuerpo > 10) || (entity.TotalDulzor > 10) || (entity.TotalFragancia > 10) || (entity.TotalGeneral > 10) || (entity.TotalSabor > 10)
               || (entity.TotalSaborBoca > 10) || (entity.TotalTaza > 10) || (entity.TotalUniformidad > 10)))
            {
                return "Error. Valor fuera de rango";
            }
            // por seguridad calculamos nuevamente la calificación
            double calification = CalculaPuntaje(entity);

            if (calification < 0 || calification > 100)
            {
                return "Error. Valor fuera de rango";
            }

            entity.Calificacion = calification;
            //todo ok
            return "Ok";
        }
        public double CalculaPuntaje(Arabica entity)
        {
            double Calificacion = entity.TotalAcidez + entity.TotalBalance + entity.TotalCuerpo + Convert.ToDouble(entity.TotalDulzor)
               + entity.TotalFragancia + entity.TotalGeneral + entity.TotalSabor + entity.TotalSaborBoca + Convert.ToDouble(entity.TotalTaza)
               + Convert.ToDouble(entity.TotalUniformidad) - Convert.ToDouble(entity.Defectos);

            return Calificacion;
        }

    }
}
