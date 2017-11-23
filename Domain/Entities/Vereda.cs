using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Vereda : Entity<string>
    {

        [Required]
        public string Nombre { get; set; }

        [Required]
        [ForeignKey("Ciudad")]
        public string IdCiudad { get; set; }

        public virtual Ciudad Ciudad { get; set; }
        public ICollection<Finca> Fincas { get; set; }
    }
}