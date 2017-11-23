using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class ArabicaDescriptor : Entity<int>
    {
      
        [Required]
        [ForeignKey("Arabica")]
        public string IdArabica { get; set; }

        [Required]
        [ForeignKey("Descriptor")]
        public int IdDescriptor { get; set; }

        public virtual Arabica Arabica { get; set; }
        public virtual Descriptor Descriptor { get; set; }
    }
}
