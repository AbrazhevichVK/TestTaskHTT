using Microsoft.EntityFrameworkCore;
using TestTaskHTT.Storage.Models;


namespace TestTaskHTT.Storage.Context
{
    public partial class ShopContext : DbContext
    {
        public ShopContext()
        {
        }

        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoryDataModel> Categories { get; set; }
        public virtual DbSet<ProductDataModel> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=Shop;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryDataModel>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<ProductDataModel>(entity =>
            {
                entity.Property(e => e.Factory).IsRequired();

                entity.Property(e => e.Name).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
