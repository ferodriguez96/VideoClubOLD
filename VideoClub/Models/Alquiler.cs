using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Alquiler
    {
        private int id { get; set; }
        private Pelicula pelicula { get; set; }
        private Cliente cliente { get; set; }
        private DateTime fechaAlta { get; set; }//fecha de alquiler
        private DateTime fechaVto { get; set; }//Cuando deberia devolverlo
        private float precioOriginal { get; set; }
        private Devolucion devolucion { get; set;  }
    }
}
