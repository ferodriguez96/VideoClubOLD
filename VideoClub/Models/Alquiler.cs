using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoClub.Models
{
    public class Alquiler
    {
        public Guid Id { get; set; }

        public Guid PeliculaId { get; set; }
        public virtual Pelicula Pelicula { get; set; }

        [ForeignKey("Cliente")]
        public Guid ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        public DateTime FechaAlta { get; set; }//fecha de alquiler
        public DateTime FechaVencimiento { get; set; }//Cuando deberia devolverlo
        public float PrecioOriginal { get; set; }

        [ForeignKey("Devolucion")]
        public Guid? DevolucionId { get; set; }
        public virtual Devolucion Devolucion { get; set;  }
    }
}
