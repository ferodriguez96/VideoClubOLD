﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VideoClub.Models
{
    public class Genero
    {
        [Key]
        public Guid Id { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<PeliculaGenero> PeliculasGeneros { get; set; }
    }
}
