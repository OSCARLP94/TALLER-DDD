using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Finca : Entity<string>
    {


        [Required]
        public string Nombre { get; set; }
       
        [Required]
        [ForeignKey("Vereda")]
        public string IdVereda { get; set; }

        [ForeignKey("Person")]
        public string IdPersona { get; set; }

        public virtual Vereda Vereda { get; set; }
        public virtual Person Person { get; set; }
    }
}