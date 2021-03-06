using Microsoft.EntityFrameworkCore;
using PeliculasApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Genero> Generos { set; get; }
        public DbSet<Actor> Actores { get; set; }
        public DbSet <Cine> Cines { get; set; }
    }
}
