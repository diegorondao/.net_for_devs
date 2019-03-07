using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EstudoLivro01.Models
{
    public class EFContext : DbContext
    {
        public EFContext()
        {
            Database.SetInitializer<EFContext>(
            new DropCreateDatabaseIfModelChanges<EFContext>());
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}