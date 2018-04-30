using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Multas_tA.Models
{
    public class FilmesDB : DbContext
    {

        // construtor da classe
        public FilmesDB() : base()
        { }

        // identificar as tabelas da base de dados
        public virtual DbSet<Ator> Multas { get; set; }
        public virtual DbSet<Diretor> Condutores { get; set; }
        public virtual DbSet<Escritor> Viaturas { get; set; }
        public virtual DbSet<Filmes> Agentes { get; set; }
        public virtual DbSet<Personagens> Agentes { get; set; }




    }
}