using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Categoria
    {
        public Guid Id { get; set; }
        public string Descripcion { get; set; }
        public string Disenio { get; set; } //? supongo aca puedo clavarle el color de la cajita y que se refleje en el front-end
        public int DiasDeAlquiler { get; set; }
        public float Precio { get; set; }
        public virtual ICollection<Pelicula> Peliculas { get; set; }
    }
}
