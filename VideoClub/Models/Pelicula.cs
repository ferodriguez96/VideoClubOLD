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
        public string Id { get; set; }
        public string Titulo { get; set; }
        public int Duracion { get; set; } //En minutos
        public int Stock { get; set; }
        public int AnioLanzamiento { get; set; }
        public Categoria Categoria { get; set; } //En general, nada que ver con el genero de la pelicula
        public IEnumerable <PeliculaGenero> PeliculasGeneros { get; set; }//Drama, Comedia, Terror...
    }
}
