using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ControleEstoque
{
    class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() : base(nameOrConnectionString: "controle_estoque_bq") {}
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
