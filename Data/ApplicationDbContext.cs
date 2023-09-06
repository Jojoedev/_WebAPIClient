using _WebAPIClient.Model;
using Microsoft.EntityFrameworkCore;

namespace _WebAPIClient.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 1,
                Name = "Bournvita",
                Category = "Beverages",
                Quantity = 10
            },
            new Product()
            {
                Id = 2,
                Name = "Jameson",
                Category = "Wine",
                Quantity = 23
            }, new Product()
            {
                Id = 3,
                Name = "Pepper",
                Category = "Spice",
                Quantity = 65

            }

            );
        }
    }

   
}
