using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VideoClub.Models
{
    public class Cliente
    {
        [Key()]
        public Guid Id { get; set; }

        [MaxLength(50, ErrorMessage = "Nombre incorrecto")]
        public string Nombre { get; set; }

        [MaxLength(50, ErrorMessage = "Apellido incorrecto")]
        public string Apellido { get; set; }

        [MaxLength(10, ErrorMessage = "Dni incorrecto")]
        public string Dni { get; set; }

        [MaxLength(100, ErrorMessage = "La longitud máxima del domicilio es de {0} caracteres.")]
        public string Domicilio { get; set; }

        [EmailAddress(ErrorMessage ="El parámetro debe ser un email válido")]
        [MaxLength(50, ErrorMessage = "la longitud máxima del email es de {0} caracteres")]
        public string Email { get; set; }

        public List<Alquiler> Alquileres { get; set; }
    }
}
