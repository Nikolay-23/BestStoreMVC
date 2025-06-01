using BestStoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BestStoreMVC.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasData(GetProducts());
        }

        private List<Product> GetProducts()
        {
            return Enumerable.Range()
                .Select(i => new Product
                {
                    Id = i,
                    Name = "ASUS ROG Zephyrus",
                    Brand = "ASUS",
                    Category = "Computers",
                    Price = 3771,
                    Description = "ASUS ROG Zephyrus G14 GA402XZ-NC009W, 14.0, WQXGA, AMD Ryzen 9 7940HS (4.0/5.2GHz, 16M), NVIDIA RTX 4080 12 GB GDDR6 DLSS 3, 32 GB, 1 TB SSD - 90NR0DH6-M000L0",
                    ImageFileName = "asus-ga402-rog-zephyrus-g14-2023-456146.jpg",
                    CreatedAt = DateTime.Now
                })
                .ToList();
        }
    }
}
