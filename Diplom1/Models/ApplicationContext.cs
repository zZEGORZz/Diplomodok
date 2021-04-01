using Microsoft.EntityFrameworkCore;

namespace Diplom1.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            {
                modelBuilder.Entity<Product>().HasData(new Product[] {
                new Product
                {
                    ProductId = 1,
                    Name = "Молоко",
                    Comment = "не еееее",
                    Price = 2
                },

                 new Product
                {
                    ProductId = 2,
                    Name = "Хлэбушек",
                    Comment = "еееее",
                    Price = 1
                }
                });
            }
        }
    }
}