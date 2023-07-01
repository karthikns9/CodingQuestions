using CQRS.Model;
using Microsoft.EntityFrameworkCore;

namespace CQRS.DB
{
    public class ProductDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite("DataSource=products.db;Cache=Shared");
    }
}
