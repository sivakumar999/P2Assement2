using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Ecommerce.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Additional configuration for your Product entity, if needed
            modelBuilder.Entity<Product>().Property(p => p.ImageUrl).HasMaxLength(255);
        }
    }
}
