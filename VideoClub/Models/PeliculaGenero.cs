using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class PeliculaGenero
    {
        private int id { get; set; }
        private Pelicula pelicula { get; set; }
        private Genero genero { get; set; }
    }
}
