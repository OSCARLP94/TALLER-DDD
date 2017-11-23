using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Descriptor : Entity<int>
    {
       
        [Required]
        public string Tipo { get; set; }

        [Required]
        [StringLength(30)]
        public string nombre { get; set; }

    }
}