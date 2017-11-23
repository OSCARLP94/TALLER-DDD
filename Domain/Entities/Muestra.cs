using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Muestra : Entity<string>
    {
       
        [Required]
        public int Identificador { get; set; }

        [StringLength(30)]
        public string Nombre { get; set; }

        [StringLength(2100)]
        public string Descripcion { get; set; }

        public string Especie { get; set; }

        public string AnioCosecha { get; set; }

        public int Humedad { get; set; }

        public string Region { get; set; }

        public string IdentificadorMuestra {
            get {
                return SesionCatado.Identificador == "Digitos"? Identificador.ToString() : Convert.ToChar(64 + Identificador).ToString();
            }
        }
        [Required]
        public string Estado { get; set; }

        [Required]
        [ForeignKey("SesionCatado")]
        public string IdSesionCatado { get; set; }

        [ForeignKey("Person")]
        public string IdPerson { get; set; }

        public virtual SesionCatado SesionCatado { get; set; }
        public virtual Person Person { get; set; }
    }
}