using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="Nombre muy largo")]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Apellido muy largo")]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "DNI muy largo")]
        public string Dni { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "MaxLength exceded")]
        public string Domicilio { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "MaxLength exceded")]
        [EmailAddress]
        public string Email { get; set; }

        public virtual ICollection<Alquiler> Alquileres { get; set; }
    }
}
