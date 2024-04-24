using jeuxOlympiques.Models;
using Microsoft.EntityFrameworkCore;

namespace jeuxOlympiques.Data
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
                new Category { Id = 1, Name = "Ticket Solo", Description = "Ce ticket est valable pour 1 personne", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Ticket Duo", Description = "Ce ticket est valable pour 2 personnes", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Ticket Famille", Description = "Ce ticket est valable pour 4 personnes", DisplayOrder = 3 });
        }
    }
}
