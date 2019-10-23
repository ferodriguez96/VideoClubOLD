using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Pelicula
    {
        public Guid Id { get; set; }

        [MaxLength(100, ErrorMessage = "La longitud máxima de {0} es de {1} caracteres.")]
        [Required(ErrorMessage ="{0} es mandatorio.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "{0} es mandatorio.")]
        public int Duracion { get; set; } //En minutos

        [Required(ErrorMessage = "{0} es mandatorio.")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "{0} es mandatorio.")]
        public int AnioLanzamiento { get; set; }

        public string UnDatoDeTest { get; set; }

        public Guid CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; } //En general, nada que ver con el genero de la pelicula

        public virtual IEnumerable <PeliculaGenero> PeliculasGeneros { get; set; }//Drama, Comedia, Terror...
    }
}
