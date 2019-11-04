using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class PeliculaGenero
    {
        public Guid Id { get; set; }
        public int PeliculaId { get; set; }
        public int GeneroId { get; set; }
        public Pelicula Pelicula { get; set; }
        public Genero Genero { get; set; }
    }
}
