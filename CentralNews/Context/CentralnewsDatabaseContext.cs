using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CentralNews.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CentralNews.Context
{
    public class CentralnewsDatabaseContext : DbContext
    {
        public CentralnewsDatabaseContext(DbContextOptions<CentralnewsDatabaseContext>
options) : base(options) { 
            
        }
        public DbSet<Noticia> Noticias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comentario>()
                .HasOne(c => c.Usuario)
                .WithMany() // Si hay una colección de comentarios en Usuario, cambia esto por WithMany(u => u.Comentarios)
                .HasForeignKey(c => c.id_usuario);

            modelBuilder.Entity<Comentario>()
                .HasOne(c => c.Noticia)
                .WithMany() // Si hay una colección de comentarios en Noticia, cambia esto por WithMany(n => n.Comentarios)
                .HasForeignKey(c => c.id_noticia);
        }
    }
}
