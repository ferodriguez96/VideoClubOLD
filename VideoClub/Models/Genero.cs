using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Genero
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public IEnumerable <PeliculaGenero> PeliculasGeneros { get; set; }

    }
}
