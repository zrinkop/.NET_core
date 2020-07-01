
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;
using System;
using System.Linq;
using TestProject.Contracts.Entities;

namespace TestProject.Infrastructure
{
    public class TestDbContext : DbContext
    {
        public DbSet<Catalog> Catalog { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<CatalogItems> CatalogItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(ChangeOptionsType<DbContext>(options))
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var cascadeFKs = builder.Model.GetEntityTypes()
       .SelectMany(t => t.GetForeignKeys())
       .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            base.OnModelCreating(builder);
            builder.Entity<Catalog>().Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Entity<Product>().Property(x => x.IsDeleted).HasDefaultValue(false);
            // composite primary key
            builder.Entity<CatalogItems>()
                .HasKey(x => new { x.ProductId, x.CatalogId });
            // fills test data
            TestData.SeedProducts(builder);
            TestData.SeedCatalogs(builder);
        }

        protected static DbContextOptions<T> ChangeOptionsType<T>(DbContextOptions options) where T : DbContext
        {
            var sqlExt = options.Extensions.FirstOrDefault(e => e is SqlServerOptionsExtension);

            if (sqlExt == null)
                throw (new Exception("Failed to retrieve SQL connection string for base Context"));

            return new DbContextOptionsBuilder<T>()
                        .UseSqlServer(((SqlServerOptionsExtension)sqlExt).ConnectionString)
                        .Options;
        }
    }
}
