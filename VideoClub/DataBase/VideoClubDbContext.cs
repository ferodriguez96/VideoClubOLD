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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().Property(cliente => cliente.Id).ValueGeneratedNever();
            modelBuilder.Entity<Categoria>().Property(categoria => categoria.Id).ValueGeneratedNever();
            modelBuilder.Entity<Pelicula>().Property(pelicula => pelicula.Id).ValueGeneratedNever();
            modelBuilder.Entity<Genero>().Property(genero => genero.Id).ValueGeneratedNever();
            modelBuilder.Entity<Alquiler>().Property(alquiler => alquiler.Id).ValueGeneratedNever();
            modelBuilder.Entity<Devolucion>().Property(devolucion => devolucion.Id).ValueGeneratedNever();
            modelBuilder.Entity<PeliculaGenero>().Property(peliculaGenero => peliculaGenero.Id).ValueGeneratedNever();
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
