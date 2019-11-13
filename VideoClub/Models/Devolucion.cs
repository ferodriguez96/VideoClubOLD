using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoClub.Models
{
    public class Devolucion
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public float PrecioFinal { get; set; }

        [ForeignKey("Alquiler")]
        public Guid AlquilerId { get; set; }
        public virtual Alquiler Alquiler { get; set; }
    }
}
