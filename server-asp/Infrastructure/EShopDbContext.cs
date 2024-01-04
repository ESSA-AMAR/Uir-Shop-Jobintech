using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<CustomerOrders> CustomerOrders { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<ProductOwners> ProductOwners { get; set; }
        public DbSet<ProductSettings> ProductSettings { get; set; }
        public DbSet<Users> Users { get; set; }

    }
}
