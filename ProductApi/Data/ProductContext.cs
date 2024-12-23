using Microsoft.EntityFrameworkCore;
using ProductApi.Models; 
using System.Data.Entity;

namespace ProductApi.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
