using jeuxOlympiquesRazor_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace jeuxOlympiquesRazor_Temp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Ticket Solo", Description = "Ce ticket est valable pour 1 personne", Price = 195 },
                new Category { Id = 2, Name = "Ticket Duo", Description = "Ce ticket est valable pour 2 personnes", Price = 350 },
                new Category { Id = 3, Name = "Ticket Famille", Description = "Ce ticket est valables pour 4 personnes", Price = 650 });
        }
    }
}