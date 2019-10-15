using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Categoria
    {
        private string id { get; set; }
        private string descripcion { get; set; }
        private string disenio { get; set; } //? supongo aca puedo clavarle el color de la cajita y que se refleje en el front-end
        private int diasDeAlquiler { get; set; }
        private float precio { get; set; }
        private List<Pelicula> peliculas { get; set; }
    }
}
