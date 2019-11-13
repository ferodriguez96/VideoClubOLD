using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoClub.Models
{
    public class Pelicula
    {
        [Key]
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public int Duracion { get; set; } //En minutos
        public int Stock { get; set; }
        public int AnioLanzamiento { get; set; }


        [ForeignKey("Categoria")]
        public virtual Guid CategoriaId { get; set; } //En general, nada que ver con el genero de la pelicula
        public virtual Categoria Categoria { get; set; } //En general, nada que ver con el genero de la pelicula

        public virtual ICollection<Alquiler> Alquileres { get; set; }

        public virtual ICollection<PeliculaGenero> PeliculaGeneros { get; set; }
    }
}
