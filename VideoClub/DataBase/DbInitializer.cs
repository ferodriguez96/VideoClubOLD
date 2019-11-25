using System;
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

            Categoria azul = new Categoria()
            {
                Id = Guid.NewGuid(),
                Disenio = "blue",
                DiasDeAlquiler = 7,
                Precio = 100,
                Descripcion = ""
            };
            Pelicula titanic = new Pelicula()
            {
                Id = Guid.NewGuid(),
                Titulo = "Titanic",
                AnioLanzamiento = 1994,
                Duracion = 190,
                Stock = 5,
                Categoria = azul
            };

            context.Peliculas.Add(titanic);
            context.Categorias.Add(azul);
            context.SaveChanges();
        }
    }
}
