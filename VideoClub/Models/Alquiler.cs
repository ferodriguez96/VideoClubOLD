using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Alquiler
    {
        public Guid Id { get; set; }
        public Pelicula Pelicula { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaAlta { get; set; }//fecha de alquiler
        public DateTime FechaVto { get; set; }//Cuando deberia devolverlo
        public float PrecioOriginal { get; set; }
        public Devolucion Devolucion { get; set;  }
    }
}
