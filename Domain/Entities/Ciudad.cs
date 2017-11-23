using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Ciudad : Entity<string>
    {
        
        [Required]
        public string Nombre { get; set; }

        [Required]
        public bool Laboratorio { get; set; } 

        [Required]
        [ForeignKey("Departamento")]
        public string IdDepartamento { get; set; }

        public virtual Departamento Departamento { get; set; }
        public ICollection<Vereda> Veredas { get; set; }
    }
}