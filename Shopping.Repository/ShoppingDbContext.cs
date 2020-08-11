using Microsoft.EntityFrameworkCore;
using Shopping.CoreService.Models;

namespace Shopping.Repository
{
    public class ShoppingDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public ShoppingDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
