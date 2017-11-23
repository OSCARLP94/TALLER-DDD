using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Domain.Entities
{
    public class SesionCatado : Entity<string>
    {
        public SesionCatado()
        {
            Muestras = new List<Muestra>();
        }
      
        [Required]
        public DateTime FechaInicio { get; set; }

        [StringLength(2100)]
        public string Descripcion { get; set; }
   
        [Required]
        [ForeignKey("Ciudad")]
        public string IdCiudad { get; set; }

        [Required]
        public string Identificador { get; set; }

        [Required]
        public string Protocolo { get; set; }

        [Required]
        public int CantidadMuestras { get; set; }
        
        [Required]
        public string IdPerson { get; set; }

        [Required]
        public string Estado { get; set; }

        public virtual Person Person { get; set; }
        public virtual Ciudad Ciudad { get; set; }
        
        public ICollection<Muestra> Muestras { get; set; }

    }
}