﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Genero
    {
        [Key()]
        public Guid Id { get; set; }
        public string Descripcion { get; set; }
        public IEnumerable <PeliculaGenero> PeliculasGeneros { get; set; }

    }
}
