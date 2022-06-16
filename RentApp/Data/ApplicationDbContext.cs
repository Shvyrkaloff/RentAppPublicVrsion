using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentApp.Data.Identity;

namespace RentApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity <Product>().Property(z =>z.Id).UseIdentityColumn();
            base.OnModelCreating(builder);
            
        }
        public DbSet<Product> Products { get; set; } 
    }
}