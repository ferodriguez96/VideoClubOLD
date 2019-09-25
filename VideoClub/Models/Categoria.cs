using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Categoria
    {
        private string id { get; set; }
        private string nombre { get; set; }
        private List<Pelicula> peliculas { get; set; }
    }
}
