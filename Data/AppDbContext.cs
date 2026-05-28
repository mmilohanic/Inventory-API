using Inventory_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory_API.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products {get; set;}
}