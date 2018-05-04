using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace TrabalhoFinal.Models
{
    public class FilmesDB : DbContext
    {

        // construtor da classe
        public FilmesDB() : base("FilmesConnectionString")
        { }

        // identificar as tabelas da base de dados
        public virtual DbSet<Ator> Ator { get; set; }
        public virtual DbSet<Diretor> Diretor { get; set; }
        public virtual DbSet<Escritor> Escritor { get; set; }
        public virtual DbSet<filme> filme { get; set; }
        public virtual DbSet<Personagens> Personagens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}