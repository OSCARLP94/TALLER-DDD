using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Departamento : Entity<string>
    {
      
        [Required]
        public string Nombre { get; set; }
 
        [Required]
        [ForeignKey("Pais")]
        public int IdPais { get; set; }

        public virtual Pais Pais { get; set; }
        public ICollection<Ciudad> Ciudades { get; set; }
    }
}