using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Pelicula
    {
        /*
        private string id { get; set; }
        private string titulo { get; set; }
        private string director { get; set; }
        private int anio { get; set; }
        private List<string> reparto { get; set; }
        private Categoria categoria { get; set; }
        private int tiempoDeAlquiler { get; set; }
        private int Stock { get; set; }
        private List<Alquiler> alquileres { get; set; }
        */
        private string id { get; set; }
        private string titulo { get; set; }
        private int duracion { get; set; } //En minutos
        private int stock { get; set; }
        private int anioLanzamiento { get; set; }
        private Categoria categoria { get; set; } //En general, nada que ver con el genero de la pelicula
        private PeliculaGenero peliculaGeneros { get; set; }//Drama, Comedia, Terror...
    }
}
