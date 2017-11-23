using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    //[Table("Person")]
    public class Person : Entity<string>
    {
        
        [Required]
        [MaxLength(50)]
        public string Cedula { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(100)]
        public string Apellido { get; set; }

        [MaxLength(20)]
        public string Telefono { get; set; }

        public string Correo { get; set; }

        [MaxLength(100)]
        public string Direccion { get; set; }

        public string Nick { get; set; }

        public string Clave { get; set; }

        public bool Permiso { get; set; }

        public string Rol { get; set; }

    }


}
