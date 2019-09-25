using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Alquiler
    {
        private Pelicula pelicula { get; set; }
        private Cliente cliente { get; set; }
        private DateTime fechaAlquiler { get; set; }
        private Boolean devuelta { get; set;  }
    }
}
