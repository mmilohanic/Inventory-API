using Inventory_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory_API.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, ItemName = "Ethernet kabel", Description = "Mrežni kabel U/FTP Cat.6A 5m", Quantity = 25, Price = 6.99m, CreatedAt = new DateTime(2025, 5, 31, 15, 46, 18, DateTimeKind.Utc) },
            new Product { Id = 2, ItemName = "Mrežni preklopnik", Description = "8-portni gigabit switch", Quantity = 5, Price = 30.00m, CreatedAt = new DateTime(2025, 5, 31, 15, 46, 18, DateTimeKind.Utc) },
            new Product { Id = 3, ItemName = "Strujni prekidač", Description = "Monofazni, 16A, B karakteristika, 10kA", Quantity = 15, Price = 5.00m, CreatedAt = new DateTime(2025, 5, 31, 15, 46, 18, DateTimeKind.Utc) },
            new Product { Id = 4, ItemName = "Kabel 4x50", Description = "FG16(OR)16, bakar", Quantity = 35, Price = 80.00m, CreatedAt = new DateTime(2025, 5, 31, 15, 46, 18, DateTimeKind.Utc) }
        );
    }
}