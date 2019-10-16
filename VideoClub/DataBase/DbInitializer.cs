﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoClub.Models;

namespace VideoClub.DataBase
{
    public static class DbInitializer
    {
        public static void Initialize(VideoClubDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Peliculas.Any())
            {
                return;   // DB has been seeded
            }
            Cliente cli = new Cliente()
            {
                Id = 2,
                Nombre = "rodolfo",
                Apellido = "gomez",
                Dni ="test",
                Domicilio="calle falsa 123"
            };
            context.Clientes.Add(cli);
            context.SaveChanges();
        }
    }
}