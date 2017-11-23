using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Pais : Entity<int>
    {
       
        [Required]
        public string Nombre{ get; set; }
        
        public virtual ICollection<Departamento> Departamentos { get; set; }
    }
}