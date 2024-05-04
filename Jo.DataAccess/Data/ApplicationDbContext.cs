using Jo.Models;
using JO.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JO.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Ticket Solo", Description = "Ce ticket est valable pour 1 personne", Price = 195 },
                new Category { Id = 2, Name = "Ticket Duo", Description = "Ce ticket est valable pour 2 personnes", Price = 350 },
                new Category { Id = 3, Name = "Ticket Famille", Description = "Ce ticket est valable pour 4 personnes", Price = 650 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Ticket Solo", Description = "Ce ticket est valable pour 1 personne", Quantity = 1000, Price = 195 },
                new Product { Id = 2, Name = "Ticket Duo", Description = "Ce ticket est valable pour 2 personnes", Quantity = 1000, Price = 350 },
                new Product { Id = 3, Name = "Ticket Famille", Description = "Ce ticket est valable pour 4 personnes", Quantity = 1000, Price = 650 }
                );
        }
    }
}
