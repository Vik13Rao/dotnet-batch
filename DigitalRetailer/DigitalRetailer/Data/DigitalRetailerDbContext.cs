using DigitalRetailer.Models;
using Microsoft.EntityFrameworkCore;

namespace DigitalRetailer.Data
{
    public class DigitalRetailerDbContext:DbContext
    {
        public DigitalRetailerDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Effect> Effects { get; set; }
        public DbSet<Order> Orders { get; set; }

        
    }
}
