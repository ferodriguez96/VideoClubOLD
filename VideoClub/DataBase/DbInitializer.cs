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


            //context.Clientes.Add(new Cliente()
            //{
            //    Id = Guid.NewGuid(),
            //    Nombre = "rodolfo",
            //    Apellido = "gomez",
            //    Dni = "test",
            //    Domicilio = "calle falsa 123"
            //});

            var azul = new Categoria()
            {
                Id = Guid.NewGuid(),
                Disenio = "blue",
                DiasDeAlquiler = 7,
                Precio = 100,
                Descripcion = ""
            };

            context.Categorias.Add(azul);

            var drama = new Genero()
            {
                Id = Guid.NewGuid(),
                Descripcion = "Drama"
            };

            var terror = new Genero()
            {
                Id = Guid.NewGuid(),
                Descripcion = "Terror"
            };

            context.Generos.Add(drama);
            context.Generos.Add(terror);

            var titanic = new Pelicula()
            {
                Id = Guid.NewGuid(),
                Titulo = "Titanic",
                AnioLanzamiento = 1994,
                Duracion = 190,
                Stock = 5,
                Categoria = azul
            };

            context.Peliculas.Add(titanic);

            context.PeliculasGeneros.Add(new PeliculaGenero()
            {
                Id = Guid.NewGuid(),
                Genero = drama,
                Pelicula = titanic
            });

            Pelicula it = new Pelicula()
            {
                Id = Guid.NewGuid(),
                Titulo = "It",
                AnioLanzamiento = 1990,
                Duracion = 120,
                Stock = 10,
                Categoria = azul
            };

            context.Peliculas.Add(it);

            context.PeliculasGeneros.Add(new PeliculaGenero()
            {
                Id = Guid.NewGuid(),
                Genero = terror,
                Pelicula = it
            });

            Pelicula viernes13 = new Pelicula()
            {
                Id = Guid.NewGuid(),
                Titulo = "Viernes 13",
                AnioLanzamiento = 1987,
                Duracion = 116,
                Stock = 17,
                Categoria = azul
            };

            context.Peliculas.Add(viernes13);

            context.PeliculasGeneros.Add(new PeliculaGenero()
            {
                Id = Guid.NewGuid(),
                Genero = terror,
                Pelicula = viernes13
            });

            context.SaveChanges();
        }
    }
}
