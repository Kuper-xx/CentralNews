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
    }
}
