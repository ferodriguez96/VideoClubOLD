using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Alquiler
    {
        [Key]
        public Guid Id { get; set; }
        
        public Guid PeliculaId { get; set; }
        public virtual Pelicula Pelicula { get; set; }

        [ForeignKey("Cliente")]
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public DateTime FechaAlta { get; set; }//fecha de alquiler
        public DateTime FechaVto { get; set; }//Cuando deberia devolverlo
        public float PrecioOriginal { get; set; }
        public float PrecioFinal { get; set; }

        [ForeignKey("Devolucion")]
        public Guid DevolucionId { get; set; }
        public virtual Devolucion Devolucion { get; set;  }
    }
}
