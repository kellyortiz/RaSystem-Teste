using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteProgramacao.Models
{
    public class Context : DbContext
    {
        public DbSet<Autor> autores { get; set; }
        public DbSet<Editora> editoras { get; set; }
        public DbSet<Livro> livro { get; set; }
        public Context(DbContextOptions<Context> opcoes) : base(opcoes)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>()
                .HasKey(bc => new { bc.livroId });
        }
    }
}
