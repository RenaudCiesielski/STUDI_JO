using Jo.Models;
using JO.Models;
using Microsoft.EntityFrameworkCore;

namespace JO.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Ticket Solo", Description = "Ce ticket est valable pour 1 personne", Price = 195 },
                new Category { Id = 2, Name = "Ticket Duo", Description = "Ce ticket est valable pour 2 personnes", Price = 350 },
                new Category { Id = 3, Name = "Ticket Famille", Description = "Ce ticket est valable pour 4 personnes", Price = 650 });

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = }
                );
        }
    }
}
