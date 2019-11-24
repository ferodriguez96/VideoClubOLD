using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoClub.Models;

namespace VideoClub.DataBase
{
    public class VideoClubDbContext : DbContext
    {
        public VideoClubDbContext(DbContextOptions<VideoClubDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cliente>().HasIndex(u => u.Email).IsUnique();
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Alquiler> Alquileres { get; set; }
        public DbSet<Devolucion> Devoluciones { get; set; }
        public DbSet<PeliculaGenero> PeliculasGeneros { get; set; }
    }
}
