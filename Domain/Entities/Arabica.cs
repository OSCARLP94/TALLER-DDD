using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Arabica: Entity<string>
    {
        
        [Required]
        [ForeignKey("Muestra")]
        public string IdMuestra { get; set; }

        [Required]
        public double Calificacion {get;set;}

        [Required]
        public int Tueste { get; set; }

        [Required]
        public double TotalAcidez { get; set; }

        [Required]
        public double TotalCuerpo { get; set; }

        [Required]
        public double TotalFragancia{ get; set; }

        [Required]
        public double TotalSabor { get; set; }

        [Required]
        public double TotalSaborBoca { get; set; }

        [Required]
        public double TotalBalance { get; set; }

        [Required]
        public double TotalGeneral { get; set; }

        [Required]
        public int TotalDulzor { get; set; }

        [Required]
        public bool Dulzor1 { get; set; }

        [Required]
        public bool Dulzor2 { get; set; }

        [Required]
        public bool Dulzor3 { get; set; }

        [Required]       
        public bool Dulzor4 { get; set; }

        [Required]      
        public bool Dulzor5 { get; set; }

        [Required]
        public int TotalUniformidad { get; set; }

        [Required]   
        public bool Uniformidad1 { get; set; }

        [Required]     
        public bool Uniformidad2 { get; set; }

        [Required]    
        public bool Uniformidad3 { get; set; }

        [Required]    
        public bool Uniformidad4 { get; set; }

        [Required]     
        public bool Uniformidad5 { get; set; }

        [Required]
        public int TotalTaza { get; set; }

        [Required]
        public bool Taza1 { get; set; }

        [Required]        
        public bool Taza2 { get; set; }

        [Required]       
        public bool Taza3 { get; set; }

        [Required]
        public bool Taza4 { get; set; }

        [Required]    
        public bool Taza5 { get; set; }

        [Required]
        public int Defectos{ get; set; }

        [StringLength(2100)]
        public string Nota { get; set; }

        public virtual Muestra Muestra { get; set; }
    }
}