using Microsoft.EntityFrameworkCore;
using EliteTech_Ecommerce.Models;

namespace EliteTech_Ecommerce.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Cart> Carts { get; set; }
    }
}